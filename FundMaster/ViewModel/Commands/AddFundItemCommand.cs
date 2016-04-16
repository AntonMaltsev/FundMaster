using System;
using System.Windows.Input;
using FundMaster.Entity;
using FundMaster.EntityDAL;

namespace FundMaster.ViewModel.Commands
{
    public class AddFundItemCommand : ICommand
    {
        #region Fields

        // Member variables
        private readonly MainWindowViewModel m_ViewModel;

        #endregion

        #region Constructor

        public AddFundItemCommand(MainWindowViewModel viewModel)
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
            //var selectedItem = m_ViewModel.SelectedSecurity;
            // добавить сюда добавление фонда в базу EF
            var fundRep = new FundRepository();

            var newFund = new Fund
            {
                Name = m_ViewModel.FundName,
                IsDeleted = (m_ViewModel.isDeletedFund == 1) ? true : false
            };

            fundRep.AddAndSave(newFund);            // Update Model
            m_ViewModel.FundsList.Add(newFund);     // Rise View Update         
        }

        #endregion
    }
}
