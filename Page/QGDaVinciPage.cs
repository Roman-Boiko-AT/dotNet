﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Tests.Framework.Core;

namespace Pages
{
    public class QGDaVinciPage : Tests.Framework.Templates.PageObject.Page
    {
        [FindsBy(How = How.XPath, Using = ".//*[contains(@class,'fio input-records')]")]
        public IWebElement NameTextField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@class,'input-records email gray')]")]
        public IWebElement EmailTextField { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[contains(@class,'input-records telephone gray')]")]
        public IWebElement PhoneNumberTextField { get; set; }

        [FindsBy(How = How.Id, Using = "recording")]
        public IWebElement BookQuestButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//div[@id='rating-successful']//div[contains(.,'Запись на квест прошла успешно.')]/p")]
        public IWebElement MessageText { get; set; }

        public IWebElement CellWithBookDateAndTime(string date, string time)
        {
            return Driver.Browser.FindElement(By.XPath($".//a[contains(.,'{time}') and contains(@data-full-date,'{date}')]"));
        }
    }
}