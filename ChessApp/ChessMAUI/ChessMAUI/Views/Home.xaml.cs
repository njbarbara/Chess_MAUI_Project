namespace ChessMAUI.Views;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void Launch_Button(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Preselection");
    }

    private void Credit_Button(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Credits");
    }

    private void ScoreBoard_Button(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//ScoreBoard");
    }
    private void Settings_Button(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Setting");
    }
}
