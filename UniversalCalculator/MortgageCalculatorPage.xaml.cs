using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MortgageCalculatorPage : Page
	{
		public MortgageCalculatorPage()
		{
			this.InitializeComponent();
		}
		private void CalculateButton_Click(object sender, RoutedEventArgs e)
		{

			double principal = double.Parse(PrincipalTextBox.Text);
			int years = int.Parse(YearsTextBox.Text);
			int months = int.Parse(MonthsTextBox.Text);
			int totalmonths = years * 12 + months;
			double yearlyInterestRate = double.Parse(InterestRateTextBox.Text);
			double monthlyInterestRate = yearlyInterestRate / 12 / 100;
			double monthlyRepayment = principal * (monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, totalmonths)) / (Math.Pow(1 + monthlyInterestRate, totalmonths) - 1);
			MonthlyInterestTextBox.Text = monthlyInterestRate.ToString("P2");
			MonthlyRepaymentTextBox.Text = monthlyRepayment.ToString("C2");
		}

		private void ExitButton_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainMenu));
	
		}

	}
}