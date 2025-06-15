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

    // ������ ��� �������� � ��������� ���������
    private async void OnGoToSubheader_Clicked(object sender, EventArgs e)
    {
        if (subheaderPicker.SelectedIndex != -1)
        {
            switch (subheaderPicker.SelectedItem.ToString())
            {
                case "�����":
                    scrollView.ScrollToAsync(subheader1, ScrollToPosition.Start, true);
                    break;
                case "��� �����":
                    scrollView.ScrollToAsync(subheader2, ScrollToPosition.Start, true);
                    break;
                case "�������":
                    scrollView.ScrollToAsync(subheader3, ScrollToPosition.Start, true);
                    break;
            }
        }
    }

    // ����� ����� �� ������ 
    private void feedsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedTovar = e.SelectedItem as Tovar;

        Navigation.PushAsync(new SelectedTovar(selectedTovar));

        feedsList.SelectedItem = null;
    }

    // ����� �������� ����� �� ������ 
    private void careList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedTovar = e.SelectedItem as Tovar;

        Navigation.PushAsync(new SelectedTovar(selectedTovar));

        careList.SelectedItem = null;
    }

    // ����� ������� �� ������ 
    private void toysList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedTovar = e.SelectedItem as Tovar;

        Navigation.PushAsync(new SelectedTovar(selectedTovar));

        toysList.SelectedItem = null;
    }
}