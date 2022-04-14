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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client
{
    /// <summary>
    /// Логика взаимодействия для DataPage.xaml
    /// </summary>
    public partial class DataPage : Page, ServiceCPC.IServiceCPCCallback
    {
        bool IsRecordActive = false;
        public DataPage()
        {
            InitializeComponent();
        }

        private void StartStopBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IsRecordActive)
            {
                StopRecording();
            }
            else
            {
                StartRecording();
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                rusmetEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DB.ItemsSource = rusmetEntities1.GetContext().Деталь.ToList();
            }
        }

        private void StartRecording()
        {
            if (!IsRecordActive)
            {
                StartStopBtn.Content = "Остановить запись";
                IsRecordActive = true;
            }
        }

        private void StopRecording()
        {
            if (IsRecordActive)
            {
                StartStopBtn.Content = "Начать запись";
                IsRecordActive=false;
            }
        }

        public void MessageCallBack(string message)
        {
            throw new NotImplementedException();
        }
    }
}
