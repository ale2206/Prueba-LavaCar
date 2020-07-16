<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Reporte.aspx.cs" Inherits="Presentacion.Reporte" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <article class="articleReporte">

    <asp:Label ID="lb_Servicios" runat="server" Text="Servicios :"></asp:Label>
    <asp:DropDownList ID="DDLServicios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDLServicios_SelectedIndexChanged"></asp:DropDownList>

    </article>

    <article class="articleGridView">
        <asp:GridView ID="GVServicios" runat="server" AutoGenerateColumns="False" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" DataKeyNames="ID_Vehiculo" >
            <Columns>
                <asp:BoundField DataField="Placa" HeaderText="Placa del Vehiculo"></asp:BoundField>
                <asp:BoundField DataField="Dueño" HeaderText="Dueño del Vehiculo"></asp:BoundField>
                <asp:BoundField DataField="Marca" HeaderText="Marca del Vehiculo"></asp:BoundField>
            </Columns>
       </asp:GridView>
    </article>

    <article class="articleGridView">
        <asp:GridView ID="GVVehiculosServicios" runat="server" AutoGenerateColumns="False" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" DataKeyNames="ID_Vehiculo_Servicio" >
            <Columns>
                <asp:BoundField DataField="ID_Servicio" HeaderText="ID Servicio"></asp:BoundField>
                <asp:BoundField DataField="ID_Vehiculo" HeaderText="ID Vehiculo"></asp:BoundField>
            </Columns>
       </asp:GridView>
    </article>


</asp:Content>
