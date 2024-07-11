using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.Maui.Audio;

namespace ChessMAUI.Audio
{
    public interface IAudio
    {
        Task Music(string name);//pk j'ai mis en task alors que sa return rien, zebi je fais confiance à l'auto complétion
        void SetVolumeMusic(float volume);
        void SetVolume(float volume);
        Task PlayButtonSound(string sound);
    }

    public class AudioSound : IAudio
    {
        private readonly IAudioManager audioManager;
        private IAudioPlayer? playerSound;
        private static IAudioPlayer? playerMusic;

        public AudioSound(IAudioManager audioManager)
        {
            this.audioManager = audioManager;
        }

        public void SetVolumeMusic(float volume)
        {
            if (playerMusic != null)
            {
                playerMusic.Volume = volume;
            }
        }

        public void SetVolume(float volume)
        {
            if (playerSound != null)
            {
                playerSound.Volume = volume;
            }
        }

        public async Task Music(string name)
        {
            if (playerMusic == null)
            {
                playerMusic = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(name));
                playerMusic.Loop = true;
            }

            if (!playerMusic.IsPlaying)
            {
                playerMusic.Play();
            }
        }

        public async Task PlayButtonSound(string sound)
        {
            playerSound = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync(sound));
            playerSound.Play();
        }
    }
}
