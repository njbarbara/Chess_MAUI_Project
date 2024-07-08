namespace ChessMAUI.Views;

public partial class Setting : ContentPage
{
	public Setting()
	{
		InitializeComponent();
	}

    private void Home_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//Home");
    }



    public void Dark_Theme_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            App.Current.UserAppTheme = AppTheme.Dark;
        }
        else
        {
            App.Current.UserAppTheme = AppTheme.Light;
        }
    }
}