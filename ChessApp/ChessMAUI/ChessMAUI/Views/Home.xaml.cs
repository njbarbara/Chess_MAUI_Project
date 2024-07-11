using Plugin.Maui.Audio;
using ChessMAUI.Audio;
using System;
using Microsoft.Maui.Controls;
using CommunityToolkit.Maui;

namespace ChessMAUI.Views
{
    public partial class Home : ContentPage
    {
        private readonly ChessMAUI.Audio.IAudio audio;

        public Home(IAudioManager audioManager)
        {
            InitializeComponent();
            this.audio = new AudioSound(audioManager);
            audio.Music("EineKleine.mp3");
        }

        private async void Launch_Button(object sender, EventArgs e)
        {
            await AnimateLogo();
            await audio.PlayButtonSound("move-self.mp3");
            await Shell.Current.GoToAsync("//Preselection");
        }

        private async void Credit_Button(object sender, EventArgs e)
        {
            await AnimateLogo();
            await audio.PlayButtonSound("move-self.mp3");
            await Shell.Current.GoToAsync("//Credits");
        }

        private async void ScoreBoard_Button(object sender, EventArgs e)
        {
            await AnimateLogo();
            await audio.PlayButtonSound("move-self.mp3");
            await Shell.Current.GoToAsync("//ScoreBoard");
        }

        private async void Settings_Button(object sender, EventArgs e)
        {
            await AnimateLogo();
            await audio.PlayButtonSound("move-self.mp3");
            await Shell.Current.GoToAsync("//Setting");
        }

        private async Task AnimateLogo()
        {
            await LogoImage.ScaleTo(1.5, 100);
            await LogoImage.ScaleTo(1, 100);
            await LogoImage.ScaleTo(1.5, 10);
            LogoImage.Scale = 1;  
        }
    }
}
