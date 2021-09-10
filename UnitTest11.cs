using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Support.UI;
using System;

namespace NUnitTest
{
    [TestFixture]
    public class Test
    {
        IWebDriver  driver = new ChromeDriver(@"C:\NUnitTest\chromedriver_win32");        

        [SetUp]
        public void Setup()
        {                     
         driver.Navigate().GoToUrl("https://tauria.com/signin");                
         driver.Manage().Window.Maximize();   
        }    
 [Test]
public void Register()
        {   string BuisnessName= "";   
            string LastName = "CHIWNUBA";
            string firstName ="NNAEMEKA";
            string Email ="chinwubannaemeka2015@gmail.com";
            string Pwrd = "Tauria$101";
            string Conpwd ="Tauria$101";

            var Button = driver.FindElement(By.XPath("//button[@color='#0a1e51']"));
            Button.Click();
            driver.FindElement(By.Id("name")).SendKeys(BuisnessName);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(700);
            var nextbutton = driver.FindElement(By.XPath("//button[@width='100%']"));
            nextbutton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(900);
            driver.FindElement(By.Id("first")).SendKeys(firstName);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(800);
            driver.FindElement(By.Id("last")).SendKeys(LastName);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
            driver.FindElement(By.Id("email")).SendKeys(Email);            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(500);
            driver.FindElement(By.XPath("//button[@width='100%']")).Click();            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(600);
            driver.FindElement(By.Id("password")).SendKeys(Pwrd);
            driver.FindElement(By.Id("confirm")).SendKeys(Conpwd);            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(600);
            driver.FindElement(By.XPath("//button[@width='100%']")).Click();             
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1200); 
            driver.FindElement(By.ClassName("ZebuMailOnboardingContainer"));
            driver.FindElement(By.XPath("//div[@class='OnboardingChoice']"));
            var Teamhub = driver.FindElement(By.XPath("//div[@class='OnboardingChoice-title']")).Text; 
            Assert.AreEqual(Teamhub, "What would you like to start?");
 }

[Test]
public void SignIn()
{
 driver.FindElement(By.Id("email")).SendKeys("ifyokay@yahoo.com");
 driver.FindElement(By.Id("password")).SendKeys("Testing00");
 driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(600);
 driver.FindElement(By.XPath("//button[@width='100%']")).Click();  
 driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1200); 
driver.FindElement(By.ClassName("ZebuMailOnboardingContainer"));
driver.FindElement(By.XPath("//div[@class='OnboardingChoice']"));
var Cont = driver.FindElement(By.XPath("//div[@class='OnboardingChoice-title']"));

}

[TearDown]
public void TearDown()
{
driver.Quit();
}

  }  
}