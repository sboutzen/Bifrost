using Bifrost.DL;
using Bifrost.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Navigation;

namespace Bifrost.UI.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        private IConfigurationService _configurationService;

        private BaseConfiguration _selectedConfiguration;
        public BaseConfiguration SelectedConfiguration
        {
            get { return _selectedConfiguration; }
            set 
            { 
                _selectedConfiguration = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<BaseConfiguration> Configurations { get; set; }

        // MainViewModel constructor
        public MainViewModel(IConfigurationService configurationService)
        {
            Configurations = new ObservableCollection<BaseConfiguration>();
            _configurationService = configurationService;
        }

        public void Load()
        {
            IEnumerable<BaseConfiguration> configurations = _configurationService.GetAll();
            Configurations.Clear();
            foreach (BaseConfiguration configuration in configurations)
            {
                Configurations.Add(configuration);
            }
        }
    }
}
