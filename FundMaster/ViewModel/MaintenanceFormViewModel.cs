using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundMaster.Entity;
using FundMaster.EntityDAL;
using System.ComponentModel;

namespace FundMaster.ViewModel
{
    public class MaintenanceFormViewModel : INotifyPropertyChanged
    {
        private Security currentSecurity;
        public Security CurrentSecurity;

        public SecurityRepository CurrentSecurityRep;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
