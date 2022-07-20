<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarUsuarios.aspx.cs" Inherits="Eva4Web.MostrarUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
     <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <asp:DropDownList ID="estadoDDL" runat="server" Enabled="false" OnSelectedIndexChanged="estadoDDL_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Activo" Value="Activo"></asp:ListItem>
                <asp:ListItem Text="Inactivo" Value="Inactivo"></asp:ListItem>
            </asp:DropDownList>
            <asp:CheckBox runat="server" ID="todosChk" Text="Todos" Checked="true" 
                AutoPostBack="true" OnCheckedChanged="todosChk_CheckedChanged"/> 
        </div>
        <asp:UpdatePanel ID="UpdatePanel" runat="server">
            <ContentTemplate>
                <div class="row mt-5">
                    <asp:GridView 
                        CssClass="table table-hover table-bordered"
                        ID="grillaUsuario"
                        AutoGenerateColumns="false"
                        ShowHeaderWhenEmpty="true"
                        EmptyDataText="No hay registros"                       
                        runat="server"
                        OnRowCommand="grillaUsuario_RowCommand">
                        
                        <Columns>
                            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                            <asp:BoundField HeaderText="Rut" DataField="Rut" />
                            <asp:BoundField HeaderText="Contraseña" DataField="Contraseña" />
                            <asp:BoundField HeaderText="Correo" DataField="Correo" />
                            <asp:BoundField HeaderText="Estado" DataField="Estado" />
                            <asp:TemplateField HeaderText="Acciones">
                                <ItemTemplate>
                                    <asp:Button CssClass="btn btn-danger" runat="server"
                                        CommandName="eliminar" Text="Eliminar"
                                        CommandArgument='<%#Eval("IdUsuario") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
        </ContentTemplate>           
        </asp:UpdatePanel>

        </div>
</asp:Content>