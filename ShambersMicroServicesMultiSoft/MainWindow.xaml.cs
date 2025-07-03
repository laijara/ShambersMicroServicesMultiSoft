using System.Windows;

namespace ShambersMicroServicesMultiSoft
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnZvonki_Click(object sender, RoutedEventArgs e)
        {
            ShambersMicroServicesMultiSoft.ZvonokSoft.Zvonok zvonokSoft = new ShambersMicroServicesMultiSoft.ZvonokSoft.Zvonok();
            zvonokSoft.Show();
        }
    }
}