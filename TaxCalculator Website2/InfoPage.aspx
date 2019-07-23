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
                    It takes you yearly salary and takes away £12500 from it. Then it multiplies the left-over amount by the percentage bracket that your pay is in. For example, if your pay is £11000 a year, then no tax will be taken. If your pay is £25000 then it will take $12500 from it and do the tax calculation on that.
                </p>
                <p>
                    If you pay Scottish income tax, then you check that box and the calculation will take away the same amount from your salary (£12500) but it will use the Scottish income tax percentages instead.
                </p>
                <p>
                    The national insurance calculation works by taking your yearly pay and dividing it by 52 for the number of weeks in a year. Then it checks if your weekly pay is in one of the 3 ranges. If your weekly pay is less than £166 then nothing will be deducted from your yearly pay. If your weekly pay is in between £167 and £962, then 12% will be taken off your pay. If your pay is more than £963, then it will take off £962 from the total weekly pay and then 2% will be taken off that also with the 12% taken off from the £962 and it will all be added together, and taken off from your weekly pay.
                </p>
            </div>
            <div class="Reference">
                <h3 id="ReferencesHead">
                    References
                </h3>
                <p>
                    <a href="https://www.gov.uk/income-tax-rates">Income Tax rates Website</a>
                    <br />
                    <a href="https://www.gov.uk/scottish-income-tax">Scottish Income Tax</a>
                    <br />
                    <a href="https://www.gov.uk/national-insurance-rates-letters">National Insurance rates</a>
                    </p>
                <h3 id="DisclaimerHead">
                    Disclaimer
                </h3>
                <p>
                    All the code was written by me, didnt google anything, didnt ask anyone anything.
                    I used the previous projects for some help.
                    The source code is on my Github account
                </p>
            </div>
            <div class="Social">
                <h3 id="SocialHead">
                    Social Media
                </h3>
                <p>
                    <a href="https://github.com/awaist7860">Awais GitHub</a>
                    <br />
                    <a href="https://uk.linkedin.com/in/awais-tasleem-b1b27b180?trk=people-guest_profile-result-card_result-card_full-click">Awais Linkedin</a>
                </p>
            </div>
        </div>
    </form>
</body>
</html>
