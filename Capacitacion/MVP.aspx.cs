using Capacitacion.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capacitacion
{
    public partial class MVP : System.Web.UI.Page, IPersonasView
    {
        private PersonasPresenter _presenter;

        protected void Page_Load(object sender, EventArgs e)
        {
            _presenter = new PersonasPresenter(this);
            if (!IsPostBack)
            {
                _presenter.ListarPersonas();
            }
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            _presenter.AgregarPersona();
            _presenter.ListarPersonas();

            Nombre.Text = "";
            Tratamiento.Text = "";
            Edad.Text = "";
        }


        string IPersonasView.Nombre
        {
            get { return Nombre.Text; }
        }

        string IPersonasView.Tratamiento
        {
            get { return Tratamiento.Text; }
        }

        string IPersonasView.Edad
        {
            get { return Edad.Text; }
        }

        public void Listar(DataTable personas)
        {
            GridView.DataSource = personas;
            GridView.DataBind();
        }
    }
}