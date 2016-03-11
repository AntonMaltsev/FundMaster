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

            var secRep = new SecurityRepository();
            var fundRep = new FundRepository();

            dataGrid_Fund.ItemsSource = fundRep.GetAllFundsQuery().ToList();
            SecType_comboBox.ItemsSource = secRep.GetSecurityTypes().ToList();
            securities_dataGrid.ItemsSource = secRep.GetSecurityQuery().ToList();
        }

        private void FundSave_button_Click(object sender, RoutedEventArgs e)
        {
            var fundRep = new FundRepository();
            Fund fund = new Fund();

            fund = fundRep.CreateReferencedObject();
            fund.IsDeleted = ((bool)Deleted_checkbox.IsChecked) ? true : false;
            fund.Name = FundName_txt.Text;
            
            fundRep.Save();

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
    }
}
