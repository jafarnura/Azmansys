﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzmanSys
{
    class BookingsDbConn : dbConn
    {
        public void insertBooking(string CusID, string FlightID, string Booking_DateTime, string Total_BookingCost)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblbooking` (`CusID`, `FlightID`, `Booking_DateTime`, `Total_BookingCost`) VALUES (@CusID, @FlightID, @Booking_DateTime, @Total_BookingCost);";
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.Parameters.AddWithValue("@Booking_DateTime", Booking_DateTime);
            comm.Parameters.AddWithValue("@Total_BookingCost", Total_BookingCost);
            comm.ExecuteNonQuery();
            connClose();
        }

        public void updateBooking(String BookinID, string CusID, string FlightID, string Booking_DateTime, string Total_BookingCost)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblbooking` SET `CusID`=@CusID,`FlightID`=@FlightID,`Booking_DateTime`=@Booking_DateTime,`Total_BookingCost`=@Total_BookingCost WHERE BookinID=@BookinID";
            comm.Parameters.AddWithValue("@CusID", CusID );
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.Parameters.AddWithValue("@Booking_DateTime", Booking_DateTime);
            comm.Parameters.AddWithValue("@Total_BookingCost", Total_BookingCost);
            comm.Parameters.AddWithValue("@BookinID", BookinID);
            comm.ExecuteNonQuery();
            connClose();
        }
        public void deleteBooking(string BookinID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblbooking` WHERE `BookinID` = @BookinID";
            comm.Parameters.AddWithValue("@BookinID", BookinID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
