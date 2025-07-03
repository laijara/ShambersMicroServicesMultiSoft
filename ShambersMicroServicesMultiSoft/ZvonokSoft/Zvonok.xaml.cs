using ShambersMicroServicesMultiSoft.ZvonokSoft.ZvonokServices;
using System.Windows;

namespace ShambersMicroServicesMultiSoft.ZvonokSoft
{
    /// <summary>
    /// Логика взаимодействия для Zvonok.xaml
    /// </summary>
    public partial class Zvonok : Window
    {
        private Status status = new Status();
        private SoundFunctions soundsFunc = new SoundFunctions();
        private TimeDefault timeDefault = new TimeDefault();
        private TimeDefaultChecker timeDefaultChecker = new TimeDefaultChecker();

        private void TimeUpStatus()
        {
            TimeInt0.Text = timeDefault.timeList[0].ToString(@"h\:mm");
            TimeInt1.Text = timeDefault.timeList[1].ToString(@"h\:mm");
            TimeInt2.Text = timeDefault.timeList[2].ToString(@"h\:mm");
            TimeInt3.Text = timeDefault.timeList[3].ToString(@"h\:mm");
            TimeInt4.Text = timeDefault.timeList[4].ToString(@"h\:mm");
            TimeInt5.Text = timeDefault.timeList[5].ToString(@"h\:mm");
            TimeInt6.Text = timeDefault.timeList[6].ToString(@"h\:mm");
            TimeInt7.Text = timeDefault.timeList[7].ToString(@"h\:mm");
            TimeInt8.Text = timeDefault.timeList[8].ToString(@"h\:mm");
            TimeInt9.Text = timeDefault.timeList[9].ToString(@"h\:mm");
            TimeInt10.Text = timeDefault.timeList[10].ToString(@"h\:mm");
            TimeInt11.Text = timeDefault.timeList[11].ToString(@"h\:mm");
            TimeInt12.Text = timeDefault.timeList[12].ToString(@"h\:mm");
            TimeInt13.Text = timeDefault.timeList[13].ToString(@"h\:mm");
            TimeInt14.Text = timeDefault.timeList[14].ToString(@"h\:mm");
            TimeInt15.Text = timeDefault.timeList[15].ToString(@"h\:mm");
            TimeInt16.Text = timeDefault.timeList[16].ToString(@"h\:mm");
            TimeInt17.Text = timeDefault.timeList[17].ToString(@"h\:mm");
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