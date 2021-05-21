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
    }
}
