namespace MyNamespace
{
public class SelectProductPO

{
// Dado que acesso a pagina inicial do site PO

        [Given(@"que acesso a pagina inicial do site PO")]
        public void GivenQueAcessoAPaginaInicialDoSitePO()
        {
            _scenarioContext.Pending();
        }

// Quando preencho o usuario como "visual_user" PO

        [When(@"preencho o usuario como ""(.*)"" PO")]
        public void WhenPreenchoOUsuarioComoPO(string p0)
        {
            _scenarioContext.Pending();
        }

// E a senha "secret_sauce" e clico no botão Login PO

        [When(@"a senha ""(.*)"" e clico no botão Login PO")]
        public void WhenASenhaEClicoNoBotaoLoginPO(string p0)
        {
            _scenarioContext.Pending();
        }

// Então exibe "Products" no titulo da secao PO

        [Then(@"exibe ""(.*)"" no titulo da secao PO")]
        public void ThenExibeNoTituloDaSecaoPO(string products0)
        {
            _scenarioContext.Pending();
        }

// Quando adiciono o produto "Sauce Labs Bike Light"  ao carrinho PO

        [When(@"adiciono o produto ""(.*)""  ao carrinho PO")]
        public void WhenAdicionoOProdutoAoCarrinhoPO(string p0)
        {
            _scenarioContext.Pending();
        }

//E clico no icone do carriho de compra PO

        [When(@"clico no icone do carriho de compra PO")]
        public void WhenClicoNoIconeDoCarrihoDeCompraPO()
        {
            _scenarioContext.Pending();
        }

//Então exibe a pagina do carrinho com a quantidade "1" PO
        [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)"" PO")]
        public void ThenExibeAPaginaDoCarrinhoComAQuantidadePO(string p0)
        {
            _scenarioContext.Pending();
        }

//E nome do produto "Sauce Labs Bike Light" PO
        [Then(@"nome do produto ""(.*)"" PO")]
        public void ThenNomeDoProdutoPO(string p0)
        {
            _scenarioContext.Pending();
        }

//E o preco como "$9.99" PO
        [Then(@"o preco como ""(.*)"" PO")]
        public void ThenOPrecoComoPO(string p0)
        {
            _scenarioContext.Pending();
        }

    }

}