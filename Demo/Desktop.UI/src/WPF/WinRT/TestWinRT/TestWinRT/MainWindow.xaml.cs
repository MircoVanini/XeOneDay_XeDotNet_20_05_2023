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
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace TestWinRT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonShowToast_Click(object sender, RoutedEventArgs e)
        {
            string title = "The current time is";
            string timeString = $"{DateTime.Now:HH:mm:ss}";
            string mircoImage = "https://www.xedotnet.org/media/1035/vanini_foto.jpg?height=200";

            string toastXmlString =
            $@"<toast><visual>
                    <binding template='ToastGeneric'>
                    <text>{title}</text>
                    <text>{timeString}</text>
                    <image src='{mircoImage}'/>
                    </binding>
                </visual></toast>";

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(toastXmlString);

            var toastNotification = new ToastNotification(xmlDoc);

            var toastNotifier = ToastNotificationManager.CreateToastNotifier();
            toastNotifier.Show(toastNotification);
        }
    }
}
