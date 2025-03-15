using VetClinicBKP.Model;
using VetClinicBKP.ViewModel;

namespace VetClinicBKP.View;

public partial class AllTovars : ContentPage
{
	public AllTovars()
	{
		InitializeComponent();
        TovarViewModel tovarViewModel = new TovarViewModel();
        BindingContext = tovarViewModel;
    }

    private void tovarList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedTovar = e.SelectedItem as Tovar;

        Navigation.PushAsync(new SelectedTovar(selectedTovar));

        tovarList.SelectedItem = null;
    }
}