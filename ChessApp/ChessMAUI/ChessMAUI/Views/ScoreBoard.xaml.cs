namespace ChessMAUI.Views;

public partial class ScoreBoard : ContentPage
{
	public ScoreBoard()
	{
		InitializeComponent();
	}

	private void Home_Clicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("//Home");
    }
}