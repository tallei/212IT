using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrisContactManagerCSharp
{
    public class DbConn // assigned public access modifier to allow access to other classes

    {
       //string connection for establishing the database and other required parameters for the connection and set access to private
        private string connString = "Server=db212it.cljolvmbl073.us-east-1.rds.amazonaws.com;User ID=admin;Password=BAita124.;Database=HarrisContactDb";


        public DataTable GetAllPersonal() // help to populate datagrid view to display all personal contact records
        {
            using (var conn = new MySqlConnection(connString))  //create variable, allowing to use mysql connection
            {
                conn.Open(); // open connection
                DataTable personalContactDt = new DataTable();  //data table creation
                List<PersonalContact> personalContacts = new List<PersonalContact>(); // list of personal contact 
                using (var cmd = new MySqlCommand("CALL selectAllPersonal();", conn)) // cmd is an optional variable name 
                using (var reader = cmd.ExecuteReader()) // read personal data
                    while (reader.Read())
                    {

                        personalContacts.Add(new PersonalContact // Add all personal attributes 
                        {
                            ContactID = reader.GetInt32(0), // Numbering commence from 0-8
                            ContactFname = reader.GetString(1),
                            ContactLname = reader.GetString(2),
                            ContactEmail = reader.GetString(3),
                            ContactAddr1 = reader.GetString(4),
                            ContactAddr2 = reader.GetString(5),
                            ContactCity = reader.GetString(6),
                            ContactPostcode = reader.GetString(7),
                            PersonalTel = reader.GetString(8),

                        });






                    } // add listed above procedures to data table and enable appearing in page
                personalContactDt.Columns.Add("ContactID"); //  data column has same name with database 
                personalContactDt.Columns.Add("ContactFname");
                personalContactDt.Columns.Add("ContactLname");
                personalContactDt.Columns.Add("ContactEmail");
                personalContactDt.Columns.Add("ContactAddr1");
                personalContactDt.Columns.Add("ContactAddr2");
                personalContactDt.Columns.Add("ContactCity");
                personalContactDt.Columns.Add("ContactPostcode");
                personalContactDt.Columns.Add("PersonalTel");

                foreach (var item in personalContacts)
                { // place data from list into data table
                    var row = personalContactDt.NewRow();
                    row["ContactID"] = item.ContactID; // name in bracket tells which column to place the data
                    row["ContactFname"] = item.ContactFname;
                    row["ContactLname"] = item.ContactLname;
                    row["ContactEmail"] = item.ContactEmail;
                    row["ContactAddr1"] = item.ContactAddr1;
                    row["ContactAddr2"] = item.ContactAddr2;
                    row["ContactCity"] = item.ContactCity;
                    row["ContactPostcode"] = item.ContactPostcode;
                    row["PersonalTel"] = item.PersonalTel;

                    personalContactDt.Rows.Add(row); // allow adding the data 
                }
                return personalContactDt; //returning type of the data table in line 18
            }

        }

        public async void InsertPersonal(PersonalContact personalContact) // Inolve asynchronise method  
        {
            using (var conn = new MySqlConnection(connString))  // INSERT PERSONAL TAKES PERSONAL CONTACT AS A PERIMETER And enable connection
            {

               await  conn.OpenAsync(); // openness connection to asyn 
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertPersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8);"; // call stored procedure in heidi 
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactFname);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactLname);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p8", personalContact.PersonalTel);
                   await  cmd.ExecuteNonQueryAsync(); // await command shows parameters are passed and query will be awaited to complete




                }
            }
        }

        public async  void UpdatePersonal(PersonalContact personalContact) // added async method for multi threading
       
            // duplicate of insert personal but changed codes to update version. 
        { 
            using (var conn = new MySqlConnection(connString))
            {

               await  conn.OpenAsync(); // openness connection to asyn 
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updatePersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);"; // call stored procedure 
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactFname);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactLname);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p9", personalContact.PersonalTel);
                   await  cmd.ExecuteNonQueryAsync(); // statement accomplished 




                }
            }
        }

        public async void DeletePersonal(int id) // added async method for multi threading in order to offload processing of the software
        {
            using (var conn = new MySqlConnection(connString))
            {

              await   conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deletePersonal(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                   await  cmd.ExecuteNonQueryAsync();  




                }
            }
        }


        public DataTable GetAllBusiness() // help to populate datagrid view to display all business contact records
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                DataTable businessContactDt = new DataTable();
                List<BusinessContact> businessContacts = new List<BusinessContact>();
                using (var cmd = new MySqlCommand("CALL selectAllBusiness();", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {

                        businessContacts.Add(new BusinessContact
                        {
                            ContactID = reader.GetInt32(0),
                            ContactFname = reader.GetString(1),
                            ContactLname = reader.GetString(2),
                            ContactEmail = reader.GetString(3),
                            ContactAddr1 = reader.GetString(4),
                            ContactAddr2 = reader.GetString(5),
                            ContactCity = reader.GetString(6),
                            ContactPostcode = reader.GetString(7),
                            BusinessTel = reader.GetString(8),

                        });






                    }
                businessContactDt.Columns.Add("ContactID");
                businessContactDt.Columns.Add("ContactFname");
                businessContactDt.Columns.Add("ContactLname");
                businessContactDt.Columns.Add("ContactEmail");
                businessContactDt.Columns.Add("ContactAddr1");
                businessContactDt.Columns.Add("ContactAddr2");
                businessContactDt.Columns.Add("ContactCity");
                businessContactDt.Columns.Add("ContactPostcode");
                businessContactDt.Columns.Add("BusinessTel");

                foreach (var item in businessContacts)
                {
                    var row = businessContactDt.NewRow();
                    row["ContactID"] = item.ContactID;
                    row["ContactFname"] = item.ContactFname;
                    row["ContactLname"] = item.ContactLname;
                    row["ContactEmail"] = item.ContactEmail;
                    row["ContactAddr1"] = item.ContactAddr1;
                    row["ContactAddr2"] = item.ContactAddr2;
                    row["ContactCity"] = item.ContactCity;
                    row["ContactPostcode"] = item.ContactPostcode;
                    row["BusinessTel"] = item.BusinessTel;

                    businessContactDt.Rows.Add(row);
                }
                return businessContactDt;
            }

        }

        public async void InsertBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(connString))  // INSERT Business TAKES PERSONAL CONTACT AS A PERIMETER 
            {

               await  conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL insertBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8);";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactFname);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactLname);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p5", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p8", businessContact.BusinessTel);
                   await  cmd.ExecuteNonQueryAsync();




                }
            }
        }
    


        public async void UpdateBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(connString))
            {

               await  conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL updateBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactFname);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactLname);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p5", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactPostcode);
                    cmd.Parameters.AddWithValue("p9", businessContact.BusinessTel);
                    await cmd.ExecuteNonQueryAsync();




                }
            }
        }

        public async void DeleteBusiness(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {

               await  conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL deleteBusiness(@p1);";
                    cmd.Parameters.AddWithValue("p1", id);
                   await  cmd.ExecuteNonQueryAsync();




                }
            }
        }

    }

}

