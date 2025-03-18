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
        string textToShare = $"Специалист: {SpecTB.Text}\nОписание: {DescriptionTB.Text}";
        try
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = textToShare,
                Title = "Поделиться текстом"
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ошибка", $"Не удалось поделиться текстом: {ex.Message}", "OK");
        }
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Переход на предыдущую страницу
    }
}