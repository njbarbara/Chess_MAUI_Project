namespace ChessMAUI.Views;

public partial class PlayerCreation : ContentPage
{
    
        public PlayerCreation()
        {
            InitializeComponent();
        }

        public void StartGame(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Entry_name1.Text) || string.IsNullOrWhiteSpace(Entry_name2.Text))
            {
                DisplayAlert("Erreur", "Veuillez entrer des noms valides pour les deux joueurs.", "OK");
                return;
            }

            var param = new Dictionary<string, object>() { { "name1", Entry_name1.Text }, { "name2", Entry_name2.Text } };

            Shell.Current.GoToAsync($"//Game", param);

        }

        public void Home_Clicked(object _, EventArgs __)
        {
            Shell.Current.GoToAsync("//Home");
        }

        public void OnEntryCompleted1(object sender, EventArgs e)
        {
            string name1 = ((Entry)sender).Text;
        }

        public void OnEntryCompleted2(object sender, EventArgs e)
        {
            string name2 = ((Entry)sender).Text;
        }
    
}