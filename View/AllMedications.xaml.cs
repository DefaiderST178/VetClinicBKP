using VetClinicBKP.Model;
using VetClinicBKP.ViewModel;

namespace VetClinicBKP.View;

public partial class AllMedications : ContentPage
{
	public AllMedications()
	{
		InitializeComponent();
        MedicationViewModel medicationViewModel = new MedicationViewModel();
        BindingContext = medicationViewModel;
    }

	// выбо препарата
    private void medicationList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedMedication = e.SelectedItem as Medication;

        Navigation.PushAsync(new SelectedMedication(selectedMedication));

        medicationList.SelectedItem = null;
    }
}