using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Web_Scraper;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Driver_Test()
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.google.com");
        //driver.Manage().Window.Maximize();
        IWebElement searchField = driver.FindElement(By.Id("input"));
        searchField.SendKeys("YouTube");
        searchField.SendKeys(Keys.Return);
        //searchField.Click();

        Console.WriteLine();
        Assert.Pass();
    }

    [TearDown]
    public void TearDown()
    {
        // Mr. C# function, tear down ???
    }
}