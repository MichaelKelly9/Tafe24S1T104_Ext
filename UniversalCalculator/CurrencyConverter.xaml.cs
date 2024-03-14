using Calculator;
using System;
using System.Collections.Generic;
using System.Data;
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
	public sealed partial class CurrencyConverter : Page
	{
		public CurrencyConverter()
		{
			this.InitializeComponent();
		}


		private void conversionButton_Click(object sender, RoutedEventArgs e)
		{
			// Conversion Data Used
			//		 From			 To				Conversion Rate
			//$1.0   US Dollar		 Euro			0.85189982
			//						 British Pound	0.72872436
			//						 Indian Rupee	74.257327

			//€ 1.0  Euro			 US Dollar		1.1739732
			//						 British Pound	0.8556672
			//						 Indian Rupee   87.00755

			//£ 1.0  British		 US Dollar		1.371907
			//						 Euro			1.1686692
			//						 Indian Rupee   101.68635

			//₹ 1.0  Indian Rupee    US Dollar		0.011492628
			//						 Euro			0.013492774
			//						 British Pound  0.0098339397

			string fromcurrency = fromComboBox.SelectedIndex.ToString();
			string tocurrency = toComboBox.SelectedIndex.ToString();
			double enteredamount = double.Parse(amountTextBox.Text);

			if (fromcurrency == "0") // USD
			{
				amountequalsTextBlock.Text = enteredamount + " US Dollars =";
				switch (tocurrency)
				{
					case "0":
						convertedAmountTextBlock.Text = "$ " + enteredamount + " Dollars";
						oneFromEqualsTextBlock.Text = "1 USD = 1 USD";
						oneToEqualsTextBlock.Text = "1 USD = 1 USD";
						break;
					case "1": 
						convertedAmountTextBlock.Text = "€ " + enteredamount * 0.85189982 + " Euro";
						oneFromEqualsTextBlock.Text = "1 USD = 0.85189982 Euro";
						oneToEqualsTextBlock.Text = "1 Euro = 1.1739732 USD";
						break;
					case "2":
						convertedAmountTextBlock.Text = "£ " + enteredamount * 0.72872436 + " Pounds";
						oneFromEqualsTextBlock.Text = "1 USD = 0.72872436 British Pounds";
						oneToEqualsTextBlock.Text = "1 British Pound = 1.371907 USD";
						break;
					case "3":
						convertedAmountTextBlock.Text = "₹ " + enteredamount * 74.257327 + " Rupee";
						oneFromEqualsTextBlock.Text = "1 USD = 74.257327 Rupee";
						oneToEqualsTextBlock.Text = "1 Rupee = 0.011492628 USD";
						break;
				}
			}
			else if (fromcurrency == "1") // EUR
			{
				amountequalsTextBlock.Text = enteredamount + " Euros =";
				switch (tocurrency)
				{
					case "0":
						convertedAmountTextBlock.Text = "$ " + enteredamount * 1.1739732 + " Dollars";
						oneFromEqualsTextBlock.Text = "1 Euro = 1.1739732 USD";
						oneToEqualsTextBlock.Text = "1 USD = 0.85189982 Euro";
						break;
					case "1":
						double convertedtoeur = enteredamount;
						convertedAmountTextBlock.Text = "€ " + enteredamount + " Euro";
						oneFromEqualsTextBlock.Text = "1 Euro = 1 Euro";
						oneToEqualsTextBlock.Text = "1 Euro = 1 Euro";
						break;
					case "2":
						convertedAmountTextBlock.Text = "£ " + enteredamount * 0.8556672 + " Pounds";
						oneFromEqualsTextBlock.Text = "1 Euro = 0.8556672 British Pounds";
						oneToEqualsTextBlock.Text = "1 British Pound = 1.1686692 Euro";
						break;
					case "3":
						convertedAmountTextBlock.Text = "₹ " + enteredamount * 87.00755 + " Rupee";
						oneFromEqualsTextBlock.Text = "1 Euro = 87.00755 Rupee";
						oneToEqualsTextBlock.Text = "1 Rupee = 0.013492774 Euro";
						break;
				}
			}
			else if (fromcurrency == "2") //GBP
			{
				amountequalsTextBlock.Text = enteredamount + " British Pounds =";
				switch (tocurrency)
				{
					case "0":
						convertedAmountTextBlock.Text = "$ " + enteredamount * 1.371907 + " Dollars";
						oneFromEqualsTextBlock.Text = "1 British Pound = 1.371907 USD";
						oneToEqualsTextBlock.Text = "1 USD = 0.72872436 British Pound";
						break;
					case "1":
						double convertedtoeur = enteredamount;
						convertedAmountTextBlock.Text = "€ " + enteredamount * 1.1686692 + " Euro";
						oneFromEqualsTextBlock.Text = "1 British Pound = 1.1686692 Euro";
						oneToEqualsTextBlock.Text = "1 Euro = 0.8556672 British Pound";
						break;
					case "2":
						convertedAmountTextBlock.Text = "£ " + enteredamount + " Pounds";
						oneFromEqualsTextBlock.Text = "1 British Pound = 1 British Pound";
						oneToEqualsTextBlock.Text = "1 British Pound = 1 British Pound";
						break;
					case "3":
						convertedAmountTextBlock.Text = "₹ " + enteredamount * 101.68635 + " Rupee";
						oneFromEqualsTextBlock.Text = "1 British Pound = 101.68635 Rupee";
						oneToEqualsTextBlock.Text = "1 Rupee = 0.0098339397 British Pound";
						break;
				}
			}
			else if (fromcurrency == "3") // INR
			{
				amountequalsTextBlock.Text = enteredamount + " Rupee =";
				switch (tocurrency)
				{
					case "0":
						convertedAmountTextBlock.Text = "$ " + enteredamount * 0.011492628 + " Dollars";
						oneFromEqualsTextBlock.Text = "1 Rupee = 0.011492628 USD";
						oneToEqualsTextBlock.Text = "1 USD = 74.257327 Rupee";
						break;
					case "1":
						double convertedtoeur = enteredamount;
						convertedAmountTextBlock.Text = "€ " + enteredamount * 0.013492774 + " Euro";
						oneFromEqualsTextBlock.Text = "1 Rupee = 0.013492774 Euro";
						oneToEqualsTextBlock.Text = "1 Euro = 87.00755 Rupee";
						break;
					case "2":
						convertedAmountTextBlock.Text = "£ " + enteredamount * 0.0098339397 + " Pounds";
						oneFromEqualsTextBlock.Text = "1 Rupee = 0.0098339397 British Pound";
						oneToEqualsTextBlock.Text = "1 British Pound = 101.68635 Rupee";
						break;
					case "3":
						convertedAmountTextBlock.Text = "₹ " + enteredamount + " Rupee";
						oneFromEqualsTextBlock.Text = "1 Rupee = 1 Rupee";
						oneToEqualsTextBlock.Text = "1 Rupee = 1 Rupee";
						break;
				}
			}
		}
		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			Frame.Navigate(typeof(MainMenu));
		}
	}
}
