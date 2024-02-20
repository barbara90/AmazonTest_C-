// See https://aka.ms/new-console-template for more informationusin

using System.Runtime.InteropServices.JavaScript;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


class AmazonTest
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        String loginMenu = new String("nav-link-accountList");
        driver.Url = "https://www.amazon.de/-/en/ref=nav_logo"; 
        driver.FindElement(By.Id(loginMenu)).Click();
 
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        wait.PollingInterval = TimeSpan.FromMilliseconds(200);
        wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ap_email"))).SendKeys("olah.barbara.1990@gmail.com");
        driver.FindElement(By.Id("continue")).Click();

        
    }
}

