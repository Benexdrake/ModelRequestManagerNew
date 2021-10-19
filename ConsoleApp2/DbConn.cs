using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class DbConn
    {


        public void MainDb(int auswahl, List<Person> person, List<Inventar> inventar)
        {
            string sql = "";
            switch (auswahl)
            {
                case 0:
                    {
                        sql = "select * from users";
                        break;
                    }
                    

                case 1:
                    {
                        sql = "select * from requests";
                        break;
                    }
            }
            //(@"Data Source = " + ip + "; port = " + port + " ; Initial Catalog = " + dataBase + "; User Id = " + username + "; password = " + sqlPassword + "")
        //string cs = "server = localhost; user id = root; password = dragoomstorrm1983; database = mrmdb";
            string cs = @"Data Source = localhost; port = 3306; Initial Catalog = MRMDB; UserId = root; password = dragoonstorm1983;";
        MySqlConnection con = new MySqlConnection(cs);
        con.Open();
        MySqlCommand cmd = new MySqlCommand(sql, con);
        MySqlDataReader rdr = cmd.ExecuteReader();
            
            
            while(rdr.Read())
                {
                switch (auswahl)
                {
                    case 0:
                        {
                            person.Add(new Person
                            {
                                username = rdr.GetString(1),
                                vorname = rdr.GetString(2)
                            }) ;
                            break;
                        }
                    case 1:
                        {
                            inventar.Add(new Inventar
                            {
                                inventar1 = rdr.GetString(1),
                                inventar2 = rdr.GetString(2)
                            });
                            break;
                        }
                }

            }
            
            Console.ReadKey();
        }

}
}
