using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Project2
{
    public class Calc
    {
        IWebDriver drw;
        [SetUp]
        public void Setup()
        {
            drw = new ChromeDriver();
            drw.Url = "https://www.globalsqa.com/angularJs-protractor/SimpleCalculator/";
        }
        [TearDown]
        public void TearDown()
        {
            drw.Quit();
        }

        [Test]
        public void OneAddZero()
        {
            var x = new Calcul(drw);
            x.Clics_inca();
            Assert.That(x.Resault(), Is.EqualTo("1 + 0 = 1"));
        }
        [Test]
        public void MinusOneAddZero()
        {
            var x = new Calcul(drw);
            x.Clics_deca();
            Assert.That(x.Resault(), Is.EqualTo("-1 + 0 = -1"));
        }
        [Test]
        public void ZeroAddOne()
        {
            var x = new Calcul(drw);
            x.Clics_incb();
            Assert.That(x.Resault(), Is.EqualTo("0 + 1 = 1"));
        }
        [Test]
        public void ZeroAddMinusOne()
        {
            var x = new Calcul(drw);
            x.Clics_decb();
            Assert.That(x.Resault(), Is.EqualTo("0 + -1 = -1"));
        }
        [Test]
        public void NullAddZero()
        {
            var x = new Calcul(drw);
            x.AddDataA("fff");
            Assert.That(x.Resault(), Is.EqualTo("null + 0 = null"));
        }
        [Test]
        public void ZeroAddNull()
        {
            var x = new Calcul(drw);
            x.AddDataB("fff");
            Assert.That(x.Resault(), Is.EqualTo("0 + null = null"));
        }
        [Test]
        public void OneSubZero()
        {
            var x = new Calcul(drw);
            x.ChangeOperation1();
            x.Clics_inca();
            Assert.That(x.Resault(), Is.EqualTo("1 - 0 = 1"));
        }
        [Test]
        public void OneMultiZero()
        {
            var x = new Calcul(drw);
            x.ChangeOperation2();
            x.Clics_inca();
            Assert.That(x.Resault(), Is.EqualTo("1 * 0 = 0"));
        }
        [Test]
        public void OneDivZero()
        {
            var x = new Calcul(drw);
            x.ChangeOperation3();
            x.Clics_inca();
            Assert.That(x.Resault(), Is.EqualTo("1 / 0 = null"));
        }
    }
}