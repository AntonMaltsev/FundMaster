using System;
using System.Windows.Input;
using FundMaster.Entity;
using FundMaster.EntityDAL;

namespace FundMaster.ViewModel.Commands
{
    public class AddSecurityItemCommand : ICommand
    {
        #region Fields

        // Member variables
        private readonly MainWindowViewModel m_ViewModel;

        #endregion

        #region Constructor

        public AddSecurityItemCommand(MainWindowViewModel viewModel)
        {
            m_ViewModel = viewModel;
        }

        #endregion

        #region ICommand Members

        /// <summary>
        /// Whether this command can be executed.
        /// </summary>
        public bool CanExecute(object parameter)
        {
            return true; //!string.IsNullOrEmpty(m_ViewModel.FundName);
        }

        /// <summary>
        /// Fires when the CanExecute status of this command changes.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Invokes this command to perform its intended task.
        /// </summary>
        public void Execute(object parameter)
        {
            var secRep = new SecurityRepository();

            var newSec = new Security
            {
                Name = m_ViewModel.SecName,
                Price = Convert.ToDecimal(m_ViewModel.SecPrice),
                Qty = m_ViewModel.SecQty,
                SecurityTypeId = secRep.GetSecurityTypeByName(m_ViewModel.SecType).Id,
                IsDeleted = (m_ViewModel.isDeletedSec == 1) ? true : false
            };

            secRep.AddAndSave(newSec);            // Update Model
            m_ViewModel.SecList.Add(newSec);     // Rise View Update         
        }

        #endregion
    }
}
