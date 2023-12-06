using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BE;
using BL;

namespace UI
{
    public partial class AutorRegistrar : System.Web.UI.Page
    {

        private AutorBL autorBL = new AutorBL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            DateTime fnacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            int nacionalidad = Convert.ToInt32(txtNacionalidad.Text);

            Autore autoreBE = new Autore(apellido,nombre,fnacimiento,nacionalidad);
            autorBL.Insert(autoreBE);

            Response.Redirect("~/AutorListar.aspx");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AutorListar.aspx");
        }
    }
}