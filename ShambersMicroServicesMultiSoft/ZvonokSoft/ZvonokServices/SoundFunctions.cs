using System;
using System.Media;
using System.Windows;

namespace ShambersMicroServicesMultiSoft.ZvonokSoft.ZvonokServices
{
    internal class SoundFunctions
    {
        private SoundPaths paths = new SoundPaths();

        private void SoundPlayStart(string SoundPath)
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer(SoundPath);
                soundPlayer.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SoundPlayStop()
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void SoundPlayRepeat(string soundPaths)
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer(soundPaths);
                soundPlayer.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void PlayZvonok()
        {
            SoundPlayStart(paths.soundPaths[1]);
        }

        public void PlayStop()
        {
            SoundPlayStop();
        }

        public void PlayAttention()
        {
            SoundPlayRepeat(paths.soundPaths[2]);
        }

        public void TestAttention()
        {
            SoundPlayStart(paths.soundPaths[2]);
        }
    }
}