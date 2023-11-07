using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MyNamespace
{
    [Binding]

    public class StepDefinitions{

        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver; //objeto do Selenium

        public StepDefinitions(ScenarioContext _scenarioContext)
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
        {
            driver.Quit();
        }

        [Given(@"que acesso a pagina inicial do site")]
        public void GivenQueAcessoAPaginaInicialDoSite()
        {
            _scenarioContext.Pending();
        }

/*When preencho o usuario como "standard_user"
-> No matching step definition found for the step. Use the following code to create one:*/
        [When(@"preencho o usuario como ""(.*)""")]
        public void WhenPreenchoOUsuarioComo(string p0)
        {
            _scenarioContext.Pending();
        }

/*And a senha "secret_sauce" e clico no botão Login
-> No matching step definition found for the step. Use the following code to create one:*/
        [When(@"a senha ""(.*)"" e clico no botão Login")]
        public void WhenASenhaEClicoNoBotaoLogin(string p0)
        {
            _scenarioContext.Pending();
        }

/*Then exibe "Products" no titulo da secao
-> No matching step definition found for the step. Use the following code to create one:*/
        [Then(@"exibe ""(.*)"" no titulo da secao")]
        public void ThenExibeNoTituloDaSecao(string products)
        {
            _scenarioContext.Pending();
        }

/*When adiciono o produto "Sauce Labs Backpack" ao carrinho
-> No matching step definition found for the step. Use the following code to create one:*/
        [When(@"adiciono o produto ""(.*)"" ao carrinho")]
        public void WhenAdicionoOProdutoAoCarrinho(string p0)
        {
            _scenarioContext.Pending();
        }

/*And clico no icone do carriho de compra
-> No matching step definition found for the step. Use the following code to create one:*/
        [When(@"clico no icone do carriho de compra")]
        public void WhenClicoNoIconeDoCarrihoDeCompra()
        {
            _scenarioContext.Pending();
        }

/*Then exibe a pagina do carrinho com a quantidade "1"
-> No matching step definition found for the step. Use the following code to create one:*/
        [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)""")]
        public void ThenExibeAPaginaDoCarrinhoComAQuantidade(string p0)
        {
            _scenarioContext.Pending();
        }

/*And nome do produto "Sauce Labs Backpack"
-> No matching step definition found for the step. Use the following code to create one:*/
        [Then(@"nome do produto ""(.*)""")]
        public void ThenNomeDoProduto(string p0)
        {
            _scenarioContext.Pending();
        }

/*And o preco como "$29.99"
-> No matching step definition found for the step. Use the following code to create one:*/
        [Then(@"o preco como ""(.*)""")]
        public void ThenOPrecoComo(string p0)
        {
            _scenarioContext.Pending();
        }
            }
                  }