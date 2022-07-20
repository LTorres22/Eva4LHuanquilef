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
    public partial class MostrarMedidores : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new MedidorDALDB();

        private void cargaGrilla(List<Medidor> medidores)
        {
            this.grillaMedidor.DataSource = medidores;
            this.grillaMedidor.DataBind();
        }
        private void medidorGrilla()
        {
            List<Medidor> medidores;
            if (this.todosChk.Checked)
            {
                medidores = this.medidoresDAL.ObtenerMedidores();
            }
            else
            {
                medidores = this.medidoresDAL.ObtenerMedidores(this.tipoMedidorDDL.SelectedItem.Value);
            }
            this.cargaGrilla(medidores);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.medidorGrilla();
            }
        }
        protected void todosChk_CheckedChanged(object sender, EventArgs e)
        {
            this.tipoMedidorDDL.Enabled = !this.todosChk.Checked;
            this.medidorGrilla();
        }

        protected void tipoMedidorDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.medidorGrilla();
        }

        protected void grillaMedidor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int IdMedidor = Convert.ToInt32(e.CommandArgument);
                this.medidoresDAL.EliminarMedidor(IdMedidor);
                this.medidorGrilla();
            }
        }
    }
}