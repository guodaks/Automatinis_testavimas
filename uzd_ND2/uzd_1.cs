﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzd_ND2
{
    public class uzd_1
    {
        public static IWebDriver _driver;

        [Test]
        public static void TestChrome()
        {
            _driver = new ChromeDriver();
            _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            string result = "Chrome 95 on Windows 10";
            IWebElement resultFromPage = _driver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.AreEqual(result, resultFromPage.Text, "Displayed text is not \"Chrome 95 on Windows 10\"");
        }

        [Test]
        public static void TestFirefox()
        {
            _driver = new FirefoxDriver();
            _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            string result = "Firefox 94 on Windows 10";
            IWebElement resultFromPage = _driver.FindElement(By.CssSelector("#primary-detection > div"));
            Assert.AreEqual(result, resultFromPage.Text, "Displayed text is not \"Firefox 94 on Windows 10\"");
        }
    }
}
