using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VetClinicBKP.Model;

namespace VetClinicBKP.ViewModel
{
    public class MedicationViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Medication> _medications;
        public ObservableCollection<Medication> Medications
        {
            get { return _medications; }
            set { _medications = value; OnPropertyChanged(); }
        }

        private Medication _selectedMedication;
        public Medication SelectedMedication
        {
            get { return _selectedMedication; }
            set { _selectedMedication = value; OnPropertyChanged(); }
        }

        public MedicationViewModel()
        {
            // Получение данных из BreedRepo
            MedicationRepo medicationRepo = new MedicationRepo();
            List<Medication> allMedication = medicationRepo.GetAllMedications();
            Medications = new ObservableCollection<Medication>(allMedication);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
