using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms001
{
    interface IPersonasRepository
    {
        IList<Persona> BuscarTodos();
    }
}
