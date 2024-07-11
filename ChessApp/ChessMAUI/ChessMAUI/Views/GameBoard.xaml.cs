namespace ChessMAUI.Views;

public partial class GameBoard : ContentPage
{
	public GameBoard()
	{
        InitializeComponent();
    }

    private void Home_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Home");
    }
}