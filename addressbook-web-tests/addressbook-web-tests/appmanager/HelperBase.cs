﻿using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected IWebDriver driver;

        public HelperBase (ApplicationManager manager)
        {
            this.manager = manager;
            driver = manager.Driver;
        }

        public void Type(By locator, string text)
        {
            if (text != null)
            {
                driver.FindElement(locator).Clear();
                driver.FindElement(locator).SendKeys(text);
            }
        }

        public bool isElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch(NoSuchElementException)
            {
                return false;
            }
        }
    }
}