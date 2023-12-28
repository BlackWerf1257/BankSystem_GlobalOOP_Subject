using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    public class Register
    {
        public Register(string nameValue, string idValue, string pwValue, string ageValue, string hpValue)
        {
            var strConnect = "Server=localhost;Database=dbtest;Uid=root;Pwd=0000;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConnect))
                {
                    conn.Open();
                    var insertData = string.Format("INSERT INTO user_db (ID, PW, Name, Age, Phone) " +"VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');", 
                        idValue, pwValue, nameValue, ageValue, hpValue);
                    

                    MySqlCommand cmd = new MySqlCommand(insertData, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("유저 계정이 생성되었습니다");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
