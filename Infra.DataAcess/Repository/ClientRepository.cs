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
            throw new NotImplementedException();
        }

        public int edit(Client client)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetClients(string filter)
        {
            SqlDataReader readRows;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "VerRegistros";
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@condition", filter);

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

        public int remove(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
