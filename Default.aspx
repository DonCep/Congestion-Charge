<%@ Page Title="Home Page" Culture="en-GB" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Congestion_Charge.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Congestion charge app</h2>
    </div>
        <h2>Choose vehicle</h2>
        <asp:DropDownList id="vehicleList" AutoPostBack="false" runat="server" CssClass="form-control">
            <asp:ListItem Value="Select">Select</asp:ListItem>
            <asp:ListItem Value="Car">Car</asp:ListItem>
            <asp:ListItem Value="Motorbike">Motorbike</asp:ListItem>
            <asp:ListItem Value="Van">Van</asp:ListItem>
        </asp:DropDownList>

        <asp:Button runat="server" OnClick="Select_Click" Text="Select" CssClass="btn btn-primary selectBtn"/>
        <asp:Button runat="server" OnClick="Reset_Click" Text="Clear" CssClass="btn btn-danger resetBtn"/>

        <h3>Output Car</h3>
        <label>Charge for 0h 28m (AM rate):</label><asp:TextBox runat="server" ID="TextIDCar"></asp:TextBox><br/>
        <label>Charge for 2h 42m (PM rate):</label><asp:TextBox runat="server" ID="TextIDCar2" ></asp:TextBox><br/>

        <h3>Output Motorbike</h3>
        <label>Charge for 0h 0m (AM rate):</label><asp:TextBox runat="server" ID="TextIDMoto" ReadOnly="true"></asp:TextBox><br/>
        <label>Charge for 2h 0m (PM rate):</label><asp:TextBox runat="server" ID="TextIDMoto2" ReadOnly="true"></asp:TextBox><br/>

        <h3>Output Van</h3>
        <label>Charge for 3h 39m(AM rate):</label><asp:TextBox runat="server" ID="TextIDVan" ReadOnly="true"></asp:TextBox> <br/>
        <label>Charge for 7h 0m (PM rate):</label><asp:TextBox runat="server" ID="TextIDVan2" ReadOnly="true"></asp:TextBox><br/>
</asp:Content>
