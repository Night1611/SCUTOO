using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using IMClassLibrary;

namespace OOServer
{
    class User
    {
        public int BUFFER_SIZE = 1024 * 1024;
        public int UID;
        public string UName;
        public string UPwd;
        public int UType;
        public delegate void OnMessageArrive(string text);
        public event OnMessageArrive onMessageArrive;
        public Socket conversationSocket;

        public User(int UID, string UName, string UPwd, int UType, Socket conversationSocket)
        {
            this.UID = UID;
            this.UName = UName;
            this.UPwd = UPwd;
            this.UType = UType;
            this.conversationSocket = conversationSocket;
            Thread receiveThread = new Thread(Receive);
            receiveThread.IsBackground = true;
            receiveThread.Start();
        }

        ~User()
        {
            conversationSocket.Close();
        }

        public void Receive()
        {
            try
            {
                byte[] buffer = new byte[BUFFER_SIZE];
                int n = conversationSocket.Receive(buffer);
                /*
                 检验收到的是不是登录或注册数据包，如果不是，直接退出
                 解析登录或注册数据包
                 修改自身的ID等信息
                 如果是注册数据包，那么则调用DbLinker添加进数据库并取得返回值（是否成功）
                 如果失败直接退出
                 */
                LoginDataPackage loginData = DataPackage.Parse(buffer) as LoginDataPackage;
                if(loginData == null) throw new Exception("非法数据包");
                if (DbLinker.HasUser(loginData.UserID)) //有则登录
                {
                    if (loginData.Password != DbLinker.GetUPwd(loginData.UserID))
                        throw new Exception("密码错误");
                }
                else //没有则添加好友
                {
                    DbLinker.AddUser(loginData.UserID, loginData.Password, 0);
                }
                while (true)
                {
                    buffer = new byte[BUFFER_SIZE];
                    n = conversationSocket.Receive(buffer);
                    string words = Encoding.UTF8.GetString(buffer, 0, n);
                    Program.ShowMsg(words);
                    onMessageArrive?.Invoke(words); //C#事件触发订阅器执行处理
                }
            }catch(Exception ex)
            {
                Program.ShowMsg("Error: " + ex.Message);
                Send("Error: " + ex.Message);
                Program.onlineUsers.Remove(this);
            }
        }

        public bool Send(string text)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(text);
                conversationSocket.Send(buffer);
                return true;
            }
            catch (Exception ex)
            {
                Program.ShowMsg("Error: " + ex.Message);
                Program.onlineUsers.Remove(this);
                return false;
            }
        }

        public bool Send(DataPackage data)
        {
            try
            {
                byte[] buffer = data.DataPackageToBytes();
                conversationSocket.Send(buffer);
                return true;
            }catch(Exception ex)
            {
                Program.ShowMsg(UID + " Error: " + ex);
                Program.onlineUsers.Remove(this);
                return false;
            }
        }
    }
}
