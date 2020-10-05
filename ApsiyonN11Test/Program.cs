using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApsiyonN11Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.n11.com/");

            driver.FindElement(By.ClassName("btnHolder")).Click();

            driver.FindElement(By.ClassName("btnSignIn")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("email")).SendKeys("sekoyilmaz14@hotmail.com");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("password")).SendKeys("apsiyontest3");
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Id("loginButton")).Click();
            System.Threading.Thread.Sleep(2000);

            driver.Navigate().GoToUrl("https://www.n11.com/");

            driver.FindElement(By.Id("searchData")).SendKeys("Samsung");
            driver.FindElement(By.ClassName("searchBtn")).Click();
            System.Threading.Thread.Sleep(10000);
            Console.WriteLine("Samsung için çıkan sonuçlar");
            System.Threading.Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
