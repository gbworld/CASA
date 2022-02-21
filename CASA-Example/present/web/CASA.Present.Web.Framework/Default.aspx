<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CASA.Present.Web.Framework._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <h1>Standard Framework ASP.NET Sample</h1>
        <p class="lead">This sample is set up to show how to query for a simple ASP.NET Site</p>
      </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Query Postal Code Database</h2>
            <p>
                Use this form to query the postal code database.
                
                <asp:Table ID="Table1" runat="server" Width="366px">
                    <asp:TableRow>
                        <asp:TableCell>User Name:</asp:TableCell>
                        <asp:TableCell><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </p>
            <form>

            </form>
        </div>
    </div>

</asp:Content>
