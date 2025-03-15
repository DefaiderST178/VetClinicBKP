namespace VetClinicBKP.View;

public partial class SelectedTovar : ContentPage
{
	public SelectedTovar(Model.Tovar selectedTovar)
	{
		InitializeComponent();
        BindingContext = selectedTovar;
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // ������� �� ���������� ��������
    }

    private async void ShareBtn_Clicked(object sender, EventArgs e)
    {
        string textToShare = $"�����: {TovarTB.Text}\n��������: {DescriptionTB.Text}";
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
}