using ShambersMicroServicesMultiSoft.ZvonokSoft.ZvonokServices;
using System.Windows;

namespace ShambersMicroServicesMultiSoft.ZvonokSoft
{
    public partial class Zvonok : Window
    {
        private Status status = new Status();
        private SoundFunctions soundsFunc = new SoundFunctions();
        private TimeDefault timeDefault = new TimeDefault();
        private TimeDefaultChecker timeDefaultChecker = new TimeDefaultChecker();

        private void TimeUpStatus()
        {
            TimeStart1.Text = timeDefault.timeListStart[1].ToString(@"h\:mm");
            TimeStart2.Text = timeDefault.timeListStart[2].ToString(@"h\:mm");
            TimeStart3.Text = timeDefault.timeListStart[3].ToString(@"h\:mm");
            TimeStart4.Text = timeDefault.timeListStart[4].ToString(@"h\:mm");
            TimeStart5.Text = timeDefault.timeListStart[5].ToString(@"h\:mm");
            TimeStart6.Text = timeDefault.timeListStart[6].ToString(@"h\:mm");
            TimeStart7.Text = timeDefault.timeListStart[7].ToString(@"h\:mm");
            TimeStart8.Text = timeDefault.timeListStart[8].ToString(@"h\:mm");
            TimeStart9.Text = timeDefault.timeListStart[9].ToString(@"h\:mm");
            TimeEnd1.Text = timeDefault.timeListEnd[1].ToString(@"h\:mm");
            TimeEnd2.Text = timeDefault.timeListEnd[2].ToString(@"h\:mm");
            TimeEnd3.Text = timeDefault.timeListEnd[3].ToString(@"h\:mm");
            TimeEnd4.Text = timeDefault.timeListEnd[4].ToString(@"h\:mm");
            TimeEnd5.Text = timeDefault.timeListEnd[5].ToString(@"h\:mm");
            TimeEnd6.Text = timeDefault.timeListEnd[6].ToString(@"h\:mm");
            TimeEnd7.Text = timeDefault.timeListEnd[7].ToString(@"h\:mm");
            TimeEnd8.Text = timeDefault.timeListEnd[8].ToString(@"h\:mm");
            TimeEnd9.Text = timeDefault.timeListEnd[9].ToString(@"h\:mm");
        }

        private void UpStatus()
        {
            status.CheckStatus();
            TextOption.Text = status.statusText;
            soundsFunc.PlayStop();
        }

        public Zvonok()
        {
            InitializeComponent();
            UpStatus();
            TimeUpStatus();
        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {
            status.statusWork = "off";
            UpStatus();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            status.statusWork = "on";
            UpStatus();
            timeDefaultChecker.TimerDefalut();
            timeDefaultChecker.TimerStop();
        }

        private void BtnAttention_Click(object sender, RoutedEventArgs e)
        {
            status.statusWork = "attention";
            UpStatus();
            if (status.statusWork == "attention")
            {
                soundsFunc.PlayAttention();
            }
        }

        private void BtnSaveTime_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка пока не рабоатет");
        }

        private void BtnTimeDefault_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сделать время по умолчанию?", "Внимание!",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                TimeUpStatus();
            }
        }

        private void BtnSound_Click(object sender, RoutedEventArgs e)
        {
            status.statusWork = "test";
            UpStatus();
            soundsFunc.PlayZvonok();
        }

        private void BtnStopSoundAll_Click(object sender, RoutedEventArgs e)
        {
            status.statusWork = "test";
            UpStatus();
            soundsFunc.PlayStop();
        }

        private void BtnAttentionSound_Click(object sender, RoutedEventArgs e)
        {
            status.statusWork = "test";
            UpStatus();
            soundsFunc.PlayAttention();
        }
    }
}