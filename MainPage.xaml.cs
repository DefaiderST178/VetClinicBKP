namespace VetClinicBKP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenMapBtn_Clicked(object sender, EventArgs e)
        {
            var addressLabel = this.FindByName<Label>("AddressLabel");
            string address = addressLabel?.Text ?? "";
            if (!string.IsNullOrWhiteSpace(address))
            {
                string mapUrl = $"https://www.google.com/maps/search/?api=1&query={Uri.EscapeDataString(address)}";
                try
                {
                    await Launcher.OpenAsync(mapUrl);
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Ошибка", $"Не удалось открыть карту: {ex.Message}", "ОК");
                }
            }
            else
            {
                await DisplayAlert("Ошибка", "Адрес не найден.", "ОК");
            }
        }
    }
}
