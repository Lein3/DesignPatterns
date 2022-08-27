using MVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private readonly IUserDialog _UserDialog;
        private readonly IDataService _DataService;

        private string _Title = "Главное окно";

        public string Title { get => _Title; set => Set(ref _Title, value); }

        private string _Status = "Готов!";

        public string Status { get => _Status; set => Set(ref _Status, value); }

        public MainWindowViewModel(IUserDialog UserDialog, IDataService DataService)
        {
            _UserDialog = UserDialog;
            _DataService = DataService;
        }
    }
}
