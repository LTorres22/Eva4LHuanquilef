<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarMedidores.aspx.cs" Inherits="Eva4Web.MostrarMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
     <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>

    <div class="row">
        <div class="col-lg-6 mx-auto">
            <asp:DropDownList ID="tipoMedidorDDL" runat="server" Enabled="false" OnSelectedIndexChanged="tipoMedidorDDL_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Digital" Value="Digital"></asp:ListItem>
                <asp:ListItem Text="Analogo" Value="Analogo"></asp:ListItem>
            </asp:DropDownList>
            <asp:CheckBox runat="server" ID="todosChk" Text="Todos" Checked="true" 
                AutoPostBack="true" OnCheckedChanged="todosChk_CheckedChanged"/> 
        </div>
        <asp:UpdatePanel ID="UpdatePanel" runat="server">
            <ContentTemplate>
                <div class="row mt-5">
                    <asp:GridView 
                        CssClass="table table-hover table-bordered"
                        ID="grillaMedidor"
                        AutoGenerateColumns="false"
                        ShowHeaderWhenEmpty="true"
                        EmptyDataText="No hay registros"                       
                        runat="server"
                        OnRowCommand="grillaMedidor_RowCommand">
                        
                        <Columns>
                            <asp:BoundField HeaderText="Numero" DataField="Numero" />
                            <asp:BoundField HeaderText="TipoMedidor" DataField="TipoMedidor" />                            
                            <asp:BoundField HeaderText="Usuario" DataField="Usuario.Nombre" />
                            <asp:TemplateField HeaderText="Acciones">
                                <ItemTemplate>
                                    <asp:Button CssClass="btn btn-danger" runat="server"
                                        CommandName="eliminar" Text="Eliminar"
                                        CommandArgument='<%#Eval("IdMedidor") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
        </ContentTemplate>           
        </asp:UpdatePanel>

        </div>
</asp:Content>