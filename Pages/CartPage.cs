using OpenQA.Selenium;

namespace Pages
{
    public class CartPage : CommonPage
    {
        //Mapeamento
        private IWebElement lblQuantidade => driver.FindElement(By.CssSelector("div.cart_quantity"));
        private IWebElement lblTituloProduto => driver.FindElement(By.CssSelector("div.inventory_item_name"));
        private IWebElement lblPreco => driver.FindElement(By.CssSelector("div.inventory_item_price"));
      
        //Construtor
        public CartPage(IWebDriver driver) : base(driver){}  //ctor atalho, monta base do construtor

        //Ações
        public String LerQuantidade()
        {
            return lblQuantidade.Text;
        }

        public String LerTituloProduto()
        {
           return lblTituloProduto.Text;
        }

        public String LerPreco()
        {
            return lblPreco.Text;
        }


    }
}