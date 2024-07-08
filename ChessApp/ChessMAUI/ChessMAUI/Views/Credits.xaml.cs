namespace ChessMAUI.Views;

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