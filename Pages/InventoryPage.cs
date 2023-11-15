using OpenQA.Selenium;

namespace Pages
{
    public class InventoryPage : CommonPage  // : extends - utilizar o recurso da classe pai
    {
        //Mapeamento dos elementos
        //Como queremos mapear o botão "Add to card" e o id muda por produto 
        //Iremos mapear de forma dinamica pelo bloco de ações

        //Construtor
        public InventoryPage(IWebDriver driver): base(driver){}

        //Ações
        public void AdicionarAoCarrinho(String produto)
        {
            String seletorProduto = "add-to-cart" + produto.ToLower().Replace(" ","-");
            driver.FindElement(By.Id(seletorProduto)).Click();
        }

    }
}