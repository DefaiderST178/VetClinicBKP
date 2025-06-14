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

    // переход к типу препарата
    private void OnGoToSubheader_Clicked(object sender, EventArgs e)
    {
        if (subheaderPicker.SelectedIndex != -1)
        {
            switch (subheaderPicker.SelectedItem.ToString())
            {
                case "“аблетки":
                    scrollView.ScrollToAsync(subheader1, ScrollToPosition.Start, true);
                    break;
                case " апли":
                    scrollView.ScrollToAsync(subheader2, ScrollToPosition.Start, true);
                    break;
                case "–астворы":
                    scrollView.ScrollToAsync(subheader3, ScrollToPosition.Start, true);
                    break;
                case "ƒругое":
                    scrollView.ScrollToAsync(subheader4, ScrollToPosition.Start, true);
                    break;
            }
        }
    }

    // выбор таблетки из списка 
    private void pillsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedMedication = e.SelectedItem as Medication;

        Navigation.PushAsync(new SelectedMedication(selectedMedication));

        pillsList.SelectedItem = null;
    }

    // выбор капель из списка 
    private void dropsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedMedication = e.SelectedItem as Medication;

        Navigation.PushAsync(new SelectedMedication(selectedMedication));

        dropsList.SelectedItem = null;
    }

    // выбор раствора из списка 
    private void solutionsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedMedication = e.SelectedItem as Medication;

        Navigation.PushAsync(new SelectedMedication(selectedMedication));

        solutionsList.SelectedItem = null;
    }

    // выбор других из списка 
    private void otherList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedMedication = e.SelectedItem as Medication;

        Navigation.PushAsync(new SelectedMedication(selectedMedication));

        otherList.SelectedItem = null;
    }
}