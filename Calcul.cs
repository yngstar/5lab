using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Project2
{
    internal class Calcul
    {
        IWebDriver drw;
        private By buttoninca = By.XPath("//button[@ng-click='inca()']");
        private By buttondeca = By.XPath("//button[@ng-click='deca()']");
        private By buttonincb = By.XPath("//button[@ng-click='incb()']");
        private By buttondecb = By.XPath("//button[@ng-click='decb()']");

        private By lable_ = By.CssSelector(".result.ng-binding");

        private By fielda = By.XPath("//input[@ng-model='a']");
        private By fieldb = By.XPath("//input[@ng-model='b']");

        private By operatormns = By.XPath("//select[@class='ng-pristine ng-valid']/option[@value='-']");
        private By operatorumn = By.XPath("//select[@class='ng-pristine ng-valid']/option[@value='*']");
        private By operatordel = By.XPath("//select[@class='ng-pristine ng-valid']/option[@value='/']");


        public Calcul(IWebDriver driwe)
        {
            drw = driwe;
        }

        public void Clics_inca()
        {
            IWebElement button_inca = drw.FindElement(buttoninca);
            button_inca.Click();
        }
        public void Clics_deca()
        {
            IWebElement button_deca = drw.FindElement(buttondeca);
            button_deca.Click();
        }
        public void Clics_incb()
        {
            IWebElement button_incb = drw.FindElement(buttonincb);
            button_incb.Click();
        }
        public void Clics_decb()
        {
            IWebElement button_decb = drw.FindElement(buttondecb);
            button_decb.Click();
        }

        public void AddDataA(string s)
        {
            IWebElement text_a = drw.FindElement(fielda);
            text_a.Clear();
            text_a.SendKeys(s);
        }

        public void AddDataB(string s)
        {
            IWebElement text_b = drw.FindElement(fieldb);
            text_b.Clear();
            text_b.SendKeys(s);
        }

        public string Resault()
        {
            IWebElement lable = drw.FindElement(lable_);
            return lable.Text;
        }

        public void ChangeOperation1()
        {
            IWebElement operator_mn = drw.FindElement(operatormns);
            operator_mn.Click();
            Thread.Sleep(1500);
        }

        public void ChangeOperation2()
        {
            IWebElement operator_pm = drw.FindElement(operatorumn);
            operator_pm.Click();
            Thread.Sleep(1500);
        }

        public void ChangeOperation3()
        {
            IWebElement operator_de = drw.FindElement(operatordel);
            operator_de.Click();
            Thread.Sleep(1500);
        }
    }
}