using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;

namespace Banking_System
{
    public class Login
    {
        //IP to connect, Database Name, ID, Password
        MySqlConnection connection;
        //MySQL에 명령어 전송용
        MySqlCommand sqlCommand;
        MySqlDataReader mySqlDataReader;

        Wiring_Form wiringForm;


        public Login(string serverName, string dbName, string id, string pw)
        {

            try
            {
                connection = new MySqlConnection("Server=" + serverName + ";Database=" + dbName + ";Uid=" + id + ";Pwd=" + pw);
                //Connection Open
                connection.Open();

                //Checks if the connection succeed
                /*if (connection.Ping())
                    MessageBox.Show("Connection Succeed");*/
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }


        public void UserLogin(string id, string pw)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Called");

                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();


                //Checks ID and Password from Database and if Succees, return true
                var selectQuery = "SELECT * FROM user_db WHERE id = \'" + id + "\' ";

                sqlCommand = new MySqlCommand(selectQuery, connection);
                //ExecuteReader를 통해 입력값을 받고, 해당정보를 mySQLDataReader에 저장
                mySqlDataReader = sqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    //Gets ID and PW from ID Textbox and PW TextBox of Main Form
                    if (id == (string)mySqlDataReader["id"] && pw == (string)mySqlDataReader["pw"])
                    {
                        wiringForm = new Wiring_Form(id);
                        wiringForm.Show();
                        continue;
                    }
                    else
                        MessageBox.Show("Invalid ID or PW");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
