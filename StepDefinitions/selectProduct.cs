using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MyNamespace
{
    [Binding]

    public class StepDefinitions{

        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver; //objeto do Selenium
      
        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetUp()
        {
            //Instanciando o Chrome driver através do webDriverManager
            new DriverManager().SetUpDriver(new ChromeConfig());
            //Instanciou o SeLenium como Chrome
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10000);
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
            //Encerra o Chrome - finaliza
        {
            driver.Quit();
        }

        [Given(@"que acesso a pagina inicial do site")]
        public void GivenQueAcessoAPaginaInicialDoSite()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

/*Quando preencho o usuario como "standard_user"*/
        [When(@"preencho o usuario como ""(.*)""")]
        public void WhenPreenchoOUsuarioComo(string username)
        {
           driver.FindElement(By.Id("user-name")).SendKeys(username);
        }

/*And a senha "secret_sauce" e clico no botão Login*/
        [When(@"a senha ""(.*)"" e clico no botão Login")]
        public void WhenASenhaEClicoNoBotaoLogin(string password)
        {
            //Entrar no site e digitar a senha - pegar id no inspecionar
            driver.FindElement(By.Id("password")).SendKeys(password);
            //clicar no botão login
            driver.FindElement(By.Id("login-button")).Click();
        }

/*\Então exibe "Products" no titulo da secao*/
        [Then(@"exibe ""(.*)"" no titulo da secao")]
        public void ThenExibeNoTituloDaSecao(string title)
        {
            //Espera explicita pelo elemento span.title ser carregado na página
            WebDriverWait wait= new WebDriverWait(driver, TimeSpan.FromMilliseconds(3000));
            wait.Until(d => driver.FindElement(By.CssSelector("span.title")).Displayed);
            Assert.That(driver.FindElement(By.CssSelector("span.title")).Text,
                                             Is.EqualTo(title));
        }

/*Quando adiciono o produto "Sauce Labs Backpack" ao carrinho*/
        [When(@"adiciono o produto ""(.*)"" ao carrinho")]
        public void WhenAdicionoOProdutoAoCarrinho(string product)
        {
           String productSelector = "add-to-cart-" + product.ToLower().Replace(" ","-");
           Console.WriteLine($" Seletor de Produto = {productSelector}");
           //id da mochila: add-to-cart-sauce-labs-backpack
           //id da lanterna: add-to-cart-sauce-labs-bolt-t-shirt
           //O nome do produto vem do arquivo .feature = Sauce Labs
           //O texto vem com as maisculas e o id minuscula e com hifens
           //Sauce Labs Backpack --> ToLower() --> sauce labs backpack
           //Replace troca espaço por - 

           driver.FindElement(By.Id(productSelector)).Click();
        }

/*And clico no icone do carriho de compra*/
        [When(@"clico no icone do carriho de compra")]
        public void WhenClicoNoIconeDoCarrihoDeCompra()
        {
           driver.FindElement(By.Id("shopping_cart_container")).Click();
        }

/*Então exibe a pagina do carrinho com a quantidade "1"*/
        [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)""")]
        public void ThenExibeAPaginaDoCarrinhoComAQuantidade(string quantity)
        {
            Assert.That(driver.FindElement(By.CssSelector("div.cart_quantity")).Text,
                                           Is.EqualTo(quantity));
        }

/*And nome do produto "Sauce Labs Backpack"*/
        [Then(@"nome do produto ""(.*)""")]
        public void ThenNomeDoProduto(string nameproduct)
        {
            Assert.That(driver.FindElement(By.CssSelector("div.inventory_item_name")).Text,
                                            Is.EqualTo(nameproduct));
        }

/*And o preco como "$29.99"*/
        [Then(@"o preco como ""(.*)""")]
        public void ThenOPrecoComo(string priceproduct)
        {
            Assert.That(driver.FindElement(By.CssSelector("div.inventory_item_price")).Text,
                                            Is.EqualTo(priceproduct));
        }
            }
                  }