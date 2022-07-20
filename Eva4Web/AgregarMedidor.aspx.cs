using Eva4Model;
using Evaluacion4Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eva4Web
{
    public partial class AgregarMedidor : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidorDALDB();
        private IUsuariosDAL usuariosDAL = new UsuarioDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.UsuarioDDL.DataSource = this.usuariosDAL.ObtenerUsuarios();
                this.UsuarioDDL.DataTextField = "Nombre";
                this.UsuarioDDL.DataValueField = "IdUsuario";
                this.UsuarioDDL.DataBind();
            }
        }
        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            Medidor medidor = new Medidor();
            medidor.Numero = Convert.ToInt32(this.numeroTxt.Text.Trim());
            medidor.TipoMedidor = this.tipoMedidorRbl.SelectedValue;
            medidor.IdUsuario = Convert.ToInt32(this.UsuarioDDL.SelectedItem.Value);

            this.medidoresDAL.AgregarMedidor(medidor);
            Response.Redirect("MostrarMedidores.aspx");
        }
    }
}