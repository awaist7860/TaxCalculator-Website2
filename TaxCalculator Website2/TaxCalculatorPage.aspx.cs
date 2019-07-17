using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TaxCalculatorPage : System.Web.UI.Page
{

    //52 weeks for 1 year       Done
    //12 months for 1 year      Done
    //1 year                    Done
    //National income tax   done
    //Scottish income tax   done
    //Employee National income tax

    //If the new code doesnt work then add this in

    //if(minTax <= 12500)
    //{
    //double weekly = minTax / 52;
    //double month = minTax / 12;
    //lblYearlyPay.Text = "£" + minTax.ToString() + " Yearly Pay";
    //lblMonthlyPay.Text = "£" + month.ToString() + " Monthly Pay";
    //lblWeeklyPay.Text = "£" + weekly.ToString() + " Weekly Pay";
    //}

    //Add a way so that the is a validation check on the calculate button
    //source link for the tax percentage brackets
    // https://www.gov.uk/income-tax-rates

protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtHiddenTextBox_TextChanged(object sender, EventArgs e)
    {

    }

    protected void taxChkYes_CheckedChanged(object sender, EventArgs e)
    {
        //this hides the tax code text box and label
        if (taxChkYes.Checked)
        {
            lblTaxCodeHiddenLabel.Visible = true;
            txtTaxCodeHiddenTextBox.Visible = true;
        }
        else
        { 
            lblTaxCodeHiddenLabel.Visible = false;
            txtTaxCodeHiddenTextBox.Visible = false;
        }
    }

    protected void btnCalcualte_Click(object sender, EventArgs e)
    {
        //This will work out hourly pay
        //double hour;
        // double amount = System.Convert.ToDouble(txtAmount.Text);
        //double time = System.Convert.ToDouble(txtHours.Text);
        // hour = amount * time;
        //lblYearlyPay.Text = hour.ToString();

        

        if (chkHour.Checked)
        {
            hourlyPay();//Calls the hourPay method
        }
        if (chkDay.Checked)
        {
            dailyPay();//calls the dailyPay method
        }
        if (chkWeek.Checked)
        {
            weeklyPay();//calls the weeklyPay method
        }
        if (chkMonth.Checked)
        {
            monthlyPay();//Calls the monthlyPay method
        }
        if (chkYear.Checked)
        {
            yearlyPay();//Calls the yearlyPay method
        }

        if (chkScotYes.Checked)
        {
            scotishTaxCalulation();
            nationalInsurance();
        }
        else
        {
            britishTaxCalculation();
            nationalInsurance();
        }

        displayingResults();
    }

    public void displayingResults()
    {
        double yearResult = System.Convert.ToDouble(lblYearlyPay.Text);
        double monthResult = System.Convert.ToDouble(lblMonthlyPay.Text);
        double weekResult = System.Convert.ToDouble(lblWeeklyPay.Text);
        double yearlyNationalInsurance;
        double monthlyNationalInsurance;
        double weeklyNationalInsurance;
        double NI;

        double yearlyTotalPay;
        double monthlyTotalPay;
        double weeklyTotalPay;

        NI = System.Convert.ToDouble(lblNatinalInsurance.Text);

        yearlyNationalInsurance = NI * 52;
        monthlyNationalInsurance = NI * 4;
        weeklyNationalInsurance = NI;

        yearlyTotalPay = yearResult - yearlyNationalInsurance;
        monthlyTotalPay = monthResult - monthlyNationalInsurance;
        weeklyTotalPay = weekResult - weeklyNationalInsurance;

        lblYearReult.Text = yearlyTotalPay.ToString();
        lblMonthResult.Text = monthlyTotalPay.ToString();
        lblWeekResult.Text = weeklyTotalPay.ToString();
    }

    public void hourlyPay()//HourlyPay
    {
        if (chkHour.Checked && txtHoursWorked.Text != "" && txtAmount.Text != "")
        {

            double hour;
            double hourAmount = System.Convert.ToDouble(txtAmount.Text);
            double hoursWorked = System.Convert.ToDouble(txtHoursWorked.Text);
            hour = hourAmount * hoursWorked;
            hour = hour * 52;
            lblHidden.Text = hour.ToString();
            //multiply this by 52
            txtHoursWorked.Text = "";       //Remove this later
            chkHour.Checked = false;
        }
        else
        {
            lblHidden.Text = "Please enter a number";
        }

    }



    public void dailyPay()//Dailypay
    {
        if(chkDay.Checked && txtDaysWorked.Text != "" && txtAmount.Text != "")
        {
            double day;
            double dayAmount = System.Convert.ToDouble(txtAmount.Text);
            double daysWorked = System.Convert.ToDouble(txtDaysWorked.Text);
            day = dayAmount * daysWorked;
            day = day * 52;
            lblHidden.Text = day.ToString();
            //multiply this by 52
            txtDaysWorked.Text = "";        //Remove this later
            chkDay.Checked = false;
        }
        else
        {
            lblHidden.Text = "Please enter a number";
        }
    }



    public void weeklyPay()//WeeklyPay
    {
        if (chkWeek.Checked && txtAmount.Text != "")
        {
            double week;
            int NumWeeks = 52;
            double weekAmount = System.Convert.ToDouble(txtAmount.Text);
            week = weekAmount * NumWeeks;
            lblHidden.Text = week.ToString();
            chkWeek.Checked = false;
        }
        else
        {
            lblHidden.Text = "Please enter a number";
        }
    }

    public void monthlyPay()
    {
        if (chkMonth.Checked && txtAmount.Text != "")
        {
            double month;
            int NumMonths = 12;
            double monthAmount = System.Convert.ToDouble(txtAmount.Text);
            month = monthAmount * NumMonths;
            lblHidden.Text = month.ToString();
            chkMonth.Checked = false;
        }
        else
        {
            lblHidden.Text = "Please enter a number";
        }
    }

    public void yearlyPay()
    {
        if (chkYear.Checked && txtAmount.Text != "")
        {
            double year;
            double yearAmount = System.Convert.ToDouble(txtAmount.Text);
            year = yearAmount;
            lblHidden.Text = year.ToString();
            chkYear.Checked = false;
        }
        else
        {
            lblHidden.Text = "Please enter a number";
        }
    }


    public void britishTaxCalculation()
    {

        double minTax;
        minTax = System.Convert.ToDouble(lblHidden.Text);
        
        if (minTax <= 12500)
        {
            //No tax is payed on anything below 12500
            double weekly = minTax / 52;
            double month = minTax / 12;
            lblYearlyPay.Text = minTax.ToString();
            lblMonthlyPay.Text = month.ToString();
            lblWeeklyPay.Text = weekly.ToString();
        }
        //All these if satments are for the english tax
        #region englishTax
        else if (minTax >= 12501 && minTax <= 50000)
        {
            //this works the percentage of income tax after the the tax free allowance is taken out
            double netYear;
            double yearly = minTax - 12500;//This is the taxable amount
            yearly = yearly * 0.2;
            netYear = minTax - yearly;
            double monthly = netYear / 12;
            double weekly = netYear / 52;
            lblYearlyPay.Text = netYear.ToString();
            lblMonthlyPay.Text = monthly.ToString();
            lblWeeklyPay.Text =  weekly.ToString();
        }
        else if(minTax >= 50001 && minTax <= 150000)
        {
            //12501 is the tax free allowance
            double netYear;
            double yearly = minTax - 12500;
            yearly = yearly * 0.4;
            netYear = minTax - yearly;
            double monthly = netYear / 12;
            double weekly = netYear / 52;
            lblYearlyPay.Text = netYear.ToString();
            lblMonthlyPay.Text = monthly.ToString();
            lblWeeklyPay.Text = weekly.ToString();
        }
        else if(minTax >= 150001)
        {
            double netYear;
            double yearly = minTax - 12500;
            yearly = yearly * 0.45;
            netYear = minTax - yearly;
            double monthly = netYear / 12;
            double weekly = netYear / 52;
            lblYearlyPay.Text = netYear.ToString();
            lblMonthlyPay.Text = monthly.ToString();
            lblWeeklyPay.Text = weekly.ToString();
        }
        #endregion
        else
        {
            lblYearlyPay.Text = "Please enter a valid number";
        }
    }

    public void scotishTaxCalulation()
    {
        //All these if statments are for the scottish tax

        double minTax;
        minTax = System.Convert.ToDouble(lblHidden.Text);

        #region scottishTax
        if (minTax >= 12501 && minTax <= 14550)
        {
            double netYear;
            double yearly = minTax - 12500;//This is the taxable amount
            yearly = yearly * 0.19;
            netYear = minTax - yearly;
            double monthly = netYear / 12;
            double weekly = netYear / 52;
            lblYearlyPay.Text = netYear.ToString();
            lblMonthlyPay.Text = monthly.ToString();
            lblWeeklyPay.Text = weekly.ToString() ;
            chkScotYes.Checked = false;
        }
        else if (minTax >= 14551 && minTax <= 24945)
        {
            double netYear;
            double yearly = minTax - 12500;//This is the taxable amount
            yearly = yearly * 0.2;
            netYear = minTax - yearly;
            double monthly = netYear / 12;
            double weekly = netYear / 52;
            lblYearlyPay.Text = netYear.ToString();
            lblMonthlyPay.Text = monthly.ToString();
            lblWeeklyPay.Text = weekly.ToString();
            chkScotYes.Checked = false;
        }
        else if (minTax >= 24946 && minTax <= 43430)
        {
            double netYear;
            double yearly = minTax - 12500;//This is the taxable amount
            yearly = yearly * 0.21;
            netYear = minTax - yearly;
            double monthly = netYear / 12;
            double weekly = netYear / 52;
            lblYearlyPay.Text = netYear.ToString();
            lblMonthlyPay.Text = monthly.ToString();
            lblWeeklyPay.Text = weekly.ToString();
            chkScotYes.Checked = false;
        }
        else if (minTax >= 43431 && minTax <= 150000)
        {
            double netYear;
            double yearly = minTax - 12500;//This is the taxable amount
            yearly = yearly * 0.41;
            netYear = minTax - yearly;
            double monthly = netYear / 12;
            double weekly = netYear / 52;
            lblYearlyPay.Text = netYear.ToString();
            lblMonthlyPay.Text = monthly.ToString();
            lblWeeklyPay.Text = weekly.ToString();
            chkScotYes.Checked = false;
        }
        else if (minTax >= 150001)
        {
            double netYear;
            double yearly = minTax - 12500;//This is the taxable amount
            yearly = yearly * 0.46;
            netYear = minTax - yearly;
            double monthly = netYear / 12;
            double weekly = netYear / 52;
            lblYearlyPay.Text = netYear.ToString();
            lblMonthlyPay.Text = monthly.ToString();
            lblWeeklyPay.Text = weekly.ToString();
            chkScotYes.Checked = false;
        }
        #endregion
        else
        {
            lblYearlyPay.Text = "Please enter a valid number";
        }
    }

    public void nationalInsurance()
    {
        double minTax;
        minTax = System.Convert.ToDouble(lblHidden.Text);   //This is one years pay
        double weekpay;
        double middlePay;
        double middleAmount;
        double overallAmount;
        double takenAmount;
        weekpay = minTax / 52;
        if (weekpay<= 166)
        {
            lblNatinalInsurance.Text = weekpay.ToString();
        }
        else if(weekpay >=167 && weekpay <= 962)
        {
            weekpay = weekpay * 0.12;
            lblNatinalInsurance.Text = weekpay.ToString();
            //middleAmount = weekpay;
        }
        else if(weekpay >= 963)
        {
            middlePay = 962 * 0.12;
            lblHidden2.Text = middlePay.ToString();
            takenAmount = weekpay - 962;
            middleAmount = takenAmount * 0.02;
            overallAmount = middlePay + middleAmount;
            lblNatinalInsurance.Text = overallAmount.ToString();
        }
        else
        {
            lblNatinalInsurance.Text = "Enter a number";
        }
        
    }

    
    protected void chkHour_CheckedChanged(object sender, EventArgs e)
    {
        //hourlyPay();
    }

    protected void chkDay_CheckedChanged(object sender, EventArgs e)
    {
        //dailyPay();
    }

    protected void chkWeek_CheckedChanged(object sender, EventArgs e)
    {
        //weeklyPay();
    }

    protected void chkMonth_CheckedChanged(object sender, EventArgs e)
    {
        //monthlyPay();
    }

    protected void chkYear_CheckedChanged(object sender, EventArgs e)
    { 
        //yearlyPay();
    }

    protected void chkPensionYes_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void chkScotYes_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Home.aspx");
    }
}