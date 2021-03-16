using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class PersonLib : Person
    {
        string sqlText = "";

        // Function to encrypt password
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        // Method delete person
        public void DeletePerson(int idUser)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=NSS_PC19;Initial Catalog=userDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = null;
                    sqlText = "DELETE FROM Utente WHERE Id=" + idUser;
                    SqlCommand command = new SqlCommand(sqlText, connection);
                    reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.Write("Attention, unknown person!");
                }
            }
        }
        // Method modify person
        public void ModifyPerson(int idUser, status status_)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=NSS_PC19;Initial Catalog=userDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = null;
                    sqlText = "UPDATE Utente SET Stato='" + status_ + "' WHERE Id=" + idUser;
                    SqlCommand command = new SqlCommand(sqlText, connection);
                    reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.Write("Attention, unknown person!");
                }
            }
        }
        // Method insert person
        public void InsertPerson(status status_)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=NSS_PC19;Initial Catalog=userDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = null;
                    MD5 md5 = new MD5CryptoServiceProvider();

                    Console.Write("\nplease enter your first name? ");
                    firstName = Console.ReadLine();
                    Console.Write("\nplease enter your last name? ");
                    lastName = Console.ReadLine();
                    Console.Write("\nplease enter your email? ");
                    email = Console.ReadLine();
                    Console.Write("\nplease enter your password? ");
                    password = MD5Hash(Console.ReadLine());
                    //Console.Write(password);
                    Console.Write("\nplease enter your telefono? ");
                    telefono = Console.ReadLine();
                    switch (status_)
                    {
                        case status.attivo:
                            break;
                        case status.non_attivo:
                            break;
                        case status.cancellato:
                            break;
                        default:
                            break;
                    }
                    //Console.Write(DateTime.Now);
                    //lastLogin = DateTime.Now;
                    sqlText = string.Format("insert into Utente (Nome, Cognome, Email, Password, Telefono, Stato) " +
                        "values ('{0}', '{1}', '{2}', '{3}', {4}, '{5}')", firstName, lastName, email, password, telefono, status.attivo);
                    SqlCommand command = new SqlCommand(sqlText, connection);
                    reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                   Console.WriteLine(ex.Message);
                }
                
            }
        }
            // Method print person
        public void PrintPerson()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=NSS_PC19;Initial Catalog=userDB;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlDataReader reader = null;
                    sqlText = "SELECT * FROM Utente";
                    SqlCommand command = new SqlCommand(sqlText, connection);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(string.Format("Show info user:\nID: {0}   NOME: {1}   COGNOME: {2}   EMAIL: {3}   PASSWORD: {4}   TELEFONO: {5}   STATO: {6}   LAST_LOGIN: {7}\n"
                                               , reader["Id"].ToString(), reader["Nome"].ToString(), reader["Cognome"].ToString(), reader["Email"].ToString(), reader["Password"].ToString()
                                               , reader["Telefono"].ToString(), reader["Stato"].ToString(), reader["LastLogin"].ToString()));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
