
<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="alta-empleado.aspx.cs" Inherits="tp_principal.Views.empleado.alta_empleado" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-6">
                  <label class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtNombre" ErrorMessage="Nombre requerido" runat="server" /><br />

        </div>
        <div class="col-6">
                  <label class="form-label">Apellido</label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtApellido" ErrorMessage="Nombre requerido" runat="server" /><br />

        </div>
        <div class="col-6">
                  <label class="form-label">Fecha Nacimiento</label>
                  <asp:TextBox ID="txtFecha" runat="server" />
                  <asp:RequiredFieldValidator ControlToValidate="txtFecha" ErrorMessage="Fecha requerida" runat="server" />
                  <asp:CompareValidator ControlToValidate="txtFecha" Operator="DataTypeCheck" Type="Date" ErrorMessage="Formato de fecha inválido" runat="server" /><br />
        </div>
        <div class="col-6">
                  <label class="form-label">Capacidad</label>
                  <asp:TextBox ID="txtCapacidad" runat="server" />
                  <asp:RequiredFieldValidator ControlToValidate="txtCapacidad" ErrorMessage="Capacidad requerida" runat="server" />
                  <asp:RangeValidator ControlToValidate="txtCapacidad" MinimumValue="1" MaximumValue="1000" Type="Integer" ErrorMessage="Capacidad debe ser entre 1 y 1000" runat="server" /><br />
         </div>
        <div class="col-6">
                  <label class="form-label">Precio</label>
                  <asp:TextBox ID="txtPrecio" runat="server" />
                  <asp:RequiredFieldValidator ControlToValidate="txtPrecio" ErrorMessage="Precio requerido" runat="server" /><br />
        </div>
        <div class="col-6">
                  <label class="form-label">Capacidad</label>
                    <asp:DropDownList ID="ddlCategoria" runat="server">
                        <asp:ListItem Value="">--Seleccionar--</asp:ListItem>
                        <asp:ListItem Value="Concierto">Concierto</asp:ListItem>
                        <asp:ListItem Value="Congreso">Congreso</asp:ListItem>
                        <asp:ListItem Value="Feria">Feria</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ControlToValidate="ddlCategoria" InitialValue="" ErrorMessage="Categoria requerida" runat="server" /><br />
         </div>
        <div class="col-6">
                  <label class="form-label">Organizador</label>
                    <asp:TextBox ID="txtOrganizador" runat="server" />
                    <asp:RequiredFieldValidator ControlToValidate="txtOrganizador" ErrorMessage="Organizador requerido" runat="server" /><br />
        </div>
        <div class="col-6">
                  <label class="form-label">Télefono</label>
                    <asp:TextBox ID="txtTelefono" runat="server" />
                    <asp:RequiredFieldValidator ControlToValidate="txtTelefono" ErrorMessage="Telefono requerido" runat="server" /><br />
        </div>
        <div class="col-6">
                  <label class="form-label">Email</label>
                    <asp:TextBox ID="txtEmail" runat="server" />
                    <asp:RequiredFieldValidator ControlToValidate="txtEmail" ErrorMessage="Email requerido" runat="server" />
                    <asp:RegularExpressionValidator ControlToValidate="txtEmail" ErrorMessage="Email inválido" ValidationExpression="\w+@\w+\.\w+" runat="server" /><br />
        </div>
        <div class="col-6">
                  <label class="form-label">Dirección</label>
                    <asp:TextBox ID="txtDireccion" runat="server" />
                    <asp:RequiredFieldValidator ControlToValidate="txtDireccion" ErrorMessage="Direccion requerida" runat="server" /><br />
                     </div>
        <div class="col-6">
                  <label class="form-label">Localidad</label>
                    <asp:DropDownList ID="ddlLocalidad" runat="server" />
                    <asp:RequiredFieldValidator ControlToValidate="ddlLocalidad" InitialValue="" ErrorMessage="Localidad requerida" runat="server" /><br />
        </div>
        <div class="col-6">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnSubmit_Click" />
        </div>
    </div>

</asp:Content>