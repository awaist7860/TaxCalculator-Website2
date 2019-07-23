<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="HomePageStyles.css" />
    <title>Tax Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <!--Html code starts here-->

            <div id ="Title">
                <h1>Tax Calculator Home</h1>
            </div>

            <div class="MainBody">
                <asp:Button ID="btnNextPage" runat="server" Text="Tax Calculator" OnClick="btnNextPage_Click" CssClass="btnNextPage" />
                <asp:Button ID="btnInfo" runat="server" Text="Info" CssClass="btnInfo" OnClick="btnInfo_Click" />
            </div>

            <div id="footer"><!-- This is the footer and its at the bottom of the page.-->
                <address>
                    Created By Awais Tasleem
                </address>
            </div>
        </div>
    </form>
</body>
</html>
