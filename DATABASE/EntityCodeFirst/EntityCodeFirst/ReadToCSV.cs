using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst
{
    public class ReadToCSV : Object
    {
        /* public string sqlText = "";


         public String currentDirectory
         {
             get;
             set;
         }

         public String fileName
         {
             get;
             set;
         }

         public String filePath
         {
             get;
             set;
         }

         // Method print person
         public void AddRecord()
         {
             // Create the folder csv
             string folderName = @"C:\Users\kemgang\Desktop\Basis_C#\DATABASE";
             string pathString = System.IO.Path.Combine(folderName, "File");

             System.IO.Directory.CreateDirectory(pathString);
             string file;
             file = string.Format("Utenti_{0:yyyy-MM-dd_hh-mm-ss}.csv", DateTime.Now);
             this.fileName = file;
             this.filePath = @"C:\Users\kemgang\Desktop\Basis_C#\DATABASE\File\" + this.fileName;
             List<Person> persons = new List<Person>();

             try
             {
                 using (System.IO.StreamReader reader = new StreamReader(this.filePath))
                 {
                     CsvConfiguration config = new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)
                     {
                         Delimiter = ";"
                     };
                     using (var dataCsv = new CsvReader(reader, config))
                     {
                         //fileCsv.WriteHeader<Person>();
                         dataCsv.NextRecord();
                         dataCsv.GetRecords(persons);
                     }
                 }

                 using (SqlConnection connection = new SqlConnection(@"Data Source=NSS_PC19;Initial Catalog=userDB;Integrated Security=True"))
                 {

                     connection.Open();
                     SqlDataReader reader = null;
                     sqlText = "SELECT * FROM Utente";
                     SqlCommand command = new SqlCommand(sqlText, connection);
                     reader = command.ExecuteReader();



                     while (reader.Read())
                     {
                         Person person = new Person();
                         person.id = int.Parse(reader["Id"].ToString());
                         person.lastName = reader["Nome"].ToString();
                         person.firstName = reader["Cognome"].ToString();
                         person.email = reader["Email"].ToString();
                         person.password = reader["password"].ToString();
                         person.telefono = reader["Telefono"].ToString();
                         person.stato = reader["Stato"].ToString();
                         if (!(reader["LastLogin"] is DBNull))
                             person.lastLogin = DateTime.Parse(reader["LastLogin"].ToString());

                         persons.Add(person);
                     }

                     reader.Close();
                 }

             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }
         }*/
    }
}
