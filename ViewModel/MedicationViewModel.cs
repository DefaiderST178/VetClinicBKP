using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VetClinicBKP.Model;

namespace VetClinicBKP.ViewModel
{
    public class MedicationViewModel : INotifyPropertyChanged
    {
        // Взаимодейстие с кластером под таблетки
        private ObservableCollection<Medication> _pills;
        public ObservableCollection<Medication> Pills
        {
            get { return _pills; }
            set { _pills = value; OnPropertyChanged(); }
        }

        private Medication _selectedPill;
        public Medication SelectedPill
        {
            get { return _selectedPill; }
            set { _selectedPill = value; OnPropertyChanged(); }
        }

        // Взаимодейстие с кластером под капли
        private ObservableCollection<Medication> _drops;
        public ObservableCollection<Medication> Drops
        {
            get { return _drops; }
            set { _drops = value; OnPropertyChanged(); }
        }

        private Medication _selectedDrop;
        public Medication SelectedDrop
        {
            get { return _selectedDrop; }
            set { _selectedDrop = value; OnPropertyChanged(); }
        }

        // Взаимодейстие с кластером под растворы
        private ObservableCollection<Medication> _solutions;
        public ObservableCollection<Medication> Solutions
        {
            get { return _solutions; }
            set { _solutions = value; OnPropertyChanged(); }
        }

        private Medication _selectedSolution;
        public Medication SelectedSolution
        {
            get { return _selectedSolution; }
            set { _selectedSolution = value; OnPropertyChanged(); }
        }

        // Взаимодейстие с кластером под другое
        private ObservableCollection<Medication> _other;
        public ObservableCollection<Medication> Other
        {
            get { return _other; }
            set { _other = value; OnPropertyChanged(); }
        }

        private Medication _selectedOther;
        public Medication SelectedOther
        {
            get { return _selectedOther; }
            set { _selectedOther = value; OnPropertyChanged(); }
        }

        public MedicationViewModel()
        { 
            MedicationRepo medicationRepo = new MedicationRepo();

            // Получение данных из репозитория (кластрер 1 - таблетки)
            List<Medication> allPills = medicationRepo.GetAllPills();
            Pills = new ObservableCollection<Medication>(allPills);

            // Получение данных из репозитория (кластрер 2 - капли)
            List<Medication> allDrops = medicationRepo.GetAllDrops();
            Drops = new ObservableCollection<Medication>(allDrops);

            // Получение данных из репозитория (кластрер 3 - растворы)
            List<Medication> allSolution = medicationRepo.GetAllSolution();
            Solutions = new ObservableCollection<Medication>(allSolution);

            // Получение данных из репозитория (кластрер 4 - другое)
            List<Medication> allOther = medicationRepo.GetAllOther();
            Other = new ObservableCollection<Medication>(allOther);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
