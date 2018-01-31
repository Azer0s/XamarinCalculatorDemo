using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
	public partial class MainPage : ContentPage
	{
	    public MainPage()
	    {
	        InitializeComponent();
	    }

	    private List<string> calculation = new List<string>();

	    public void NumberButtonPressed(object sender, EventArgs e)
	    {
	        if (resultText.Text == "0")
	        {
	            resultText.Text = string.Empty;
	        }

	        resultText.Text += ((Button)sender).Text;
	    }

	    public void Reset(object sender, EventArgs e)
	    {
	        resultText.Text = "0";
	        calculation = new List<string>();
	    }

	    public void AddOperator(object sender, EventArgs e)
	    {
	        calculation.Add(resultText.Text);
	        calculation.Add(((Button)sender).Text);
	        resultText.Text = "0";
	    }

	    public async void Calculate(object sender, EventArgs e)
	    {
	        calculation.Add(resultText.Text);
	        resultText.Text = await Task.Run(()=>Calculator.Calculate(calculation));
	        calculation = new List<string>();
	    }
    }
}
