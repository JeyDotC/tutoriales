using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitacion.Model
{
    public interface IPersonasView
    {
        string Nombre { get; }
        string Tratamiento { get; }
        string Edad { get; }

        void Listar(DataTable personas);
    }
}
