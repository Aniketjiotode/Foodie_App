using CommanLayer;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Net;

namespace RepositoryLayer.Service
{
    public class AddressRL:IAddressRL
    {
        private readonly IConfiguration configuration;
        SqlConnection connection;
        public AddressRL(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


        public bool Insertaddress(AddressModel address)
        {
            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("sp_InsertAddress", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Fullname", address.Fullname);
                command.Parameters.AddWithValue("@MobileNo", address.MobileNo);
                command.Parameters.AddWithValue("@pinCode", address.pinCode);
                command.Parameters.AddWithValue("@Address", address.Address);
                command.Parameters.AddWithValue("@City", address.City);
                command.Parameters.AddWithValue("@State", address.State);
                command.Parameters.AddWithValue("@UserId", address.UserId);

                connection.Open();
                int i = command.ExecuteNonQuery();
                connection.Close();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public List<AddressModel> GetAlladdress()
        {
            List<AddressModel> addresses = new List<AddressModel>();

            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("sp_GetAllAddresses", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    AddressModel address = new AddressModel();
                    address.AddressId = (int)reader["AddressId"];
                    address.Fullname = (string)reader["Fullname"];
                    address.MobileNo = (long)reader["MobileNo"];
                    address.pinCode = (int)reader["PinCode"];
                    address.Address = (string)reader["Address"];
                    address.City = (string)reader["City"];
                    address.State = (string)reader["State"];
                    address.UserId = (int)reader["UserId"];
                    addresses.Add(address);
                }
                return addresses;
            }
        }


        public bool UpdateAddress(AddressModel address)
        {
            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                    SqlCommand command = new SqlCommand("UpdateAddress_sp", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AddressId", address.AddressId);
                    command.Parameters.AddWithValue("@Fullname", address.Fullname);
                    command.Parameters.AddWithValue("@MobileNo", address.MobileNo);
                    command.Parameters.AddWithValue("@PinCode", address.pinCode);
                    command.Parameters.AddWithValue("@Address", address.Address);
                    command.Parameters.AddWithValue("@City", address.City);
                    command.Parameters.AddWithValue("@State", address.State);
       
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                connection.Close();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Deleteaddress(int addressId)
        {
            using (connection = new SqlConnection(configuration.GetConnectionString("FoodDB")))
            {
                SqlCommand command = new SqlCommand("sp_DeleteAddress", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AddressId", addressId);
                connection.Open();
                int i = command.ExecuteNonQuery();
                connection.Close();
                if (i >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

