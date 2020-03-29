using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ContactManager7798430
{
    class dbConn
    {
        private string connString = "server=db212it.chcygaxzwjzx.us-east-1.rds.amazonaws.com; UserID=admin; Password=db212it123;Database = ContactManagerDB";
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////            Personal Contact Start                       //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public DataTable GetAllPersonal() 
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                DataTable personalContactDt = new DataTable();
                List<PersonalContact> personalContacts = new List<PersonalContact>();
                using (var mysqlcmd = new MySqlCommand("CALL selectAllPersonal();", conn))
                using (var reader = mysqlcmd.ExecuteReader())
                    while (reader.Read())
                    {
                        personalContacts.Add(new PersonalContact
                        {
                            ContactID = reader.GetInt32(0),
                            contactFname = reader.GetString(1),
                            ContactLname = reader.GetString(2),
                            contactEmail = reader.GetString(3),
                            PersonalTel = reader.GetString(4),
                            contactAddr1 = reader.GetString(5),
                            contactAddr2 = reader.GetString(6),
                            contactAddr3 = reader.GetString(7),
                            contactPostcode = reader.GetString(8),
                            contactCity = reader.GetString(9),
                        });
                    }
                personalContactDt.Columns.Add("ContactID");
                personalContactDt.Columns.Add("contactFname");
                personalContactDt.Columns.Add("ContactLname");
                personalContactDt.Columns.Add("contactEmail");
                personalContactDt.Columns.Add("PersonalTel");
                personalContactDt.Columns.Add("contactAddr1");
                personalContactDt.Columns.Add("contactAddr2");
                personalContactDt.Columns.Add("contactAddr3");
                personalContactDt.Columns.Add("contactPostcode");
                personalContactDt.Columns.Add("contactCity");

                foreach (var item in personalContacts)
                {
                    var row = personalContactDt.NewRow();
                    row["ContactID"] = item.ContactID;
                    row["contactFname"] = item.contactFname;
                    row["ContactLname"] = item.ContactLname;
                    row["contactEmail"] = item.contactEmail;
                    row["PersonalTel"] = item.PersonalTel;
                    row["contactAddr1"] = item.contactAddr1;
                    row["contactAddr2"] = item.contactAddr2;
                    row["contactAddr3"] = item.contactAddr3;
                    row["contactPostcode"] = item.contactPostcode;
                    row["contactCity"] = item.contactCity;

                    personalContactDt.Rows.Add(row);
                }
                return personalContactDt;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////


        public async void InsertPersonal(PersonalContact personalContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var mysqlcmd = new MySqlCommand())
                {
                    mysqlcmd.Connection = conn;
                    mysqlcmd.CommandText = "CALL insertPersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    mysqlcmd.Parameters.AddWithValue("p1", personalContact.contactFname);
                    mysqlcmd.Parameters.AddWithValue("p2", personalContact.ContactLname);
                    mysqlcmd.Parameters.AddWithValue("p3", personalContact.contactEmail);
                    mysqlcmd.Parameters.AddWithValue("p4", personalContact.PersonalTel);
                    mysqlcmd.Parameters.AddWithValue("p5", personalContact.contactAddr1);
                    mysqlcmd.Parameters.AddWithValue("p6", personalContact.contactAddr2);
                    mysqlcmd.Parameters.AddWithValue("p7", personalContact.contactAddr3);
                    mysqlcmd.Parameters.AddWithValue("p8", personalContact.contactPostcode);
                    mysqlcmd.Parameters.AddWithValue("p9", personalContact.contactCity);
                    await mysqlcmd.ExecuteNonQueryAsync();

                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        public async void UpdatetPersonal(PersonalContact personalContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var mysqlcmd = new MySqlCommand())
                {
                    mysqlcmd.Connection = conn;
                    mysqlcmd.CommandText = "CALL updatePersonal (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    mysqlcmd.Parameters.AddWithValue("p1", personalContact.ContactID);
                    mysqlcmd.Parameters.AddWithValue("p2", personalContact.contactFname);
                    mysqlcmd.Parameters.AddWithValue("p3", personalContact.ContactLname);
                    mysqlcmd.Parameters.AddWithValue("p4", personalContact.contactEmail);
                    mysqlcmd.Parameters.AddWithValue("p5", personalContact.PersonalTel);
                    mysqlcmd.Parameters.AddWithValue("p6", personalContact.contactAddr1);
                    mysqlcmd.Parameters.AddWithValue("p7", personalContact.contactAddr2);
                    mysqlcmd.Parameters.AddWithValue("p8", personalContact.contactAddr3);
                    mysqlcmd.Parameters.AddWithValue("p9", personalContact.contactPostcode);
                    mysqlcmd.Parameters.AddWithValue("p10", personalContact.contactCity);
                    await mysqlcmd.ExecuteNonQueryAsync();

                }
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////

        public async void DeletePersonal(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var mysqlcmd = new MySqlCommand())
                {
                    mysqlcmd.Connection = conn;
                    mysqlcmd.CommandText = "CALL deletePersonal (@p1);";
                    mysqlcmd.Parameters.AddWithValue("p1", id);

                    await mysqlcmd.ExecuteNonQueryAsync();

                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////  End personal Contact   ////////////////////////////////////////////////////////////////////


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////      Business Contact         ////////////////////////////////////////////////////////////////////
        
        public DataTable GetAllbusiness()
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                DataTable businessContactdt = new DataTable();
                List<BusinessContact> businessContacts = new List<BusinessContact>();
                using (var mysqlcmd = new MySqlCommand("CALL selectAllBusiness();", conn))
                using (var reader = mysqlcmd.ExecuteReader())
                    while (reader.Read())
                    {
                        businessContacts.Add(new BusinessContact
                        {
                            ContactID = reader.GetInt32(0),
                            contactFname = reader.GetString(1),
                            ContactLname = reader.GetString(2),
                            contactEmail = reader.GetString(3),
                            BusinessTel = reader.GetString(4),
                            contactAddr1 = reader.GetString(5),
                            contactAddr2 = reader.GetString(6),
                            contactAddr3 = reader.GetString(7),
                            contactPostcode = reader.GetString(8),
                            contactCity = reader.GetString(9),
                        });
                    }
                businessContactdt.Columns.Add("ContactID");
                businessContactdt.Columns.Add("contactFname");
                businessContactdt.Columns.Add("ContactLname");
                businessContactdt.Columns.Add("contactEmail");
                businessContactdt.Columns.Add("BusinessTel");
                businessContactdt.Columns.Add("contactAddr1");
                businessContactdt.Columns.Add("contactAddr2");
                businessContactdt.Columns.Add("contactAddr3");
                businessContactdt.Columns.Add("contactPostcode");
                businessContactdt.Columns.Add("contactCity");

                foreach (var item in businessContacts)
                {
                    var row = businessContactdt.NewRow();
                    row["ContactID"] = item.ContactID;
                    row["contactFname"] = item.contactFname;
                    row["ContactLname"] = item.ContactLname;
                    row["contactEmail"] = item.contactEmail;
                    row["BusinessTel"] = item.BusinessTel;
                    row["contactAddr1"] = item.contactAddr1;
                    row["contactAddr2"] = item.contactAddr2;
                    row["contactAddr3"] = item.contactAddr3;
                    row["contactPostcode"] = item.contactPostcode;
                    row["contactCity"] = item.contactCity;

                    businessContactdt.Rows.Add(row);
                }
                return businessContactdt;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public async void InsertBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var mysqlcmd = new MySqlCommand())
                {
                    mysqlcmd.Connection = conn;
                    mysqlcmd.CommandText = "CALL insertBusiness (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9);";
                    mysqlcmd.Parameters.AddWithValue("p1", businessContact.contactFname);
                    mysqlcmd.Parameters.AddWithValue("p2", businessContact.ContactLname);
                    mysqlcmd.Parameters.AddWithValue("p3", businessContact.contactEmail);
                    mysqlcmd.Parameters.AddWithValue("p4", businessContact.BusinessTel);
                    mysqlcmd.Parameters.AddWithValue("p5", businessContact.contactAddr1);
                    mysqlcmd.Parameters.AddWithValue("p6", businessContact.contactAddr2);
                    mysqlcmd.Parameters.AddWithValue("p7", businessContact.contactAddr3);
                    mysqlcmd.Parameters.AddWithValue("p8", businessContact.contactPostcode);
                    mysqlcmd.Parameters.AddWithValue("p9", businessContact.contactCity);
                    await mysqlcmd.ExecuteNonQueryAsync();

                }
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        public async void UpdatetBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(connString))
            {
                await conn.OpenAsync();
                using (var mysqlcmd = new MySqlCommand())
                {
                    mysqlcmd.Connection = conn;
                    mysqlcmd.CommandText = "CALL updateBusiness (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10);";
                    mysqlcmd.Parameters.AddWithValue("p1", businessContact.ContactID);
                    mysqlcmd.Parameters.AddWithValue("p2", businessContact.contactFname);
                    mysqlcmd.Parameters.AddWithValue("p3", businessContact.ContactLname);
                    mysqlcmd.Parameters.AddWithValue("p4", businessContact.contactEmail);
                    mysqlcmd.Parameters.AddWithValue("p5", businessContact.BusinessTel);
                    mysqlcmd.Parameters.AddWithValue("p6", businessContact.contactAddr1);
                    mysqlcmd.Parameters.AddWithValue("p7", businessContact.contactAddr2);
                    mysqlcmd.Parameters.AddWithValue("p8", businessContact.contactAddr3);
                    mysqlcmd.Parameters.AddWithValue("p9", businessContact.contactPostcode);
                    mysqlcmd.Parameters.AddWithValue("p10", businessContact.contactCity);
                    await mysqlcmd.ExecuteNonQueryAsync();

                }
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////

        public async void DeleteBusiness(int id)
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var mysqlcmd = new MySqlCommand())
                {
                    mysqlcmd.Connection = conn;
                    mysqlcmd.CommandText = "CALL deleteBusiness (@p1);";
                    mysqlcmd.Parameters.AddWithValue("p1", id);

                    await mysqlcmd.ExecuteNonQueryAsync();

                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////    End Business        //////////////////////////////////////////////////////////

    }//Class dbConn end
}
