<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ServicioVehiculo.aspx.cs" Inherits="Presentacion.ServicioVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article class="articleServicioVehiculo">
        <asp:Label ID="lb_Servicio" runat="server" Text="Servicios :"></asp:Label>
    <asp:DropDownList ID="DDLServicio" runat="server" AutoPostBack="True"></asp:DropDownList>

        <asp:Label ID="lb_Vehiculo" runat="server" Text="Vehiculos :"></asp:Label>
    <asp:DropDownList ID="DDLVehiculo" runat="server" AutoPostBack="True"></asp:DropDownList>

        <asp:Button ID="btn_Registrar" runat="server" Text="Registrar Servicio" OnClick="btn_Registrar_Click"/>
    </article>
</asp:Content>
