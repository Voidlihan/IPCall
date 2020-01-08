using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace IPTelephonia
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

        private void Call(object sender, RoutedEventArgs e)
        {
            UdpClient udpClient = new UdpClient(int.Parse(textBoxPort.Text));
            udpClient.JoinMulticastGroup(IPAddress.Parse(textBoxIP.Text));
            udpClient.Close();
            UdpClient senderUdp = new UdpClient(3231);
            var buf = new byte[4076];
            var bytes = System.Text.Encoding.UTF8.GetString(buf);
            Console.Beep(buf.Length, 5000);
            senderUdp.Close();
        }
    }
}