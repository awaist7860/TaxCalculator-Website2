<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TaxCalculatorPage.aspx.cs" Inherits="TaxCalculatorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="CalculatorStyles.css" />
    <title>Tax Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <!-- code starts here-->

            <div class ="Ttile">
                <h1>Tax Calculator Page</h1>
                <div id="Back">
                    <asp:Button ID="btnBack" runat="server" Text="Home" CssClass="btnBack" OnClick="btnBack_Click" />
                </div>
                <div id ="Pay Amount">
                    <h3>How Much Do You Get Paid?</h3>
                    <br /><!-- The line breaks-->
                    <asp:Label ID="lblPoundSymbol" runat="server" Text="£" CssClass="lblPoundSymbol"></asp:Label>
                    <asp:TextBox ID="txtAmount" runat="server" CssClass="txtAmount"></asp:TextBox>
                </div>
            </div>

            <!-- <br /><!-- The line breaks-->

      <!--      <div class="AmountHours">
                <h3>How many hours do you work in a week</h3>
                <div id="Hours">
                    <asp:TextBox ID="txtHours" runat="server"></asp:TextBox>
                </div>
            </div>

            -->
            <div class="typeOfPay">
                <h4>How are you getting paid?</h4>
                <div id="TypeOfPayCheckBox">
                    <asp:CheckBox ID="chkHour" runat="server" CssClass="chkHour" Text="Hour" AutoPostBack="True" OnCheckedChanged="chkHour_CheckedChanged" />
                    <br /><!-- The line breaks-->
                    <asp:Label ID="lblMany" runat="server" Text="How many hours do you work"></asp:Label>
                    <br /><!-- The line breaks-->
                    <asp:TextBox ID="txtHoursWorked" runat="server"></asp:TextBox>
                    <br /><!-- The line breaks-->
                    <asp:CheckBox ID="chkDay" runat="server" CssClass="chkDay" Text="Day" AutoPostBack="True" OnCheckedChanged="chkDay_CheckedChanged" />
                    <br /><!-- The line breaks-->
                    <asp:Label ID="lbldays" runat="server" Text="How many days a week do you work"></asp:Label>
                    <br /><!-- The line breaks-->
                    <asp:TextBox ID="txtDaysWorked" runat="server" CssClass="txtDaysWorked"></asp:TextBox>
                    <br /><!-- The line breaks-->
                    <asp:CheckBox ID="chkWeek" runat="server" CssClass="chkWeek" Text="Week" AutoPostBack="True" OnCheckedChanged="chkWeek_CheckedChanged" />
                    <br /><!-- The line breaks-->
                    <asp:CheckBox ID="chkMonth" runat="server" CssClass="chkMonth" Text="Month" AutoPostBack="True" OnCheckedChanged="chkMonth_CheckedChanged" />
                    <br /><!-- The line breaks-->
                    <asp:CheckBox ID="chkYear" runat="server" CssClass="chkYear" Text="Year" AutoPostBack="True" OnCheckedChanged="chkYear_CheckedChanged" />
                </div>
            </div> 

            <br /><!-- The line breaks-->
             
            <div class="StatePension">
                <asp:Label ID="lblStatepension" runat="server" Text="Are you over the State Pension age?" CssClass="lblStatepension"></asp:Label>
                <br /><!-- The line breaks-->
                <asp:CheckBox ID="chkPensionYes" runat="server" AutoPostBack="True" CssClass="chkPensionYes" Text="Yes" OnCheckedChanged="chkPensionYes_CheckedChanged" />
                <asp:CheckBox ID="chkPensionNo" runat="server" AutoPostBack="True" CssClass="chkPensionNo" Text="No" />
            </div>

            <div class="Scotland">
                <h3>Do you live in Scotland</h3>
                <asp:CheckBox ID="chkScotYes" runat="server" AutoPostBack="True" Text="Yes" CssClass="chkScotYes" OnCheckedChanged="chkScotYes_CheckedChanged" />
                <asp:CheckBox ID="chkScotNo" runat="server" AutoPostBack="True" Text="No" CssClass="chkScotNo" />
            </div>

            <div class="Hidden">
                <asp:Label ID="lblHidden" runat="server" Text="Test" Visible="False"></asp:Label>
            </div>

           <!-- <br /><!-- The line breaks-->

            <div class="TaxCode">
                <h3>Please Enter Your Tax Code</h3>
                <p>If you dont have a tax code we will use the default tax code 1250L</p>
                <div id="TaxCheckBox">
                    <asp:CheckBox ID="taxChkYes" runat="server" CssClass="taxChkYes" Text="Yes" AutoPostBack="True" OnCheckedChanged="taxChkYes_CheckedChanged" />
                    <asp:CheckBox ID="taxChkNo" runat="server" CssClass="taxChkNo" Text="No" AutoPostBack="True" />
                    <br /><!-- The line breaks-->
                    <asp:Label ID="lblTaxCodeHiddenLabel" runat="server" Text="Enter your Tax code" Visible="False"></asp:Label>
                    <br /><!-- The line breaks-->
                    <asp:TextBox ID="txtTaxCodeHiddenTextBox" runat="server" OnTextChanged="txtHiddenTextBox_TextChanged" Visible="False"></asp:TextBox>
                </div>
            </div>

            <div class="Calculate">
                <h3>Calculate you Tax</h3>
                <asp:Button ID="btnCalcualte" runat="server" Text="Calculate" OnClick="btnCalcualte_Click" CssClass="btnCalcualte" />
            </div>

            <div class="Results">
                <h2>Your Estimated Net Pay</h2>
                <div id="YearlyPay">
                    <asp:Label ID="lblYearlyPay" runat="server" CssClass="lblYearlyPay"></asp:Label>
                </div>
                <div id="MonthlyPay">
                    <asp:Label ID="lblMonthlyPay" runat="server" CssClass="lblMonthlyPay"></asp:Label>
                </div>
                <div id="WeeklyPay">
                    <asp:Label ID="lblWeeklyPay" runat="server" CssClass="lblWeeklyPay"></asp:Label>
                </div>
            </div>

        </div>
    </form>
</body>
</html>
