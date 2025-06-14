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

    // ������� � ���� ���������
    private void OnGoToSubheader_Clicked(object sender, EventArgs e)
    {
        if (subheaderPicker.SelectedIndex != -1)
        {
            switch (subheaderPicker.SelectedItem.ToString())
            {
                case "��������":
                    scrollView.ScrollToAsync(subheader1, ScrollToPosition.Start, true);
                    break;
                case "�����":
                    scrollView.ScrollToAsync(subheader2, ScrollToPosition.Start, true);
                    break;
                case "��������":
                    scrollView.ScrollToAsync(subheader3, ScrollToPosition.Start, true);
                    break;
                case "������":
                    scrollView.ScrollToAsync(subheader4, ScrollToPosition.Start, true);
                    break;
            }
        }
    }

    // ����� �������� �� ������ 
    private void pillsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedMedication = e.SelectedItem as Medication;

        Navigation.PushAsync(new SelectedMedication(selectedMedication));

        pillsList.SelectedItem = null;
    }

    // ����� ������ �� ������ 
    private void dropsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedMedication = e.SelectedItem as Medication;

        Navigation.PushAsync(new SelectedMedication(selectedMedication));

        dropsList.SelectedItem = null;
    }

    // ����� �������� �� ������ 
    private void solutionsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedMedication = e.SelectedItem as Medication;

        Navigation.PushAsync(new SelectedMedication(selectedMedication));

        solutionsList.SelectedItem = null;
    }

    // ����� ������ �� ������ 
    private void otherList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedMedication = e.SelectedItem as Medication;

        Navigation.PushAsync(new SelectedMedication(selectedMedication));

        otherList.SelectedItem = null;
    }
}