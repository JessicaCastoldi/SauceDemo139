Feature: Selecionar Produto na Loja
@Compra
    Scenario: Selecao de Produto com Sucesso
        Given que acesso a pagina inicial do site
        When preencho o usuario como "standard_user"
        And a senha "secret_sauce" e clico no botão Login
        Then exibe "Products" no titulo da secao
        When adiciono o produto "Sauce Labs Backpack" ao carrinho
        And clico no icone do carriho de compra
        Then exibe a pagina do carrinho com a quantidade "1"
        And nome do produto "Sauce Labs Backpack"
        And o preco como "$29.99"

      