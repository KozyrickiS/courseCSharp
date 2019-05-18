using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoDatabase
{
    class MotoSQLRepository : IMotoRepository
    {
        public Motorcycle GetMotorcycleByID(int id)
        {
            Motorcycle motorcycle = new Motorcycle();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select Name, Model, Year, Odometer from Motorcycle where Id = @Id";
            command.Connection = Connection.Connect;
            command.Parameters.Add(new SqlParameter("Id", id));
            using (SqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    motorcycle.Id = id;
                    motorcycle.Name = dataReader.GetString(0);
                    motorcycle.Model = dataReader.GetString(1);
                    motorcycle.Year = dataReader.GetDateTime(2);
                    motorcycle.Odometer = dataReader.GetInt32(3);
                }
            }
            return motorcycle;
        }

        public Motorcycle GetMotorcycle(Motorcycle moto)
        {
            Motorcycle motorcycle = new Motorcycle();
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select Name, Model, Year, Odometer from Motorcycle where Id = @Id";
            command.Connection = Connection.Connect;
            command.Parameters.Add(new SqlParameter("Id", moto.Id));
            using (SqlDataReader dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    motorcycle.Id = moto.Id;
                    motorcycle.Name = dataReader.GetString(0);
                    motorcycle.Model = dataReader.GetString(1);
                    motorcycle.Year = dataReader.GetDateTime(2);
                    motorcycle.Odometer = dataReader.GetInt32(3);
                }
            }
            return motorcycle;
        }

        public void CreateMotorcycle(Motorcycle moto)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"Insert into Motorcycle(Id, Name, Model, Year, Odometer) values (@paramId, @paramName, @paramModel, @paramYear, @paramOdometer)";
            command.Parameters.AddWithValue("@paramId", moto.Id);
            command.Parameters.AddWithValue("@paramName", moto.Name);
            command.Parameters.AddWithValue("@paramModel", moto.Model);
            command.Parameters.AddWithValue("@paramYear", moto.Year);
            command.Parameters.AddWithValue("@paramOdometer", moto.Odometer);
            command.Connection = Connection.Connect;
            command.ExecuteNonQuery();
        }

        public void DeleteMotorcycle(Motorcycle moto)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete from Motorcycle where Id = @Id";
            command.Parameters.Add(new SqlParameter("Id", moto.Id));
            command.Connection = Connection.Connect;
            command.ExecuteNonQuery();
        }

        public void UpdateMotorcycle(Motorcycle moto)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"Update Motorcycle set Name = @paramName, Model = @paramModel, Year = @paramYear, Odometer = @paramOdometer where Id = @Id";
            command.Parameters.Add(new SqlParameter("Id", moto.Id));
            command.Parameters.AddWithValue("@paramName", moto.Name);
            command.Parameters.AddWithValue("@paramModel", moto.Model);
            command.Parameters.AddWithValue("@paramYear", moto.Year);
            command.Parameters.AddWithValue("@paramOdometer", moto.Odometer);
            command.Connection = Connection.Connect;
            command.ExecuteNonQuery();
        }
    }
}
