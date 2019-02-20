using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AzmanSys
{
    class customerDbConn: dbConn
    {
        public void insertCustomer(string CusFName, string CusLName, string CusTelNum, string EMAIL, string DOB, string NATIONALITY)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbl_Customer` (`cust_ID`, `cust_fName`, `cust_lName`, `cust_DOB`, `cust_Tel`, `cust_Nationality`, `cust_Email`) VALUES" +
                " (NULL,@CusFName, @CusLName,  @DOB, @CusTelNum, @Nationality, @Email);";
            comm.Parameters.AddWithValue("@CusFName", CusFName);
            comm.Parameters.AddWithValue("@CusLName", CusLName);
            comm.Parameters.AddWithValue("@CusTelNum", CusTelNum);
            comm.Parameters.AddWithValue("@Email", EMAIL);
            comm.Parameters.AddWithValue("@DOB", DOB);
            comm.Parameters.AddWithValue("@Nationality", NATIONALITY);
            comm.ExecuteNonQuery();
            connClose();
        }


        public void updateCustomer(string CusID,string DOB, string FName, string LName, string Tel, string Email, string Nationality)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbl_Customer` SET `CusFname`=@FName,`CusLName`=@LName,`CusDOB`=@DOB`CusTelNum`=@Tel,cust_Email'@=Email,`cust_Nationality`@=Nationality WHERE CusID = @CusID";
            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("DOB", DOB);
            comm.Parameters.AddWithValue("@TEL", Tel);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("Nationality", Nationality);
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.ExecuteNonQuery();
            connClose();



        }

        public void deleteCustomer(string CusID)

        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tbl_Customer` WHERE CusID = @CusID";
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
