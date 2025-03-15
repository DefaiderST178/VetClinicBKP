namespace VetClinicBKP.View;

public partial class SelectedSpecialist : ContentPage
{
	public SelectedSpecialist(Model.Specialist selectedSpecialist)
	{
		InitializeComponent();
        BindingContext = selectedSpecialist;
    }

    private async void ShareBtn_Clicked(object sender, EventArgs e)
    {

    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Переход на предыдущую страницу
    }
}