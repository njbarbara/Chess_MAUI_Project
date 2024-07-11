namespace ChessMAUI.Views;
using Plugin.Maui.Audio;
using ChessMAUI.Audio;
public partial class Credits : ContentPage
{

    public Credits()
	{
		InitializeComponent();
	}

    private void Home_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Home");
    }
}
