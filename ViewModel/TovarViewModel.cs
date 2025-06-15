using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VetClinicBKP.Model;

namespace VetClinicBKP.ViewModel
{
    public class TovarViewModel : INotifyPropertyChanged
    {
        // Взаимодейстие с кластером под корма
        private ObservableCollection<Tovar> _feeds;
        public ObservableCollection<Tovar> Feeds
        {
            get { return _feeds; }
            set { _feeds = value; OnPropertyChanged(); }
        }

        private Medication _selectedFeeds;
        public Medication SelectedFeeds
        {
            get { return _selectedFeeds; }
            set { _selectedFeeds = value; OnPropertyChanged(); }
        }

        // Взаимодейстие с кластером под уход
        private ObservableCollection<Tovar> _сare;
        public ObservableCollection<Tovar> Care
        {
            get { return _сare; }
            set { _сare = value; OnPropertyChanged(); }
        }

        private Medication _selectedCare;
        public Medication SelectedCare
        {
            get { return _selectedCare; }
            set { _selectedCare = value; OnPropertyChanged(); }
        }

        // Взаимодейстие с кластером под игрушки
        private ObservableCollection<Tovar> _toys;
        public ObservableCollection<Tovar> Toys
        {
            get { return _toys; }
            set { _toys = value; OnPropertyChanged(); }
        }

        private Medication _selectedToy;
        public Medication SelectedToy
        {
            get { return _selectedToy; }
            set { _selectedToy = value; OnPropertyChanged(); }
        }

        public TovarViewModel()
        {
            TovarRepo tovarRepo = new TovarRepo();
            // Получение данных из репозитория (кластрер 1 - корма)
            List<Tovar> allFeeds = tovarRepo.GetAllFeeds();
            Feeds = new ObservableCollection<Tovar>(allFeeds);

            // Получение данных из репозитория (кластрер 2 - уход)
            List<Tovar> allCares = tovarRepo.GetAllCare();
            Care = new ObservableCollection<Tovar>(allCares);

            // Получение данных из репозитория (кластрер 3 - игрушки)
            List<Tovar> allToys = tovarRepo.GetAllToys();
            Toys = new ObservableCollection<Tovar>(allToys);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
