using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Capacitacion.Model
{
    public class PersonasModel
    {
        public DataTable ListarPersonas()
        {
            if (HttpContext.Current.Session["ListaPersonas"] == null)
            {
                var listaPersonas = new DataTable();
                listaPersonas.Columns.Add("Nombre", typeof(string));
                listaPersonas.Columns.Add("Tratamiento", typeof(string));
                listaPersonas.Columns.Add("Edad", typeof(string));

                HttpContext.Current.Session["ListaPersonas"] = listaPersonas;
            }

            return HttpContext.Current.Session["ListaPersonas"] as DataTable;
        }

        public void AgregarPersona(string nombre, string tratamiento, string edad)
        {
            var personas = ListarPersonas();
            personas.Rows.Add(nombre, tratamiento, edad);
        }
    }
}