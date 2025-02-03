using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Exercise1
{
    internal class Program
    {
        public static double ConvertToUSD(double amount, string fromCurrency)
        {
            if (fromCurrency == "EUR") return amount * 1.1; // EUR to USD conversion
            if (fromCurrency == "JPY") return amount * 0.007; // JPY to USD conversion
            return amount; // Return if already USD
        }

        // Convert amount to EUR currency
        public static double ConvertToEUR(double amount, string fromCurrency)
        {
            if (fromCurrency == "USD") return amount * 0.91; // USD to EUR conversion
            if (fromCurrency == "JPY") return amount * 0.0064; // JPY to EUR conversion
            return amount; // Return same if already EUR
        }

        // Convert amount to JPY currency
        public static double ConvertToJPY(double amount, string fromCurrency)
        {
            if (fromCurrency == "USD") return amount * 140.0; // USD to JPY conversion
            if (fromCurrency == "EUR") return amount * 156.25; // EUR to JPY conversion
            return amount; // Return same if already JPY
        }

        public static void Main()
        {
            Console.Write("Enter amount: "); // Ask for amount input
            double amount = Convert.ToDouble(Console.ReadLine()); // Read and convert input

            Console.Write("Enter currency (USD, EUR, JPY): "); // Ask currency type
            string fromCurrency = Console.ReadLine(); // Read currency type

            Console.Write("Convert to (USD, EUR, JPY): "); // Ask target currency
            string toCurrency = Console.ReadLine(); // Read target currency

            double convertedAmount = 0; // Store conversion result

            if (toCurrency == "USD") convertedAmount = ConvertToUSD(amount, fromCurrency); // Convert to USD
            if (toCurrency == "EUR") convertedAmount = ConvertToEUR(amount, fromCurrency); // Convert to EUR
            if (toCurrency == "JPY") convertedAmount = ConvertToJPY(amount, fromCurrency); // Convert to JPY

            Console.WriteLine("Converted Amount: " + convertedAmount + " " + toCurrency); // Display result
        }
    }
