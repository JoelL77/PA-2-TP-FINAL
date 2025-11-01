<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="tp_principal.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Alta de Evento</h2>
  <!--  <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <asp:Panel ID="pnlForm" runat="server">
        Nombre:<br />
        <asp:TextBox ID="txtNombre" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtNombre" ErrorMessage="Nombre requerido" runat="server" /><br />

        Descripción:<br />
        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" Rows="4" Columns="50" />
        <asp:RequiredFieldValidator ControlToValidate="txtDescripcion" ErrorMessage="Descripcion requerida" runat="server" /><br />

        Fecha del Evento:<br />
        <asp:TextBox ID="txtFecha" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtFecha" ErrorMessage="Fecha requerida" runat="server" />
        <asp:CompareValidator ControlToValidate="txtFecha" Operator="DataTypeCheck" Type="Date" ErrorMessage="Formato de fecha inválido" runat="server" /><br />

        Capacidad:<br />
        <asp:TextBox ID="txtCapacidad" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtCapacidad" ErrorMessage="Capacidad requerida" runat="server" />
        <asp:RangeValidator ControlToValidate="txtCapacidad" MinimumValue="1" MaximumValue="1000" Type="Integer" ErrorMessage="Capacidad debe ser entre 1 y 1000" runat="server" /><br />

        Precio:<br />
        <asp:TextBox ID="txtPrecio" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtPrecio" ErrorMessage="Precio requerido" runat="server" /><br />

        Categoria:<br />
        <asp:DropDownList ID="ddlCategoria" runat="server">
            <asp:ListItem Value="">--Seleccionar--</asp:ListItem>
            <asp:ListItem Value="Concierto">Concierto</asp:ListItem>
            <asp:ListItem Value="Congreso">Congreso</asp:ListItem>
            <asp:ListItem Value="Feria">Feria</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ControlToValidate="ddlCategoria" InitialValue="" ErrorMessage="Categoria requerida" runat="server" /><br />

        Organizador:<br />
        <asp:TextBox ID="txtOrganizador" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtOrganizador" ErrorMessage="Organizador requerido" runat="server" /><br />

        Telefono:<br />
        <asp:TextBox ID="txtTelefono" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtTelefono" ErrorMessage="Telefono requerido" runat="server" /><br />

        Email:<br />
        <asp:TextBox ID="txtEmail" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtEmail" ErrorMessage="Email requerido" runat="server" />
        <asp:RegularExpressionValidator ControlToValidate="txtEmail" ErrorMessage="Email inválido" ValidationExpression="\w+@\w+\.\w+" runat="server" /><br />

        Direccion:<br />
        <asp:TextBox ID="txtDireccion" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtDireccion" ErrorMessage="Direccion requerida" runat="server" /><br />

        Localidad:<br />
        <asp:DropDownList ID="ddlLocalidad" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="ddlLocalidad" InitialValue="" ErrorMessage="Localidad requerida" runat="server" /><br />

        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    </asp:Panel> -->
</asp:Content>
