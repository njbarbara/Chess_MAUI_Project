namespace ChessMAUI.Views;

public partial class Preselection : ContentPage
{
	public Preselection()
	{
		InitializeComponent();
	}
	private void Button_PlayerCreation(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("//PlayerCreation");
    }

    private void Button_PlayerSelection(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//PlayerSelection");
    }

    private void Home_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Home");
    }
}