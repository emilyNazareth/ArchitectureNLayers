using Aplication;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Desktop.ViewModel;

namespace UI.Desktop.ApplicationController
{
    class ClientController
    {

        public void add(string name, string lastName, string address, string city,
            string email, string phone, string job)
        {
            Client client = new Client();
            client.Name = name;
            client.LastName = lastName;
            client.Address = address;
            client.City = city;
            client.Email = email;
            client.Phone = phone;
            client.Job = job;
            var clientStatus = new ClientService().add(client);
        }
        public IEnumerable<ClientViewModel> GetClients(string filter)
        {
            var clientList = new ClientService().GetClients(filter);

            List<ClientViewModel> viewModels = new List<ClientViewModel>();

            foreach (Client item in clientList)
            {
                viewModels.Add(new ClientViewModel
                {
                    ID = item.ID,
                    Name = item.Name,
                    LastName = item.LastName,
                    Address = item.Address,
                    City = item.City,
                    Email = item.Email,
                    Phone = item.Phone,
                    Job = item.Job
                });
            }

            return viewModels;

        }

        public void remove(int id)
        {
            var clientList = new ClientService().remove(id);
        }

        public void edit(ClientViewModel clientModel)
        {
            Client client = new Client();
            client.ID = clientModel.ID;
            client.Name = clientModel.Name;
            client.LastName = clientModel.LastName;
            client.Address = clientModel.Address;
            client.City = clientModel.City;
            client.Email = clientModel.Email;
            client.Phone = clientModel.Phone;
            client.Job = clientModel.Job;
            var editResult = new ClientService().edit(client);
        }
    }
}
