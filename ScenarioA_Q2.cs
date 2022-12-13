using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Quiz4_DaniyalRaza
{
    [TestClass]
    public class ScenarioA_Q2
    {
        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\DELL\source\repos\Quiz4_DaniyalRaza\WebsiteData.xml", "login1", DataAccessMethod.Sequential)]
        public void Login_Using_XML_VU_VP()
        {
            IWebDriver loginXML = new ChromeDriver();
            loginXML.Url = "https://student.qualityobe.com/";
            loginXML.FindElement(By.XPath("//input[@id = 'loginformstudent-username' and @name = 'LoginFormStudent[username]']")).SendKeys(TestContext.DataRow[0].ToString());
            loginXML.FindElement(By.XPath("//input[@id = 'loginformstudent-password' and @name = 'LoginFormStudent[password]']")).SendKeys(TestContext.DataRow[1].ToString());
            loginXML.FindElement(By.XPath("//button[@class = 'btn btn-primary' and text() = 'Login']")).Click();
            Thread.Sleep(2000);
            loginXML.Quit();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\DELL\source\repos\Quiz4_DaniyalRaza\WebsiteData.xml", "login2", DataAccessMethod.Sequential)]
        public void Login_Using_VU_IP()
        {
            IWebDriver loginXML1 = new ChromeDriver();
            loginXML1.Url = "https://student.qualityobe.com/";
            loginXML1.FindElement(By.XPath("//input[@id = 'loginformstudent-username' and @name = 'LoginFormStudent[username]']")).SendKeys(TestContext.DataRow[0].ToString());
            loginXML1.FindElement(By.XPath("//input[@id = 'loginformstudent-password' and @name = 'LoginFormStudent[password]']")).SendKeys(TestContext.DataRow[1].ToString());
            loginXML1.FindElement(By.XPath("//button[@class = 'btn btn-primary' and text() = 'Login']")).Click();
            Thread.Sleep(2000);
            loginXML1.Quit();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\DELL\source\repos\Quiz4_DaniyalRaza\WebsiteData.xml", "login3", DataAccessMethod.Sequential)]
        public void Login_Using_IU_VP()
        {
            IWebDriver loginXML1 = new ChromeDriver();
            loginXML1.Url = "https://student.qualityobe.com/";
            loginXML1.FindElement(By.XPath("//input[@id = 'loginformstudent-username' and @name = 'LoginFormStudent[username]']")).SendKeys(TestContext.DataRow[0].ToString());
            loginXML1.FindElement(By.XPath("//input[@id = 'loginformstudent-password' and @name = 'LoginFormStudent[password]']")).SendKeys(TestContext.DataRow[1].ToString());
            loginXML1.FindElement(By.XPath("//button[@class = 'btn btn-primary' and text() = 'Login']")).Click();
            Thread.Sleep(2000);
            loginXML1.Quit();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\DELL\source\repos\Quiz4_DaniyalRaza\WebsiteData.xml", "login4", DataAccessMethod.Sequential)]
        public void Login_Using_IU_IP()
        {
            IWebDriver loginXML1 = new ChromeDriver();
            loginXML1.Url = "https://student.qualityobe.com/";
            loginXML1.FindElement(By.XPath("//input[@id = 'loginformstudent-username' and @name = 'LoginFormStudent[username]']")).SendKeys(TestContext.DataRow[0].ToString());
            loginXML1.FindElement(By.XPath("//input[@id = 'loginformstudent-password' and @name = 'LoginFormStudent[password]']")).SendKeys(TestContext.DataRow[1].ToString());
            loginXML1.FindElement(By.XPath("//button[@class = 'btn btn-primary' and text() = 'Login']")).Click();
            Thread.Sleep(2000);
            loginXML1.Quit();
        }
    }
}
