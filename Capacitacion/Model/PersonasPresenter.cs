using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capacitacion.Model
{
    public class PersonasPresenter
    {
        private IPersonasView _view;
        private PersonasModel _model = new PersonasModel();

        public PersonasPresenter(IPersonasView view)
        {
            _view = view;
        }

        public void AgregarPersona()
        {
            _model.AgregarPersona(_view.Nombre, _view.Tratamiento, _view.Edad);
        }

        public void ListarPersonas()
        {
            _view.Listar(_model.ListarPersonas());
        }
    }
}