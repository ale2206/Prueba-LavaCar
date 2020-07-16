<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Servicios.aspx.cs" Inherits="Presentacion.Servicios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article class="articleServicio">
        <asp:Label ID="lb_Nombre" runat="server" Text="Descripcion o Nombre: "></asp:Label>
            <asp:TextBox ID="tb_Nombre" runat="server"></asp:TextBox>

        <asp:Label ID="lb_Precio" runat="server" Text="Monto o Precio: "></asp:Label>
            <asp:TextBox ID="tb_Precio" runat="server"></asp:TextBox>

        <asp:Button ID="btn_Ingresar" runat="server" Text="Ingresar" OnClick="btn_Ingresar_Click"/>
        <asp:Button ID="btn_Modificar" runat="server" Text="Modificar" OnClick="btn_Modificar_Click"/>
        <asp:Button ID="btn_Eliminar" runat="server" Text="Eliminar" OnClick="btn_Eliminar_Click"/>
        <asp:Button ID="btn_Consultar" runat="server" Text="Consultar" OnClick="btn_Consultar_Click"/>
    </article>
</asp:Content>
