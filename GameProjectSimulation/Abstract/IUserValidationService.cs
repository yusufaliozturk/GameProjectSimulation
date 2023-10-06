using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectSimulation.Entities;

namespace GameProjectSimulation.Abstract
{
    interface IUserValidationService
    {
        public bool Validate(Customer customer);
    }
}
