using VetClinicBKP.Model;
using VetClinicBKP.ViewModel;

namespace VetClinicBKP.View;

public partial class AllSpecialists : ContentPage
{
	public AllSpecialists()
	{
		InitializeComponent();
        SpecialistViewModel specialistViewModel = new SpecialistViewModel();
        BindingContext = specialistViewModel;
    }

    // выбор специалиста
    private void specialistsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedSpecialist = e.SelectedItem as Specialist;

        Navigation.PushAsync(new SelectedSpecialist(selectedSpecialist));

        specialistsList.SelectedItem = null;
    }
}