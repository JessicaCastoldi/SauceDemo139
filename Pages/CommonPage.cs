using OpenQA.Selenium;

namespace Pages
{
    public class CommonPage
    {
        //Atributos
        protected IWebDriver driver;

        //Mapeamento dos elementos comuns a duas ou mais telas
        private IWebElement lblTituloSecao => driver.FindElement(By.CssSelector("span.title"));
        private IWebElement icoCarrinho => driver.FindElement(By.CssSelector("a.shopping_cart_link"));

        //Métodos e Funções
        //Construtor  // Selenium que tem dentro dele se comunica com o selenium de fora, 
        //permite que os arquivos se comuniquem se confusão
        public CommonPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}