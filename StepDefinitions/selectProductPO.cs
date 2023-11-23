using OpenQA.Selenium;
using Pages;
using TechTalk.SpecFlow;

namespace MyNamespace
{
[Binding] //Marcação que será utilizado SpecFlow
public class SelectProductPO

{
        //Atributos/ Objetos
        private readonly ScenarioContext _scenarioContext; //readonly(somente leitura) não pode ser alterado
        private IWebDriver driver; //Objeto do selenium

        // Declarando as Classes das páginas de mapeamento
        private LoginPage loginPage; //Classe pai   classe filho
        private CommonPage commonPage;
        private InventoryPage inventoryPage;
        private CartPage cartPage;

        // Construtor
        public SelectProductPO(ScenarioContext scenarioContext)
        {
                _scenarioContext = scenarioContext; // scenario interno recebe scenario externo
                driver = (IWebDriver) _scenarioContext["driver"];
        }

       
        // Dado que acesso a pagina inicial do site PO
        [Given(@"que acesso a pagina inicial do site PO")]
        public void GivenQueAcessoAPaginaInicialDoSitePO()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        // Quando preencho o usuario como "visual_user" PO
        [When(@"preencho o usuario como ""(.*)"" PO")]
        public void WhenPreenchoOUsuarioComoPO(string usuario)
        {
            loginPage = new LoginPage(driver); //instanciamos a classe de login
            loginPage.PreencherUsuario(usuario);
        }

        // E a senha "secret_sauce" e clico no botão Login PO
        [When(@"a senha ""(.*)"" e clico no botão Login PO")]
        public void WhenASenhaEClicoNoBotaoLoginPO(string senha)
        {
            loginPage.PreencherSenha(senha);
            loginPage.ClicarNoBotaoLogin();
        }

        // Então exibe "Products" no titulo da secao PO
        [Then(@"exibe ""(.*)"" no titulo da secao PO")]
        public void ThenExibeNoTituloDaSecaoPO(string tituloSecao)
        {
            inventoryPage = new InventoryPage(driver); //instanciou InventoryPage
            Assert.That(inventoryPage.LerTituloDaSecao(), Is.EqualTo(tituloSecao));
        }

        // Quando adiciono o produto "Sauce Labs Bike Light"  ao carrinho PO
        [When(@"adiciono o produto ""(.*)""  ao carrinho PO")]
        public void WhenAdicionoOProdutoAoCarrinhoPO(string produto)
        {
            inventoryPage.AdicionarAoCarrinho(produto);
        }

        //E clico no icone do carriho de compra PO
        [When(@"clico no icone do carriho de compra PO")]
        public void WhenClicoNoIconeDoCarrihoDeCompraPO()
        {
            inventoryPage.IrParaOCarrinho();
        }

        //Então exibe a pagina do carrinho com a quantidade "1" PO
        [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)"" PO")]
        public void ThenExibeAPaginaDoCarrinhoComAQuantidadePO(string quantidade)
        {
            cartPage = new CartPage(driver); // instancia cartpage
            Assert.That(cartPage.LerQuantidade(), Is.EqualTo(quantidade));
        }

        //E nome do produto "Sauce Labs Bike Light" PO
        [Then(@"nome do produto ""(.*)"" PO")]
        public void ThenNomeDoProdutoPO(string produto)
        {
            Assert.That(cartPage.LerTituloProduto(), Is.EqualTo(produto));
        }

        //E o preco como "$9.99" PO
        [Then(@"o preco como ""(.*)"" PO")]
        public void ThenOPrecoComoPO(string preco)
        {
            Assert.That(cartPage.LerPreco(), Is.EqualTo(preco));
        }

    }

}