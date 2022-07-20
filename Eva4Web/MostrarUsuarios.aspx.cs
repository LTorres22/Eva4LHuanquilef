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
    public partial class MostrarUsuarios : System.Web.UI.Page
    {
        private IUsuariosDAL usuariosDAL = new UsuarioDALDB();

        private void cargaGrilla(List<Usuario> usuarios)
        {
            this.grillaUsuario.DataSource = usuarios;
            this.grillaUsuario.DataBind();
        }

        private void cargaGrilla()
        {
            List<Usuario> usuarios;
            if (this.todosChk.Checked)
            {
                usuarios = this.usuariosDAL.ObtenerUsuarios();
            }
            else
            {
                usuarios = this.usuariosDAL.ObtenerUsuarios(this.estadoDDL.SelectedItem.Value);
            }
            this.cargaGrilla(usuarios);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargaGrilla();
            }
        }
        protected void todosChk_CheckedChanged(object sender, EventArgs e)
        {
            this.estadoDDL.Enabled = !this.todosChk.Checked;
            this.cargaGrilla();
        }

        protected void estadoDDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargaGrilla();
        }

        protected void grillaUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                int IdUsuario = Convert.ToInt32(e.CommandArgument);
                this.usuariosDAL.EliminarUsuario(IdUsuario);
                this.cargaGrilla();
            }
        }
    }
}