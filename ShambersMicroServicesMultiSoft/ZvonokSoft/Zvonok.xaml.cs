using ShambersMicroServicesMultiSoft.ZvonokSoft.ZvonokServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ShambersMicroServicesMultiSoft.ZvonokSoft
{
    /// <summary>
    /// Логика взаимодействия для Zvonok.xaml
    /// </summary>
    public partial class Zvonok : Window
    {
        Status status = new Status();
        SoundFunctions soundsFunc = new SoundFunctions();
        TimeDefault timeDefault = new TimeDefault();
        private void TimeUpStatus()
        {
            TimeStart1.Text = timeDefault.timeList[1].ToString(@"h\:mm");
            TimeStart2.Text = timeDefault.timeList[2].ToString(@"h\:mm");
            TimeStart3.Text = timeDefault.timeList[3].ToString(@"h\:mm");
            TimeStart4.Text = timeDefault.timeList[4].ToString(@"h\:mm");
            TimeStart5.Text = timeDefault.timeList[5].ToString(@"h\:mm");
            TimeStart6.Text = timeDefault.timeList[6].ToString(@"h\:mm");
            TimeStart7.Text = timeDefault.timeList[7].ToString(@"h\:mm");
            TimeStart8.Text = timeDefault.timeList[8].ToString(@"h\:mm");
            TimeStart9.Text = timeDefault.timeList[9].ToString(@"h\:mm");
            TimeEnd1.Text = timeDefault.timeList[10].ToString(@"h\:mm");
            TimeEnd2.Text = timeDefault.timeList[11].ToString(@"h\:mm");
            TimeEnd3.Text = timeDefault.timeList[12].ToString(@"h\:mm");
            TimeEnd4.Text = timeDefault.timeList[13].ToString(@"h\:mm");
            TimeEnd5.Text = timeDefault.timeList[14].ToString(@"h\:mm");
            TimeEnd6.Text = timeDefault.timeList[15].ToString(@"h\:mm");
            TimeEnd7.Text = timeDefault.timeList[16].ToString(@"h\:mm");
            TimeEnd8.Text = timeDefault.timeList[17].ToString(@"h\:mm");
            TimeEnd9.Text = timeDefault.timeList[18].ToString(@"h\:mm");
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
            timeDefault.TimerDefalut();
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
            if(MessageBox.Show("Вы уверены, что хотите сделать время по умолчанию?", "Внимание!",
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
