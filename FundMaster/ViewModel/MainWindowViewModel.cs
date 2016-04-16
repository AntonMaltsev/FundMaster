using System.Collections.ObjectModel;
using System.Windows.Input;
using FundMaster.ViewModel.Services;
using FundMaster.ViewModel.Commands;
using FundMaster.Entity;
using FundMaster.EntityDAL;
using System.Collections.Generic;
using System.Linq;

namespace FundMaster
{
    public class MainWindowViewModel : ViewModelBase
    {

        FundMasterContext fmc = new FundMasterContext();
        public MainWindowViewModel()
            {
                this.Initialize();
            }

        #region Fund Tab

        public ICommand AddFundItem { get; set;}   // Add Button command
        private string p_FundName;
        private int p_isDeletedFund;

        public int isDeletedFund
        {
            get
            {
                return p_isDeletedFund;
            }
            set
            {
                p_isDeletedFund = value;
                base.RaisePropertyChangedEvent("isDeletedFund");
            }

        }
        public string FundName
        {
            get { return p_FundName; }

            set
            {
                p_FundName = value;
                base.RaisePropertyChangedEvent("FundName");
            }
        }

        private ObservableCollection<Fund> p_FundsList;

        public ObservableCollection<Fund> FundsList
        {
            get
            {
                return p_FundsList;
            }

            set
            {
                p_FundsList = value;
                base.RaisePropertyChangedEvent("FundsList");
            }
        }

        void OnFundsListChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var fundRep = new FundRepository();
            
            this.FundsList = new ObservableCollection<Fund>(fundRep.GetAllFundsQuery().ToList());
            base.RaisePropertyChangedEvent("FundsList");
        }

        #endregion 



        private List<Security> _securities;
        public List<Security> Securities
        {
            get
            {
                return _securities;
            }
            set
            {
                _securities = value;
                RaisePropertyChangedEvent();
            }
        }

        private Security _selectedSecurity;
        public Security SelectedSecurity
        {
            get
            {
                return _selectedSecurity;
            }
            set
            {
                _selectedSecurity = value;
                RaisePropertyChangedEvent();
                //FillSecurity();
            }
        }

        private void Initialize()
        {
            var fundRep = new FundRepository();
            this.AddFundItem = new AddFundItemCommand(this);

            FundsList = new ObservableCollection<Fund> (fundRep.GetAllFundsQuery().ToList());
            p_FundsList.CollectionChanged += OnFundsListChanged;
            base.RaisePropertyChangedEvent("FundsList");
        }
    }
}
