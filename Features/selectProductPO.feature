Feature: Selecionar Produto na Loja PO
@PO
    
  Scenario Outline: Selecao de Produto com Sucesso PO
        Given que acesso a pagina inicial do site PO
        When preencho o usuario como <usuario> PO
        And a senha <senha> e clico no botão Login PO
        Then exibe <tituloSecao> no titulo da secao PO
        When adiciono o produto <produto>  ao carrinho PO
        And clico no icone do carriho de compra PO
        Then exibe a pagina do carrinho com a quantidade <quantidade> PO
        And nome do produto <produto> PO
        And o preco como <preco> PO

   Examples:
   | usuario        | senha        | tituloSecao | produto                | quantidade | preco   |
   |"standard_user" | "secret_sauce"| "Products" |"Sauce Labs Backpack"   | "1"        |"$29.99" |
   |"visual_user"   | "secret_sauce"| "Products" |"Sauce Labs Bike Light" | "1"        |"$9.99"  |


      