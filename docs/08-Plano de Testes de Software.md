# 9. Teste de Software

Os requisitos para realização dos testes de software são: 

* Site publicado na Internet;
* Navegador da Internet - Chrome, Firefox ou Edge;
* Conectividade de Internet para acesso às plataformas (APIs). 

 Os testes serão baseados na metodologia a seguir: 

* **Teste de unidade –** testa-se unidades menores de um software, de modo isolado, para ver se todas funcionam adequadamente; 

* **Teste de integração –** depois das unidades testadas, realiza-se uma verificação se elas funcionam juntas, integradas. Pode ocorrer delas apresentarem incompatibilidades ao funcionarem em conjunto, mesmo após terem sido aprovadas no teste de unidade; 


Os testes a serem realizados na aplicação são descritos a seguir:
Caso de Teste	CT-01. Cadastrar usuário no sistema (RF-1)

Objetivo	
-	Realizar o cadastro no sistema




Informações necessárias (ENTRADA)	
-	Nome de usuário
-	CPF

-	E-mail
-	Senha alfanumérica (mínimo 8 dígitos) 

-	Endereço (Rua, Número, Bairro, Cidade, Estado)



E-mail de confirmação
	
-	Um e-mail para confirmar a autenticidade de seu cadastro foi enviado para sua caixa de entrada, clique no link para confirmar.


Saída esperada
	
-	Você confirmou seu e-mail. Para realizar login entre com e-mail ou nome de usuário criado e a senha que foi criada 



Caso de Teste	CT-02. Login do usuário (RF-1)

Objetivo	
-	Realizar o login no sistema após cadastro de usuário.	

Informações necessárias (ENTRADA)	
-	Nome de usuário ou e-mail
-	Senha 	


Esqueci a senha	
-	Clique no link “Esqueci a senha” para a as instruções de redefinições serem enviadas ao e-mail cadastrado.	


Saída esperada
	
-	Com os dados de login corretos, o sistema irá redirecionar o usuário para a página principal.	



Caso de Teste	CT-03. Cadastrar produto (RF-2) / (RF-3) / (RF-4)


Objetivo	
-	Realizar o cadastro de um produto no Guarda roupa com foto.

Quais roupas serão adicionadas (ENTRADA)	
-	Blusa do exemplo babyshark.
-	Bermuda exemplo jeans infantil.

-	Adicionar descrição, categoria, idade, tamanho e gênero.

-	Adicionar 3 fotos

Quantidade de roupas
	
-	2 unidades.


Tamanho para envio de mídia disponível	

-	100mb







Saída esperada	
-	Roupas adicionadas com sucesso, para poder criar um anúncio, vá até a aba “Criar Anúncio”.

-	Um anúncio deverá ser enviado ao administrador para análise, caso de erro.

-	Mensagem na tela do usuário: “Seu anúncio será analisado em até 24h”

-	Para o administrador: Notificação de novos anúncios para avaliar.



Caso de Teste	CT-04. Excluir de produto e anúncio (RF-6)


Objetivo	
-	Realizar a exclusão de um anúncio ou produto.


Quais roupas serão excluídas (ENTRADA)	
-	Blusa exemplo babyshark
-	Bermuda exemplo jeans infantil
-	
-	Com sua descrição, categoria, idade, tamanho e gênero



Excluir produto ou anúncio
	
-	Dentro do menu “Guarda Roupa”, selecionar o produto desejado e clicar em excluir (ícone lixeira) e confirmar



Saída esperada	
-	Tem certeza que deseja excluir a roupa selecionada?

-	Para finalizar, o anunciante deve clicar em “sim”.



Caso de Teste	CT-05. Trocar produto (RF-2)	

Objetivo	
-	Realizar uma negociação de troca com outro usuário.	

Número de roupas (ENTRADA)	
-	1 Blusa exemplo.
-	1 Calça exemplo.	

                Custo da transação
	
-	2 BabyCoins.	

Data do envio da solicitação	
-	XX/XX/20XX

Saída esperada	
-	Por favor, aguarde a solicitação de troca ser aceita pelo usuário dono do produto.	



Caso de Teste	CT-06. Curtir anúncio (RF-7)


Objetivo	
-	Cliente curtir um anúncio e esse ser registrado como favoritos no menu “Guarda Roupa”.	

Selecionar curtir (ENTRADA)	
-	Dentro de um anúncio, clicar no ícone estrela abaixo do produto	


Saída esperada	
-	No menu “Guarda Roupa”, o anúncio deve estar registrado na opção “Favoritos”, e com um link direto para o anúncio	



Caso de Teste	CT-07. Buscar Produtos (RF-8) / (RF-09)	

Objetivo	
-	Utilizar o campo de busca e seus respectivos filtros para realizar buscas por produtos no site.	





Selecionar curtir (ENTRADA)
	
-	Digita o nome do produto desejado (Calça, blusa, meia) e clicar em buscar.

-	Testar os filtros em conjunto, em combinações diferentes e isoladamente.

-	Filtros utilizados: Categoria, idade, tamanho e gênero.	

Saída esperada	
-	Informação com o número de anúncios exibidos.

-	Anúncios exibidos na tela.



Caso de Teste	CT-08. Trocar mensagens entre usuários (RF-11)

Objetivo	
-	Realizar uma conversa via chat pelo anunciante e cliente.



Preparação	
-	Após a troca ser solicitada pelo cliente e confirmada pelo anunciante, a guia de chat será aberta.

Selecionar curtir (ENTRADA)	
-	Digitar mensagens de teste entre as partes.

Saída esperada	
-	Mensagens e enviadas com sucesso.



Caso de Teste	CT-09. Comprar BabyCoin (RF-12)

Objetivo	
-	Comprar BabyCoins via PIX ou transferência bancária.


Selecionar qual plano de BabyCoin é desejado (ENTRADA)	
-	O usuário deve ir na área do site destinada à compra de BabyCoin e escolher dentre as três opções: Light (3 BabyCoins), Standard (6 BabyCoins) ou VIP (12 BabyCoins). Em seguida deve prosseguir com a forma de pagamento desejada (PIX ou transferência bancária) e enviar o comprovante da compra por e-mail.


Saída esperada	
-	Após ter pago o valor, em um prazo de até 3 dias úteis, o saldo de BabyCoins escolhido sera acrescido em sua carteira.



Caso de Teste	CT-10. Aceitar / Recusar ou Cancelar a solicitação de troca e finalizar troca (RF-13) / (RF-14)



Objetivo	
-	Realizar as funções do ponto de vista do anunciante: Aceitar troca, recusar troca.

-	Realizar Funções do ponto de vista do cliente: Cancelar solicitação de troca.



Preparação	
-	Após a solicitação de troca pelo cliente, o sistema apresentará uma notificação que para abrir o Menu Troca (tanto para o anunciante, quanto para o cliente).




Escolher opção (ENTRADA)	
-	Dentro do Menu Troca:

-	Anunciante: Opção “Aceitar troca” e “Cancelar troca”.

-	Cliente: Opção “Cancelar Solicitação”.






Saída esperada (Anunciante)	
-	Aceitar troca: O sistema deverá exibir os dados relativos ao produto e abrir a opção de “Chat”, para contato com o cliente.

-	Rejeitar troca: O sistema deverá apresentar a mensagem: "Tem certeza que você deseja cancelar a troca?”, caso “sim”: “Você recusou a troca”. Após isso, redirecionar para o menu do usuário.




Saída esperada (Cliente)	
-	Cancelar Solicitação: O sistema irá apresentar a mensagem: “Tem certeza que deseja cancelar a solicitação de troca?”, caso “sim”: “Você cancelou sua solicitação, clique em finalizar para terminar o processo.”
Após isso, redirecionar para o menu do usuário.



Caso de Teste	CT-11. Avaliação da troca (RF-15)

Objetivo	
-	Usar do meio de avaliação de estrelas (1 a 5) como forma de avaliar a transação e avaliar o usuário com quem realizou a transação.





Após a entregue de uma roupa de troca (ENTRADA)	
-	Após confirmado a etapa final da compra/troca, que é a entrega, após o usuário logar novamente no sistema, aparecerá uma pop-up, perguntando como para avaliar a logística do site, e avaliar o usuário com quem ocorreu a compra/troca através do sistema de avaliação de estrelas, podendo o usuário colocar 1 estrela - “Horrível”
           5 estrelas - “Sensacional”.




Saída esperada	
-	Avaliação: Após enviado a avaliação, aparecera a seguinte mensagem: ”Obrigado pela avaliação, o time dev fica feliz com seu feedback, sua avaliação é importante para o bom funcionamento do site”.



Caso de Teste	CT-12. Suporte ao usuário (RF-16)


Objetivo	
-	Canal de comunicação entre usuário e administrador do sistema, contendo opções de marcar o tipo de ajuda solicitada e uma descrição que será enviada pelo usuário.




Preparação	
-	Usuário clica na opção “Ajuda”. Um select será apresentado com opções: “Denunciar Usuário, Minha Conta, Ajuda com Troca, Outros”.

-	Também abrirá um campo para escrever uma mensagem.


Selecionar opção e escrever mensagem (ENTRADA)	
-	O usuário deve marcar a opção do tipo de solicitação e escrever a mensagem que deseja. Em seguida, clicar em “Enviar”.




Saída esperada	
-	O administrador visualiza a mensagem no campo “Solicitações de Usuários”, tendo a opção de responder ao usuário. Após a resposta, na tela usuário recebe notificação contendo a mensagem.



Caso de Teste	CT-13. Denunciar conteúdo ou anúncio impróprio (RF-17)

Objetivo	
-	Usuário ter a opção para denúncia de usuário dentro do próprio anúncio. Essa denúncia deverá ser recebida pelo administrador.





Clicar em Denunciar (ENTRADA)	
-	Dentro do anúncio, o usuário deverá clicar em denunciar. Em seguida abrirá uma janela para escolha do motivo: Conteúdo Explícito, Violência, Preconceituoso, Outros (breve mensagem).
-	Após isso, o usuário deve clicar em “Enviar”





Saída esperada	
-	Usuário: “Sua denúncia foi enviada a nossa equipe e será analisada. Obrigado, sua participação é importante para a nossa comunidade”.

-	Para o Administrador: Recebe notificação de Denúncia, avalia e retorna mensagem para o usuário no inbox.



Caso de Teste	CT – 14. Desativar Conta (RF-19)

Objetivo	
-	Desativar conta através das configurações de conta da aba “Meu perfil”.





Restrições e informações
 necessárias para desativar a conta (ENTRADA)	
-	Para poder desativar a conta do sistema, o usuário deve possuir em mãos:
-	E-mail
-	Senha

-	Com isso, após colocar o e-mail e senha no campo de desativação de conta, um e-mail será enviado para a caixa de entrada de usuário, sendo que o mesmo deverá confirmar a desativação da conta.







Saída esperada	
-	“Um e-mail para confirmação da desativação da sua conta foi enviado para sua caixa de entrada”.
-	 “Clique no link para terminar a etapa de desativação da sua conta”.

-	Após ter clicado no link, a conta do usuário será desativada por um período de 30 dias, após esse período de dias a conta do usuário será excluída automaticamente.



Caso de Teste	CT-15. Postar vídeo no anúncio (RF-5)

Objetivo	
-	Realizar upload de um vídeo e postar em um anúncio


Adicionar vídeo (ENTRADA)	
-	Após clicar em “Adicionar Vídeo”, o usuário terá a opção de realizar um upload no video através de um botão “Escolher Video”.

Saída esperada	
-	Vídeo postado no anúncio.



Caso de Teste	CT-16. Responsividade (RNF-09)

Objetivo	
-	Aplicação responsiva a formatos diferentes.




Passos (ENTRADA)

	
-	O usuário entra no endereço do site através de um de smartphone, aonde o menores vão até 300 pixels, aonde também tem casos inversos aonde o usuário pode acessar o site por uma tv, podendo ir até 4000 pixels.

Restrições	
-	O dispositivo móvel não pode ser largura menor que 300 pixels.



Saída esperada	
-	Após acessar o site pelo smartphone, o site já ira se adaptar ao tamanho do dispositivo, fazendo assim que o conteúdo se disponha de forma homogênea.



Caso de Teste	CT-17. Disponibilidade (RNF-03)



Objetivo	
-	Testar a disponibilidade do sistema durante semana em diversos períodos do dia, objetivando que atenda ao critério estabelecido de estar disponível em 90% do tempo durante este período.



Passos (ENTRADA)	
-	O usuário entra no endereço do site durante momentos diversos durante um período de 7 dias, momentos estes escolhidos aleatoriamente pela equipe desenvolvedora.

Saída esperada	
-	O site deve estar operante durante o acesso do usuário.



Caso de Teste	CT-18. Retorno da busca (RNF-04)

Objetivo	
-	Testar o desempenho do sistema, para saber se atende ao critério estabelecido pelo requisito não-funcional descrito acima no Caso de Teste.



Passos (ENTRADA)	
-	O usuário deve inserir alguma palavra-chave na barra de busca disponível no site e cronometra-se o tempo que o sistema leva para retornar o resultado desejado.



Saída esperada	
-	Após confirmada a busca desejada na barra de pesquisa, os resultados aparecem para o usuário em um tempo inferior ou igual a 5 segundos.



Caso de Teste	CT-19. Geolocalização (RF-10)

Objetivo	
-	Buscar anúncios em determinado raio geográfico selecionado pelo usuário.





Formas de localização (ENTRADA)	
-	No campo de busca, digitar um produto a ser localizado.

-	No filtro “Roupas por perto”, selecionar o raio geográfico desejado e clicar em buscar.

-	Obs.: Essa busca deve também ser testada utilizando os filtros de categoria, idade, tamanho e gênero.


Saída esperada	-	Anúncios exibidos na tela, de acordo com o raio geográfico desejado e, eventualmente, demais filtros.



Caso de Teste	CT-20. Suporte a PNG e JPG (RNF-06)

Objetivo	
-	Testar se o usuário consegue acrescentar imagens nos formatos png e jpeg ao fazer o anúncio de uma peça para ser trocada.


Passos (ENTRADA)	
-	O usuário deve inserir as fotos escolhidas para peça no campo destinado a isto na ferramenta de criar novo anúncio.


Restrições	
-	Não serão aceitos outros formatos como pdf, docx, entre outros.


Saída esperada	
-	As fotos inseridas pelo usuário deverão aparecer em seu anúncio, tanto quando pendente como quando já publicado.



Caso de Teste	CT-21. Vídeos MP4, MKV, OGV (RNF-07)



Objetivo	
-	Testar se o usuário consegue acrescentar vídeos nos formatos mp4, mkv ou ogv ao fazer o anúncio de uma peça para ser trocada.


Passos (ENTRADA)	
-	O usuário deve inserir o vídeo escolhido para peça no campo destinado a isto na ferramenta de criar novo anúncio.


Restrições	
-	Não serão aceitos outros formatos como avi, wmv, mov, entre outros.


Saída esperada	
-	O vídeo inserido pelo usuário deverá aparecer em seu anúncio, tanto quando pendente como quando já publicado.



Caso de Teste	CT-22. Validar postagem 3 fotos e 1 vídeo (RNF-08)



Objetivo	
-	Testar se o sistema atende à restrição de não permitir que uma postagem seja submetida pelo usuário caso não tenha pelo menos três fotos, um vídeo e uma descrição inclusos. 


Passos (ENTRADA)	
-	O usuário deve inserir menos de 3 fotos e 1 vídeo e também não incluir descrição na ferramenta do site de criar novo anúncio.



Saída esperada	
-	O site não deve permitir a postagem da publicação de peça e ainda informar ao usuário quais elementos estão faltando para atender aos requisitos de postagem.



Caso de Teste	CT-23. Acessibilidade (RNF-10)



Objetivo	
-	Testar se o sistema fornece ao usuário opções de ajuste para o contraste e tamanho da fonte para que melhor atendam suas necessidades.



Passos (ENTRADA)	
-	O usuário deve alterar nos ícones dispostos do site para contraste e tamanho da fonte para alterar esses atributos (canto inferior direito de todas as telas)



Saída esperada	
-	Tamanho da fonte aumentar ou diminuir de acordo com a escolha do usuário e contraste do site mudar para modo noturno ou diurno, de acordo com sua preferência.



Caso de Teste	CT-24. Segurança (RNF-11)




Objetivo	
-	Verifica a segurança das informações de cadastro de usuário, sendo que as mesmas devem ser somente acessadas pelo próprio usuário dono da conta, e pelo administrador do sistema.





Passos (ENTRADA)	
-	No login de tipo usuário, verificar se os dados são exibidos apenas pelo próprio usuário, sendo que outra conta não poderá ver esses dados. Os dados estão em “Minha Conta > Meus dados”.

-	No login de tipo administrador, verificar se os dados do usuário são exibidos. Os dados estão em “Usuários > Dados de Usuários”.

Saída esperada	
-	Informações referente a conta;



Caso de Teste	CT-25. Alerta de Produtos favoritados (RNF-12)

Objetivo	
-	 Testar se a aplicação está emitindo alertas de acordo com os produtos de interesse dos usuários.


Selecionar curtir (ENTRADA)	 
-	 O usuário deve realizar o login no site e acessar a caixa de alertas de produtos.

Saída esperada	
-	Informações de alertas chegando para o usuário corretamente.



Caso de Teste	CT-26. Histórico de Usuário (RNF-13)

Objetivo	
-	Registrar no histórico do usuário quais trocas realizadas em seu cadastro.



Selecionar curtir (ENTRADA)	
-	Se o usuário fizer alguma troca, ele poderá conferir em seu histórico de usuários quais foram esses produtos.

Saída esperada	
-	Informações referentes ao histórico de trocas realizadas.



Caso de Teste	CT-27. Bloqueio por denúncias (RNF-14)


Objetivo	
-	Tornar o site seguro contra usuários sem boa reputação de transações ou usuário maliciosos com segundas intenções.




Requisitos (ENTRADA)	
-	Se o usuário for denunciado por 3 ou mais vezes, a conta dele é suspensa por 30 dias, caso o usuário queira contestar, tem esse período de tempo, caso passe o prazo, a conta será deletada.

Saída esperada	
-	A conta do usuário será automaticamente suspensa após receber 3 ou mais denúncias, podendo o usuário contestar a suspensão.



Caso de Teste	CT-28. Bloqueio por pendência de avaliação (RNF-15)


Objetivo	
-	Bloquear o usuário a postar novos anúncios enquanto não avaliar a última troca realizada. 

Troca não avaliada (ENTRADA)	
-	Não avaliar troca.

Saída esperada	
-	Usuário bloqueado após 3 (dias)
-	Obs.: Reduzir o tempo para o teste.







