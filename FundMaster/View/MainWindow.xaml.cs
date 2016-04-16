using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using FundMaster.EntityDAL;
using FundMaster.Entity;
using FundMaster.Utils;

namespace FundMaster
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private MainWindowViewModel m_ViewModel;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            var secRep = new SecurityRepository();
            var fundRep = new FundRepository();

            SecType_comboBox.ItemsSource = secRep.GetSecurityTypes().ToList();
            securities_dataGrid.ItemsSource = secRep.GetAllSecuritiesQuery().ToList();
        }

        private void dataGrid_Fund_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var fundRep = new FundRepository();
            dataGrid_Fund.ItemsSource = fundRep.GetAllFundsQuery().ToList();
        }

        private void securities_dataGrid_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void SecurityAdd_btn_Click(object sender, RoutedEventArgs e)
        {
            var secRep = new SecurityRepository();
            Security sec = new Security();

            if (secRep.GetSecurityByName(security_textBox.Text) == null)
            {
                sec = secRep.CreateReferencedObject();
                sec.Name = security_textBox.Text;
                sec.Price = Convert.ToDecimal(secprice_textBox.Text);
                sec.Qty = Convert.ToInt32(secQty_textBox.Text);
                sec.SecurityTypeId = secRep.GetSecurityTypeByName(SecType_comboBox.SelectedItem.ToString()).Id;
                sec.IsDeleted = ((bool)security_checkBox.IsChecked) ? true : false;

                secRep.Save();
            }
            else
            {
                security_textBox.Text = "Already exists such Sec name. Please try again.";
            }

            securities_dataGrid.ItemsSource = secRep.GetAllSecuritiesQuery().ToList();
        }

        private void SecurityRefresh_btn_Click(object sender, RoutedEventArgs e)
        {
            var secRep = new SecurityRepository();

            securities_dataGrid.ItemsSource = secRep.GetAllSecuritiesQuery().ToList();
        }

        private void funds_comboBox_DropDownOpened(object sender, EventArgs e)
        {
            var secFund = new FundRepository();

            funds_comboBox.ItemsSource = secFund.GetFundsNames().ToList();
        }

        private void FM_Refresh_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void funds_comboBox_DropDownClosed(object sender, EventArgs e)
        {
            var fundRep = new FundRepository();
            var secRep = new SecurityRepository();

            FM_sec_list_dataGrid.ItemsSource = secRep.GetSecurityQuery().ToList();
            if (funds_comboBox.SelectedItem !=null)
                refresh_fund_datagrid(fundRep.FindByName(funds_comboBox.SelectedItem.ToString()).Id);
        }

        private void FM_sec_list_dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (FM_sec_list_dataGrid.SelectedItem == null)
                return;

            var sfRep = new SecFundRepository();
            var fundRep = new FundRepository();
            var secRep = new SecurityRepository();

            int fundId = fundRep.FindByName(funds_comboBox.SelectedItem.ToString()).Id;
            Security row = (Security)FM_sec_list_dataGrid.SelectedItems[0];
            int secId = Convert.ToInt32(row.Id);

            SecFund secFund = sfRep.SecFundByIds(fundId, secId);
            if (secFund == null)
            {
                secFund = sfRep.CreateReferencedObject();
                secFund.FundId = fundId;
                secFund.SecurityId = secId;
                secFund.IsDeleted = false;

                sfRep.Save();
            }
            else if (secFund.IsDeleted == true)
            {
                secFund.IsDeleted = false;
                sfRep.Save();
            }
            else
                security_textBox.Text = "Already exists such Sec name. Please try again.";

            FM_sec_fund_list_dataGrid.ItemsSource = null;
            refresh_fund_datagrid(fundId);
        }

        private void FM_sec_fund_list_dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (FM_sec_fund_list_dataGrid.SelectedItem == null)
                return;

            var sfRep = new SecFundRepository();
            var fundRep = new FundRepository();
            var secRep = new SecurityRepository();

            int fundId = fundRep.FindByName(funds_comboBox.SelectedItem.ToString()).Id;
            Security row = (Security)FM_sec_fund_list_dataGrid.SelectedItem;
            int secId = Convert.ToInt32(row.Id);

            var secFund = sfRep.SecFundByIds(fundId, secId);

            secFund.IsDeleted = true;
            sfRep.Save();

            refresh_fund_datagrid(fundId);
        }

        public void refresh_fund_datagrid(int fundId)
        {
            ////////////////////
            // Data processing
            ////////////////////

            var secRep = new SecurityRepository();
            decimal? totalMktVal=0;

            // get Total MktValue
            foreach (Security sec in secRep.GetSecuritiesByFundId(fundId).ToList())
            {
                sec.MktValue = sec.Qty * sec.Price;
                sec.TransactionCost = secRep.GetSecurityTypeById(sec.SecurityTypeId).FeeRate * sec.MktValue / 100;
                totalMktVal = (sec.MktValue != null)? totalMktVal + sec.MktValue: totalMktVal;
            }

            totalMktVal = (totalMktVal == 0) ? 1 : totalMktVal;
            
            // set SecWeight
                            
            foreach (Security sec in secRep.GetSecuritiesByFundId(fundId).ToList())
                sec.SecWeight = Math.Round((decimal)(sec.MktValue * 100 / totalMktVal), 2, MidpointRounding.AwayFromZero);

            secRep.Save();

            FM_sec_fund_list_dataGrid.ItemsSource = secRep.GetSecuritiesByFundId(fundId).ToList();
            FM_sec_fund_list_dataGrid.Items.Refresh();

            // Get Summary Data per Fund

            var secRep1 = new SecurityRepository();
            List<FundSummary> fs = new List<FundSummary> { };
            
            foreach (SecurityType st in secRep.GetAllSecurityTypesQuery())
                fs.Add(secRep1.GetFundSummaryBySecTypeId(fundId, st.Id));

            fundSummary_dataGrid.ItemsSource = null;
            fundSummary_dataGrid.ItemsSource = fs;
            fundSummary_dataGrid.Items.Refresh();

            // Set row color
            foreach (Security item in FM_sec_fund_list_dataGrid.Items.SourceCollection)
            {
                var row = FM_sec_fund_list_dataGrid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                if (row == null)
                {
                    FM_sec_fund_list_dataGrid.UpdateLayout();
                    FM_sec_fund_list_dataGrid.ScrollIntoView(item);
                    row = (DataGridRow)FM_sec_fund_list_dataGrid.ItemContainerGenerator.ContainerFromItem(item);
                }

                if ((secRep.GetSecurityTypeById(item.SecurityTypeId).Tolerance.HasValue)
                    && ((item.MktValue < 0) || (item.TransactionCost > secRep.GetSecurityTypeById(item.SecurityTypeId).Tolerance)))
                    row.Background = Brushes.Red; 
            }
            // Set Fund summary Information
        }

        private void OnMainGridDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            m_ViewModel = (MainWindowViewModel)this.DataContext;
        }
    }
}