//Bibliotecas
using OpenQA.Selenium;

//NameSpace
namespace Pages
{
    
//Classe
    public class LoginPage : CommonPage
    {
   //Atributos
        //Mapeamento dos elementos
        private IWebElement txtUsuario => driver.FindElement(By.Id("usar-name"));
        private IWebElement txtSenha => driver.FindElement(By.Id("password"));
        private IWebElement btnLogin => driver.FindElement(By.Id("login-button"));


   //Metódos e Funções
        //Construtor
        public LoginPage(IWebDriver driver) : base(driver) { }

        //Ações a serem usadas na automação
        public void PreencherUsuarioESenha(String usuario, String senha)
        {
            txtUsuario.SendKeys(usuario);
            txtSenha.SendKeys(senha);
        }

        public void ClicarNoBotaoLogin()
        {
            btnLogin.Click();
        }

        public void DarEnter()
        {
            txtSenha.SendKeys(Keys.Enter);
        }
    }
}