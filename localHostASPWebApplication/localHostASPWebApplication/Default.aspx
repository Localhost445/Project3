<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="localHostASPWebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        
            <h2>Update Account Info</h2>
            <p>
                Change Account ID from default &quot;000-0000-000&quot; to user-desired ID. Checks to make sure user input is in a valid format.</p>
            <p>
                New Account ID (&quot;XXX-XXXX-XXX&quot;):
                <asp:TextBox ID="updateAcctTextBox" runat="server" Width="273px"></asp:TextBox>
            </p>
            <p>
                
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit ID" />
                <p> New Account ID: 
                <asp:Label ID="newAcctLabel" runat="server"></asp:Label>
                
            </p>
                                
            </p>


            <h2>Flatten Account</h2>
            <p>
                Ask user for Account ID as a validation step.If valid Account ID is received, reset accountID and display message that account has been deactivated.</p>
            <p>
                Account ID to be deactivated (&quot;XXX-XXXX-XXX&quot;):<asp:TextBox ID="flattenTextBox" runat="server" Width="199px"></asp:TextBox>
            </p>
            <p>
                
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
                
            </p>
            <p>
                
                Output:
                <asp:Label ID="flattenLabel" runat="server"></asp:Label>
                
            </p>


            <h2>Calculate Predicted Value of a Stock</h2>
            <p>
                Generate the total value of a specific holding based on a valid stock symbol and count of shares. Uses ASU getStockQuote to return the specific stock&#39;s current price.
            </p>
            <p>
                Stock Symbol:
                <asp:TextBox ID="calcSymbolBox" runat="server"></asp:TextBox>
            </p>
            <p>
                Shares:
                <asp:TextBox ID="calcShareBox" runat="server"></asp:TextBox>
            </p>
            <p>
                
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Get Value" />
                
            </p>
            <p>
                
                Holding value:
                <asp:Label ID="calcStockLabel" runat="server"></asp:Label>
                
            </p>
        
            <h2>Get Market Prices</h2>
            <p>
               Given a valid stock market symbol (DJIA, NASDAQ, or SPX), return the current price whether market is closed or open.
            </p>
            <p>
                
                Market Symbol:
                <asp:TextBox ID="marketTextBox" runat="server"></asp:TextBox>
            </p>
            <p>
                
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click1" Text="Button" />
            </p>
            <p>
                
                Current Market Price:
                <asp:Label ID="marketPriceLabel" runat="server"></asp:Label>
            </p>

    </div>

</asp:Content>
