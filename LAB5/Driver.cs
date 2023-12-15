using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using static System.Net.WebRequestMethods;

namespace LAB5
{
    public class Driver
    {
        IWebDriver driver = new EdgeDriver();
        private IWebElement inputA;
        private IWebElement inputB;
        private IWebElement resultC;
        private SelectElement selector;
        private IWebElement select;

        public string Finder(int a, int b, string operation)
        {
            driver.Url = "https://www.globalsqa.com/angularJs-protractor/SimpleCalculator/";
            inputA = driver.FindElement(By.CssSelector("input[ng-model='a']"));
            inputB = driver.FindElement(By.CssSelector("input[ng-model='b']"));
            resultC = driver.FindElement(By.CssSelector("b[class='result ng-binding']"));
            select = driver.FindElement(By.CssSelector("select[ng-model='operation']"));

            selector = new SelectElement(select);

            inputA.Clear();
            inputB.Clear();

            inputA.SendKeys(Convert.ToString(a));
            inputB.SendKeys(Convert.ToString(b));
            selector.SelectByText(operation);

            int i = resultC.Text.IndexOf("=") + 1;
            string result = resultC.Text.Substring(i).Trim();

            driver.Quit();

            return result;

        }

        public void PrintResult() {
            string resultA = inputA.GetAttribute("value");
            string resultB = inputB.GetAttribute("value");
            string resultOper = selector.SelectedOption.Text;

            Console.WriteLine(resultA);
            Console.WriteLine(resultB);
            Console.WriteLine(resultOper);
        }
    }
}
