using System;
using System.Collections.Generic;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace OOServer {
    public static class DbLinker
    {
        public static string constructorString = "server=106.14.44.67;"
            + "User Id=root;"
            + "password=0000;"
            + "Database=OOServer";
        public static MySqlConnection myConnect;
        public static void Init()
        {
            try
            {
                myConnect = new MySqlConnection(constructorString);
                myConnect.Open();
                Program.ShowMsg("MySql connected!");
            } catch (Exception ex)
            {
                Program.ShowMsg("Error: " + ex.Message);
             }
        }

        public static int AddUser(string UName, string UPwd, int UType)
        {
            MySqlCommand sql = new MySqlCommand(@"INSERT INTO Users(UName, UPwd, UType) VALUES(" + UName + ", " + UPwd + ", " + UType + ");");
            sql.ExecuteNonQuery();
            return (int)sql.LastInsertedId;
        }

        public static bool DeleteUser(int UID)
        {
            MySqlCommand sql = new MySqlCommand(@"SELECT * FROM Users WHERE UID = " + UID + @";");
            if (sql.ExecuteReader().HasRows)
            {
                sql = new MySqlCommand(@"DELETE FROM Users WHERE UID = " + UID + @";");
                sql.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool MakeFrined(int Subject, int Object)
        {
            MySqlCommand sql = new MySqlCommand(@"INSERT INTO Friendship(Subject, Object) VALUES(" + Subject + ", " + Object + ");");
            return false;
        }

        public static int AddGroup(string GName)
        {
            MySqlCommand sql = new MySqlCommand(@"INSERT INTO Groups(GName) VALUES(" + GName + ");");
            return 0;
        }

        public static bool UserCreateGroup(int UID, int GName)
        {

            return false;
        }

        public static bool UserJoinGroup(int UID, int GID)
        {
            return false;
        }

        public static bool UserExitGroup(int UID, int GID)
        {
            return false;
        }
    }
}
