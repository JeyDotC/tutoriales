using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capacitacion
{
    public partial class Delegados : System.Web.UI.Page
    {

        protected delegate void HacerAlgo();
        protected delegate void Donar();

        protected event Donar hacerDonacion;

        protected void Page_Load(object sender, EventArgs e)
        {
            hacerDonacion += () => Agregar("Toma!");

            hacerDonacion += () => Agregar("Ahí te va, insecto!");

            hacerDonacion += () => { throw new Exception("Buu!"); };

            hacerDonacion += () => Agregar("Aquí tienes!");
        }

        private void Agregar(string mensaje)
        {
            Lista.Items.Add(new ListItem(mensaje));
        }

        private void FooAction()
        {
            EntregarMensaje("Yo Digo Foo");
        }

        protected void FooButton_Click(object sender, EventArgs e)
        {
            AccionExplosiva(FooAction);
        }

        protected void BarButton_Click(object sender, EventArgs e)
        {
            AccionExplosiva(() => EntregarMensaje("Yo Digo Bar"));
        }

        protected void BazButton_Click(object sender, EventArgs e)
        {
            AccionExplosiva(
            hacer: () =>
            {
                Mensaje.Text = "Yo digo Baz...";
                throw new Exception(":P");
            },
            error: ex => Mensaje.Text = "Ups! " + ex.Message);
        }

        protected void AccionExplosiva(HacerAlgo hacer, Action<Exception> error = null)
        {
            try
            {
                hacer();
            }
            catch (Exception ex)
            {
                if (error != null)
                {
                    error(ex);
                }
                else
                {
                    //Poner la excepción en un log
                    Mensaje.Text = "Ups!";
                }
            }
        }

        protected void EntregarMensaje(string mensaje)
        {
            Mensaje.Text = mensaje;
        }

        protected void GoFoo_Click(object sender, EventArgs e)
        {
            AccionExplosiva(() =>
            {
                EntregarMensaje(">_< Haré una GenfooDama, denme de su Foo!");
                if (hacerDonacion != null)
                {
                    hacerDonacion();
                }
            });
        }
    }
}