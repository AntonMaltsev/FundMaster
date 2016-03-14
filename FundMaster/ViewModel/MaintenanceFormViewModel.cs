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
        /// <summary>
        /// Guys, I see with what is need to be expanded here - ViewModel and work with notifications, log4net and fields validation, but it takes more time, so suggest to talk on call about that if necessary 
        /// </summary>
        private Security currentSecurity;
        public Security CurrentSecurity;

        public SecurityRepository CurrentSecurityRep;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
