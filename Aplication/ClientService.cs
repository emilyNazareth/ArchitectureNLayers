﻿using Domain.Model.Abstractions;
using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infra.DataAcess.Repository;

namespace Aplication
{
    public class ClientService
    {
        readonly IClientRepository clientRepository;

        public ClientService()
        {
            clientRepository = new ClientRepository();

        }

        public IEnumerable<Client> GetClients(string filter)
        {
            return clientRepository.GetClients(filter);
        }
    }
}