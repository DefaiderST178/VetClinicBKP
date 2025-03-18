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
        string textToShare = $"����������: {SpecTB.Text}\n��������: {DescriptionTB.Text}";
        try
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = textToShare,
                Title = "���������� �������"
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("������", $"�� ������� ���������� �������: {ex.Message}", "OK");
        }
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // ������� �� ���������� ��������
    }
}