<%@ Page Language="C#" AutoEventWireup="true" CodeFile="InfoPage.aspx.cs" Inherits="InfoPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="infoStyles.css" />
    <title>Info Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="Title">
                <h1 id="InfoTax">Info Page</h1>
            </div>
            <div class="Main">
                <asp:Button ID="btnHome" runat="server" Text="Home" CssClass="btnHome" OnClick="btnHome_Click" />
                <asp:Button ID="btnCalcPage" runat="server" Text="Tax Calculator" CssClass="btnCalcPage" OnClick="btnCalcPage_Click" />
                <br />
            </div>
            <div class="WhatIsTax">
                <h3 id="TaxHead">
                    What is Tax?
                </h3>
                <p>
                    A compulsary contribution to state revenue, levied by the government on workers' income and business profits, or added to the cost of some goods, services, and transactions.
                </p>
                <h3 id="IncomeTaxHead">
                    What is income Tax?
                </h3>
                <p>
                    Income Tax is a tax you pay on your income. You do not have to pay tax on all types of income.
                </p>
            </div>
            <div class="HowItWorks">
                <h3 id="CalcHead">
                    How this calculator works.
                </h3>
                <p>

                </p>
            </div>
        </div>
    </form>
</body>
</html>
