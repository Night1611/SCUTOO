using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Data.OleDb;

namespace OOServer
{
    class Program
    {
        static Socket listener;
        static Thread acceptThread;
        public static List<User> onlineUsers = new List<User>();
        static Queue<string> buffer = new Queue<string>();
        static bool showMessage = true; //Console will show the dialog if it's true.

        static void Main(string[] args)
        {
            DbLinker.Init();
            InitListner();
            Console.ReadLine();
        }

        static bool InitListner()
        {
            IPAddress localIP = IPAddress.Parse("0.0.0.0");
            int port = 1248;
            IPEndPoint listnerPoint = new IPEndPoint(localIP, port);
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listener.Bind(listnerPoint);
                listener.Listen(10);
                ShowMsg("Server is listening.");
                acceptThread = new Thread(Accept);
                acceptThread.IsBackground = true;
                acceptThread.Start();
                return true;
            }catch(Exception ex)
            {
                ShowMsg("Error: " + ex.Message);
                return false;
            }
        }

        static void Accept()
        {
            while (true)
            {
                try
                {
                    Socket receiver = listener.Accept();
                    string point = receiver.RemoteEndPoint.ToString();
                    ShowMsg(point + " connected.");
                    onlineUsers.Add(new User(0, "", "", 0, receiver));
                }
                catch (Exception ex)
                {
                    ShowMsg("Error: " + ex.Message);
                    break;
                }
            }
        }

        public static void ShowMsg(string msg)
        {
            if (showMessage)
                Console.WriteLine(msg);
        }
    }
}
