<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMedidor.aspx.cs" Inherits="Eva4Web.AgregarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6">
            <div class="card">
                <div class="card-header bg-black text-white">
                    <h3>Agregar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="numeroTxt">Numero del Medidor:</label>
                        <asp:TextBox ID="numeroTxt" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="numeroTxt" CssClass="text-danger" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Debe Ingresar el numero del medidor"></asp:RequiredFieldValidator>
                    </div>                               
                    <div class="form-group">
                        <label for="tipoMedidorRbl">Tipo de Medidor:</label>
                        <asp:RadioButtonList ID="tipoMedidorRbl" runat="server">
                            <asp:ListItem Text="Digital" Selected="True" Value="Digital"></asp:ListItem>
                            <asp:ListItem Text="Análogo" Value="Análogo"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>  
                     <div class="form_group">
                        <label for="UsuarioDDL">Usuario:</label>
                        <asp:DropDownList ID="UsuarioDDL" runat="server"></asp:DropDownList>
                    </div>
                    <asp:Button runat="server" CssClass="btn btn-secondary" OnClick="ingresarBtn_Click" ID="ingresarBtn" Text="Ingresar" />
                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
