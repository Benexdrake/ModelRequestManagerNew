using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelRequestManagerNew
{
    class SqlDB
    {
        public string ip { get; set; }
        public string sqlPassword { get; set; }
        public string port { get; set; }
        public string dataBase { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public bool admin { get; set; }
        public bool loginOk { get; set; }
        public int likeId { get; set; }
        public int likeUserId { get; set; }

        MySqlConnection con;
        MySqlDataReader myreader;
        MySqlCommand cmd;
        

        public SqlDB()
        {

        }
        public void connectSql(string sql)
        {
            // Verbindet mit Mysql, mit der mitgegebenen sql und der Auswahl, damit myreader liest oder nicht.
            try
            {
                con = new MySqlConnection(@"Data Source = " + Save.sqlIp + "; port = " + Save.sqlPort + " ; Initial Catalog = " + Save.sqlDataBase + "; User Id = " + Save.sqlUsername + "; password = " + Save.sqlPassword + "");
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void loginDB(string sql)
        {
            // Dies wird von der LoginForm benutzt, um sich in die Datenbank das erstemal einzuloggen, sendet dann einen bool ob es geklappt hat
            // so wie einen bool um zu gucken, ist man Admin oder nicht.
            try
            {
                connectSql(sql);
                myreader = cmd.ExecuteReader();
                if (myreader.HasRows)
                {
                    loginOk = true;
                    while (myreader.Read())
                    {
                        Save.LoginUserID = myreader.GetInt16(0);
                       if(myreader.GetBoolean(10) == true)
                       {
                            admin = true;
                       }
                    }
                }
            }
            catch (Exception)
            {
                //throw;
            }
            con.Close();
        }
        
        public void loadRequests(string sql)
        {
            // Loggt sich in MySql ein und liest alle Requests, schreibt diese dann in eine Liste
            try
            {
                connectSql(sql);
                myreader = cmd.ExecuteReader();
                if (myreader.HasRows)
                {
                    while (myreader.Read())
                    {
                        Request.requestList.Add(new Request
                        {
                            requestId = myreader.GetInt16(0),
                            requestUserId = myreader.GetInt16(1),
                            note = myreader.GetString(2),
                            text = myreader.GetString(3),
                            category = myreader.GetInt16(4),
                            fileName = myreader.GetString(5),
                            whiteBox = myreader.GetBoolean(6),
                            lowPoly = myreader.GetBoolean(7),
                            highPoly = myreader.GetBoolean(8),
                            texture = myreader.GetBoolean(9),
                            requestDate = myreader.GetString(10),
                            username = myreader.GetString(13),
                            guid = myreader.GetString(14),
                            available = myreader.GetBoolean(15)
                        }); ;
                    }
                    Request.allRequestIds = Request.requestList.Count;
                    Console.WriteLine(Request.requestList.Count);
                    Console.WriteLine("List Test");
                }
            }
            catch (Exception)
            {
                throw;
            }
            con.Close();
        }

        public void LoadUsers(string sql)
        {
            try
            {
                connectSql(sql);
                myreader = cmd.ExecuteReader();
                if (myreader.HasRows)
                {
                    while (myreader.Read())
                    {
                        Users.userList.Add(new Users
                        {
                            userID = myreader.GetInt16(0),
                            userGUID = myreader.GetString(1),
                            username = myreader.GetString(2),
                            firstName = myreader.GetString(4),
                            lastName = myreader.GetString(5),
                            userBirthDate = myreader.GetString(6),
                            registerDate = myreader.GetString(7),
                            userEmail = myreader.GetString(8),
                            userTele = myreader.GetString(9),
                            admin = myreader.GetBoolean(10),
                            available = myreader.GetBoolean(11)
                        }); ;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            con.Close();
        }

       

        public void createUpdate(string sql)
        {
            // Alle Create, Insert, Update, Delete werden hier benutzt
            try
            {
                connectSql(sql);
            }
            catch (Exception)
            {
                throw;
            }
            con.Close();
        }

     

        public void loadLike(string sql)
        {
            // Loggt sich in MySql ein und liest alle Requests, schreibt diese dann in eine Liste
            try
            {
                connectSql(sql);
                myreader = cmd.ExecuteReader();
                if (myreader.HasRows)
                {
                    while (myreader.Read())
                    {
                        likeId = myreader.GetInt16(0);
                        likeUserId = myreader.GetInt16(1);
                        Console.WriteLine(likeId.ToString());
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            con.Close();
        }





    }
}
