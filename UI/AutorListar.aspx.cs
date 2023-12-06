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
    public partial class AutorListar : System.Web.UI.Page
    {

        private AutorBL autorBL = new AutorBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvAutores.DataSource = autorBL.FindAll();
                gvAutores.DataBind();
            }
        }
    }
}