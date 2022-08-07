

# 11.2 Funcionalidades do Sistema
 
# 11.2.1 Estruturas de dados utilizadas
 
As estruturas utilizadas são diversas, desde as geradas pelo framework ASP NET.CORE MVC, ate as próprias criadas pelo autores 

**Funções (Métodos) sem retorno** 

São algumas funções internas do models na aplicação aonde estão presentes as entidades como Carteira, Usuário, Produto e Troca. Alguns métodos internos desses objetos fazem operações específicas, como por exemplo o método de “Receber” da carteira aceita como argumento um valor a ser depositado quando o método é chamado, que retorna void. 

**Funções (Métodos) Com retorno** 

É a estrutura mais presente no projeto. Sua maior presença esta nos controllers dos modelos. Estas funções realizam os seguintes procedimentos: 
1Mapeia os valores digitados em um formulário nas views em forma de argumento, estes passados para as funções Create, Edit, Details e Relatório. Para que os procedimentos internos da função possam realizar as etapas necessárias para o funcionamento correto do controller correspondente, também esta presente nos mé-todos que são responsáveis por criar um Objeto dentro de outra instância, estas funções porém retornando Objetos. 
Dessa forma após a chamada da função dos controllers, e sua correta execução, é retornada pela função uma view para navegação posterior no sistema ou é retornado o resultado de not found, caso a execução da função não tenha sucedi-do. 

**Listas**

Presente no controller para armazenar diferentes tipos de valores, nas etapas que exigem que o usuário selecione diferentes tipos de roupas, por exemplo, em um “catálogo” fornecido por um select list, afim que os valores armazenados na lista possam ser usados para identificar os valores da lista nos valores que estão presentes no banco de dados 

# 11.2.2 Telas de funcionalidades

**Tela inicial** 
Com o menu de busca da aplicação, botão para cadastro de novo usuário e opção de entrar, caso já tenha sido cadastrado.
![tela_inicial_bb.jpg](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t2-babybay/blob/main/docs/img/tela_inicial_bb.jpg)
 

Figura 51 - Tela inicial

**Criar Novo Usuário** 
Nessa tela é possível cadastrar-se na aplicação ao preencher devidamente os dados solicitados.

 
![criarnovousuario.jpg](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t2-babybay/blob/main/docs/img/criarnovousuario.jpg)
Figura 52 - Tela Criar novo usuário

**Tela Login**
Aqui fazemos o login na aplicação.
  ![telaloginn.jpg](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t2-babybay/blob/main/docs/img/telaloginn.jpg)

Figura 53 - Tela Login 

**Tela de busca logado**
Tela inicial após o login do usuário com o menu de busca. No canto superior direto tem-se o nome do usuário e a opção de sair.

 ![telabuscalogado.jpg](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t2-babybay/blob/main/docs/img/telabuscalogado.jpg)

Figura 54 - Tela de busca logado

**Tela Detalhes de usuário**
Nessa tela que será o Menu de usuário, temos as informações pessoais e opções de cadastrar nova roupa e buscar roupas cadastradas.

  ![teladetalhesusuario.jpg](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t2-babybay/blob/main/docs/img/teladetalhesusuario.jpg)

Figura 55 - Tela Detalhes de usuário

**Tela Busca por roupa do usuário**
Guarda-Roupa do usuário.

  ![buscaroupadouser.jpg](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t2-babybay/blob/main/docs/img/buscaroupadouser.jpg)

Figura 56 - Busca por roupa do usuário

**Tela “Nova postagem”**
Formulário de cadastro de produtos.
  ![cadastrodeprodutos.tif.jpg](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t2-babybay/blob/main/docs/img/cadastrodeprodutos.tif.jpg)

Figura 57 - Tela Cadastro de Produtos

**Tela “Meu Guarda-Roupa”**
Espaço que contém as peças cadastradas na aplicação.

  ![meuguardaroupaaa.png](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t2-babybay/blob/main/docs/img/meuguardaroupaaa.png)

Figura 58 - Tela Cadastro de Produtos

**Tela “Anúncios de Usuário”**
Lista de anúncios do usuário.

 ![anunciosdeuser.png](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t2-babybay/blob/main/docs/img/anunciosdeuser.png)

Figura 59 - Tela “Anúncios de Usuário”

**Tela “Retorno da Busca”**
Retorna o resultado da busca feita pelo usuário de acordo com seus filtros.

  ![retornodabusca.png](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t2-babybay/blob/main/docs/img/retornodabusca.png)

Figura 60 - Tela “Retorno da Busca”


**Tela “Anunciar um Produto”**
Formulário para gerar anúncio.
	
	 
 ![anunciarumprodutoo.png](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t2-babybay/blob/main/docs/img/anunciarumprodutoo.png)
Figura 61 - Tela “Anunciar um Produto”
