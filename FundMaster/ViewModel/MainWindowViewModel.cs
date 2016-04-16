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

        #region Securities Tab

        public ICommand AddSecurityItem { get; set; }   // Add Button command
        private string p_SecName;
        private string p_secPrice;

        public string SecPrice
        {
            get
            {
                return p_secPrice;
            }
            set
            {
                p_secPrice = value;
                base.RaisePropertyChangedEvent("SecPrice");
            }
        }

        public string SecName
        {
            get { return p_SecName; }

            set
            {
                p_SecName = value;
                base.RaisePropertyChangedEvent("SecName");
            }
        }

        private int p_isDeletedSec;

        public int isDeletedSec
        {
            get
            {
                return p_isDeletedSec;
            }
            set
            {
                p_isDeletedSec = value;
                base.RaisePropertyChangedEvent("isDeletedSec");
            }
        }

        private int p_secQty;

        public int SecQty
        {
            get
            {
                return p_secQty;
            }
            set
            {
                p_secQty = value;
                base.RaisePropertyChangedEvent("SecQty");
            }
        }

        private string p_secType;
        public string SecType
        {
            get { return p_secType; }

            set
            {
                p_secType = value;
                base.RaisePropertyChangedEvent("SecType");
            }
        }

        private ObservableCollection<Security> p_SecList;

        public ObservableCollection<Security> SecList
        {
            get
            {
                return p_SecList;
            }

            set
            {
                p_SecList = value;
                base.RaisePropertyChangedEvent("SecList");
            }
        }

        void OnSecListChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            var secRep = new SecurityRepository();

            this.SecList = new ObservableCollection<Security>(secRep.GetAllSecuritiesQuery().ToList());
            base.RaisePropertyChangedEvent("SecList");
        }

        #endregion

        private void Initialize()
        {
            // Funds
            var fundRep = new FundRepository();
            this.AddFundItem = new AddFundItemCommand(this);

            FundsList = new ObservableCollection<Fund> (fundRep.GetAllFundsQuery().ToList());
            p_FundsList.CollectionChanged += OnFundsListChanged;
            base.RaisePropertyChangedEvent("FundsList");

            // Securities
            var secRep = new SecurityRepository();
            this.AddSecurityItem = new AddSecurityItemCommand(this);

            SecList = new ObservableCollection<Security>(secRep.GetAllSecuritiesQuery().ToList());
            p_SecList.CollectionChanged += OnSecListChanged;
            base.RaisePropertyChangedEvent("SecList");
        }
    }
}
