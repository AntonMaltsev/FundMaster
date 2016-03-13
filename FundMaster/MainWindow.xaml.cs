using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            securities_dataGrid.ItemsSource = secRep.GetSecurityQuery().ToList();
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
                sec         =   secRep.CreateReferencedObject();
                sec.Name    =   security_textBox.Text;
                sec.Price   =   Convert.ToDecimal(secprice_textBox.Text);
                sec.Qty     =   Convert.ToInt32(secQty_textBox.Text);
                sec.SecurityTypeId  = secRep.GetSecurityTypeByName(SecType_comboBox.SelectedItem.ToString()).Id;
                sec.IsDeleted       = ((bool)security_checkBox.IsChecked) ? true : false;

                secRep.Save();
            }
            else
            {
                FundName_txt.Text = "Already exists such Sec name. Please try again.";
            }

            securities_dataGrid.ItemsSource = secRep.GetSecurityQuery().ToList();
        }
    }
}
