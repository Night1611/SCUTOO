using System;
using System.Text;
using System.Windows;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace OOClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 这里面的Socket操作是最底层的，只实现了简单的收和发
    /// </summary>
    public partial class Login : Window
    {
        bool showMessage = true;
        Socket client;

        public Login()
        {
            InitializeComponent();
            InitSocket();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            Sender(textAccount.Text + " " + textPassword.Text);
        }



        bool InitSocket()
        {
            IPAddress serverIP = IPAddress.Parse("127.0.0.1");
            int port = 1248;
            IPEndPoint serverPoint = new IPEndPoint(serverIP, port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(serverPoint);
                Thread receiverThread = new Thread(Receiver);
                receiverThread.IsBackground = true;
                receiverThread.Start();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        void Receiver()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int n = client.Receive(buffer);
                    string s = Encoding.UTF8.GetString(buffer, 0, n);
                    ShowMsg(s);
                }catch(Exception ex)
                {
                    ShowMsg("Error: " + ex.Message);
                    break;
                }
            }
        }

        void Sender(string text)
        {
            if (client.Connected)
            {
                try
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(text);
                    client.Send(buffer);
                }catch(Exception ex)
                {
                    ShowMsg("Error: " + ex.Message);
                }
            }
        }

        void ShowMsg(string text)
        {
            if (showMessage)
                Console.WriteLine(text);
        }

        private void ButtonRegist_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
