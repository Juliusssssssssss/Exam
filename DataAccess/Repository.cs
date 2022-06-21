using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccess
{

    public class Repository
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Eksamen;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Repository()
        {
            SqlConnection connection = new(connectionString);
            connection.Open();
            connection.Close();
        }
        public List<Bookings> GetAllBookings()
        {
            List<Bookings> Bookings = new();
            SqlConnection connection = new(connectionString);
            connection.Open();
            string sql = "SELECT * FROM Bookings";
            SqlCommand command = new(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DateTime start = (DateTime)reader[0];
                DateTime end = (DateTime)reader[1];
                int id = (int)reader[2];
                Bookings BKS = new()
                {
                    Start = start,
                    End = end,
                    pitchid = 0//?
                };
                
            }
            connection.Close();
            return Bookings;
        }

        public void AddNewBooking(Bookings bookingtoadd)
        {
            SqlConnection connection = new(connectionString);
            connection.Open();

            string sql = $"INSERT INTO Bookings (Start, End) VALUES('{bookingtoadd.Start}', '{bookingtoadd.End}')";
            SqlCommand command = new(sql, connection);

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
