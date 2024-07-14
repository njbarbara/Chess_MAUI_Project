namespace ChessMAUI.Views;

public partial class PlayerSelection : ContentPage
{
	public PlayerSelection()
	{
		InitializeComponent();
	}

	public void Button_GameSelection(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("//Game");
    }
    private void Home_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Home");
    }
}