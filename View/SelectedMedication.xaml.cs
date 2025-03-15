namespace VetClinicBKP.View;

public partial class SelectedMedication : ContentPage
{
	public SelectedMedication(Model.Medication selectedMedication)
	{
		InitializeComponent();
        BindingContext = selectedMedication;
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Переход на предыдущую страницу
    }

    private async void ShareBtn_Clicked(object sender, EventArgs e)
    {
        string textToShare = $"Препарат: {TovarTB.Text}\nОписание: {DescriptionTB.Text}";
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
}