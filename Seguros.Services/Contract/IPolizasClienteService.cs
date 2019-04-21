﻿using Seguros.Entities.Entities;
using System.Collections.Generic;

namespace Seguros.Services.Contract
{
    public interface IPolizasClienteService
    {
        IEnumerable<PolizasCliente> GetAll();

        PolizasCliente Find(int id);

        int Create(PolizasCliente entity);

        bool Update(PolizasCliente entity);

        int Delete(PolizasCliente entity);
    }
}
