using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FundMaster.EntityDAL;
using FundMaster.Entity;

namespace FundMaster
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;

            var secRep  = new SecurityRepository();
            var fundRep = new FundRepository();

            dataGrid_Fund.ItemsSource       = fundRep.GetAllFundsQuery().ToList();
            SecType_comboBox.ItemsSource    = secRep.GetSecurityTypes().ToList();
            securities_dataGrid.ItemsSource = secRep.GetAllSecuritiesQuery().ToList();
        }

        private void FundSave_button_Click(object sender, RoutedEventArgs e)
        {
            var fundRep = new FundRepository();
            Fund fund = new Fund();

            if (fundRep.FindByName(FundName_txt.Text) == null)
            {
                fund = fundRep.CreateReferencedObject();
                fund.IsDeleted = ((bool)Deleted_checkbox.IsChecked) ? true : false;
                fund.Name = FundName_txt.Text;

                fundRep.Save();
            }
            else{
                FundName_txt.Text = "Already exists such Fund name. Please try again.";
            }
               
            dataGrid_Fund.ItemsSource = fundRep.GetAllFundsQuery().ToList();
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
                sec                 =   secRep.CreateReferencedObject();
                sec.Name            =   security_textBox.Text;
                sec.Price           =   Convert.ToDecimal(secprice_textBox.Text);
                sec.Qty             =   Convert.ToInt32(secQty_textBox.Text);
                sec.SecurityTypeId  =   secRep.GetSecurityTypeByName(SecType_comboBox.SelectedItem.ToString()).Id;
                sec.IsDeleted       =   ((bool)security_checkBox.IsChecked) ? true : false;

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
            FM_sec_fund_list_dataGrid.ItemsSource = secRep.GetSecuritiesByFundId(fundRep.FindByName(funds_comboBox.SelectedItem.ToString()).Id).ToList();
        }

        private void FM_sec_list_dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (FM_sec_list_dataGrid.SelectedItem == null)
                return;
            
            var sfRep   = new SecFundRepository();
            var fundRep = new FundRepository();
            var secRep  = new SecurityRepository();

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
            else if(secFund.IsDeleted == true)
            {
                secFund.IsDeleted = false;
                sfRep.Save();
            }
            else
                security_textBox.Text = "Already exists such Sec name. Please try again.";

            FM_sec_fund_list_dataGrid.ItemsSource = null;
            FM_sec_fund_list_dataGrid.ItemsSource = secRep.GetSecuritiesByFundId(fundId).ToList();            
        }

        private void FM_sec_fund_list_dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (FM_sec_fund_list_dataGrid.SelectedItem == null)
                return;

            var sfRep = new SecFundRepository();
            var fundRep = new FundRepository();
            var secRep = new SecurityRepository();

            int fundId = fundRep.FindByName(funds_comboBox.SelectedItem.ToString()).Id;
            Security row = (Security)FM_sec_fund_list_dataGrid.SelectedItems[0];
            int secId = Convert.ToInt32(row.Id);

            var secFund = sfRep.SecFundByIds(fundId, secId);

            secFund.IsDeleted = true;
            sfRep.Save();

            FM_sec_fund_list_dataGrid.ItemsSource = null;
            FM_sec_fund_list_dataGrid.ItemsSource = secRep.GetSecuritiesByFundId(fundId).ToList();
        }
    }
}
