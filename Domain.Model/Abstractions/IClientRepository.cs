﻿using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Abstractions
{
    public interface IClientRepository
    {
        int add(Client client);
        int edit(Client client);
        int remove(int id);
        IEnumerable<Client> GetClients(string filter);
    }
}
