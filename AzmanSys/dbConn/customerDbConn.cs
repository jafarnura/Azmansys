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
        public void insertCustomer(string CusFName, string CusLName, string CusTelNum, string EMAIL, string DOB, string NATION)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tbl_Customer` (`cust_ID`, `cust_fName`, `cust_lName`, `cust_Dob`, `cust_Tel`, `cust_Email`, `cust_Nationality`) VALUES (NULL,@CusFName, @CusLName, @CusTelNum, @Email, @Dob, @Nation);";
            comm.Parameters.AddWithValue("@CusFName", CusFName);
            comm.Parameters.AddWithValue("@CusLName", CusLName);
            comm.Parameters.AddWithValue("@CusTelNum", CusTelNum);
            comm.Parameters.AddWithValue("@Email", EMAIL);
            comm.Parameters.AddWithValue("@Dob", DOB);
            comm.Parameters.AddWithValue("@Nation", NATION);
            comm.ExecuteNonQuery();
            connClose();
        }


        public void updateCustomer(string CusID,string DOB, string FName, string LName, string Tel, string Email, string Nation)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tbl_Customer` SET `CusFname`=@FName,`CusLName`=@LName,`CusDOB`=@DOB`CusTelNum`=@Tel,cust_Email'@=Email,`cust_Nationality`@=Nationality WHERE CusID = @CusID";
            comm.Parameters.AddWithValue("@FName", FName);
            comm.Parameters.AddWithValue("@LName", LName);
            comm.Parameters.AddWithValue("DOB", DOB);
            comm.Parameters.AddWithValue("@TEL", Tel);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("Nation", Nation);
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
