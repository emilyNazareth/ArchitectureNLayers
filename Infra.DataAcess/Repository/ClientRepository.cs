using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model.Abstractions;
using Domain.Model.Entities;

namespace Infra.DataAcess.Repository
{
    public class ClientRepository : ConnectionSQL, IClientRepository
    {
        public int add(Client client)
        {
            SqlDataReader readRows;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "sp_insert_client";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@name_", client.Name);
            command.Parameters.AddWithValue("@last_name_", client.LastName);
            command.Parameters.AddWithValue("@address_", client.Address);
            command.Parameters.AddWithValue("@city_", client.City);
            command.Parameters.AddWithValue("@email_", client.Email);
            command.Parameters.AddWithValue("@phone_", client.Phone);
            command.Parameters.AddWithValue("@job_", client.Job);                   
            connection.Open();
            readRows = command.ExecuteReader();
            connection.Close();
            return 1;
        }

        public int edit(Client client)
        {
            
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "update_client";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@client_id", client.ID);
            command.Parameters.AddWithValue("@name_", client.Name);
            command.Parameters.AddWithValue("@last_name_", client.LastName);
            command.Parameters.AddWithValue("@address_", client.Address);
            command.Parameters.AddWithValue("@city_", client.City);
            command.Parameters.AddWithValue("@email_", client.Email);
            command.Parameters.AddWithValue("@phone_", client.Phone);
            command.Parameters.AddWithValue("@job_", client.Job);
            connection.Open();
            command.ExecuteReader();
            connection.Close();
            return 1;
        }

        public IEnumerable<Client> GetClients(string filter)
        {
            SqlDataReader readRows;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "sp_get_registers";
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@id_", filter);
            connection.Open();
            readRows = command.ExecuteReader();

            List<Client> genericList = new List<Client>();

            while (readRows.Read())
            {
                genericList.Add(new Client
                {
                    ID = readRows.GetInt32(0),
                    Name = readRows.GetString(1),
                    LastName = readRows.GetString(2),
                    Address = readRows.GetString(3),
                    City = readRows.GetString(4),
                    Email = readRows.GetString(5),
                    Phone = readRows.GetString(6),
                    Job = readRows.GetString(7)
                });
            }
            readRows.Close();
            connection.Close();
            return genericList;
        }

        public int remove(int id)
        {
            SqlDataReader readRows;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "sp_delete_client";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_", id);
            connection.Open();
            readRows = command.ExecuteReader();         
            connection.Close();
            return 1;
        }
    }
}
