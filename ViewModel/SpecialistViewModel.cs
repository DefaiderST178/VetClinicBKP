using VetClinicBKP.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace VetClinicBKP.ViewModel
{
    public class SpecialistViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Specialist> _specialists;
        public ObservableCollection<Specialist> Specialists
        {
            get { return _specialists; }
            set { _specialists = value; OnPropertyChanged(); }
        }

        private Medication _selectedSpecialist;
        public Medication SelectedSpecialist
        {
            get { return _selectedSpecialist; }
            set { _selectedSpecialist = value; OnPropertyChanged(); }
        }

        public SpecialistViewModel()
        {
            // Получение данных из BreedRepo
            SpecialistRepo specialistRepo = new SpecialistRepo();
            List<Specialist> allSpecialist = specialistRepo.GetAllSpecialists();
            Specialists = new ObservableCollection<Specialist>(allSpecialist);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
