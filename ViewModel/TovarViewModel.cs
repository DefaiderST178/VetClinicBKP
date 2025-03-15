using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VetClinicBKP.Model;

namespace VetClinicBKP.ViewModel
{
    public class TovarViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Tovar> _tovars;
        public ObservableCollection<Tovar> Tovars
        {
            get { return _tovars; }
            set { _tovars = value; OnPropertyChanged(); }
        }

        private Medication _selectedTovar;
        public Medication SelectedTovar
        {
            get { return _selectedTovar; }
            set { _selectedTovar = value; OnPropertyChanged(); }
        }

        public TovarViewModel()
        {
            // Получение данных из BreedRepo
            TovarRepo tovarRepo = new TovarRepo();
            List<Tovar> allTovars = tovarRepo.GetAllTovars();
            Tovars = new ObservableCollection<Tovar>(allTovars);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
