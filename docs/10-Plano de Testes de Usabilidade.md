# 6. Registro de Testes de Usabilidade

Os requisitos para realização dos testes de usabilidade são:  
* Navegador da Internet - Chrome, Firefox ou Edge 
* Protótipo em HTML, CSS e JS 

## 6.1 Objetivo do Teste de Usabilidade: 

* Avaliar o grau de sucesso da execução (1 a 5); 
* Verificar total de erros cometidos pelos usuários; 
* Identificar quantos erros de cada tipo ocorreram; 
* Marcar o tempo gasto em cada tarefa.

## 6.2 Público-alvo do teste 

O teste será realizado com 5 participantes, sendo o público alvo os pais ou responsáveis que têm filhos pequenos e desejam realizar trocas de roupas infantis, como também interessados na ideia de sustentabilidade.  

## 6.3 Forma de realização do teste 

Os testes serão realizados via protótipo do sistema, sendo a coleta de dados feita por meio de observação e registrados em planilha para cada caso de teste. 

No final, será aplicado para cada usuário o método de avaliação SUS - System Usability Scale (Escala de Usabilidade do Sistema). 

Os testes funcionais a serem realizados na aplicação são descritos a seguir: 

Casos de Teste | CT-01. Cadastro de Usuário 
--- | --- 
Requisitos Associados | RF-01: O usuário deve se cadastrar na plataforma com seus dados pessoais, incluindo endereço completo, nome, CPF e e-mail. 
Objetivo do Teste | Verificar se após a inserção de dados o sistema possibilita a validação ou mensagem de erro no cadastro de usuário, indicando o que fazer para correção do erro. 
Passos | 1. Acessar o Navegador; <br>2. Informar o endereço do Site;<br> 3. Caso o usuário possuir cadastro, fazer o login no sistema na opção “Entrar”;<br> 4. Caso o usuário não possuir cadastro, clicar em “Cadastre-se agora” e seguir as instruções. 
Critérios de Êxito | O usuário deve ser capaz de realizar o cadastro e login. 


Casos de Teste | CT-02. Cadastro de Produto
--- | --- 
Requisitos Associados | RF-03: A aplicação deve permitir o cadastro de produto;<br> RF-04: Aplicação deve permitir a postagem de fotos e descrição no anúncio do produto;<br> RF-05: A aplicação deve permitir ao usuário a postagem de vídeos no anúncio do produto.  
Objetivo do Teste | Permitir o cadastro de produto com inclusão de fotos e descrição. 
Passos | 1. Realizar login no sistema,<br> 2. No menu principal, escolher a aba “Guarda Roupa”;<br> 3. Escolha a opção “Criar novo anúncio”;<br> 4. Informar um título para a peça;<br> 5. Preencher a descrição geral com informações com o estado da peça e características que achar relevantes;<br> 5. Informar os tipos de filtros nos campos “Idade”, “Categoria” e “Gênero”;<br> 6. Adicionar no mínimo 3 fotos da peça no campo “Adicionar Fotos”;<br> 7. Adicionar vídeo para detalhar visualmente aspectos da peça no campo “Adicionar Vídeo”;<br> 8. Informar o CEP da retirada ou escolher a opção de utilizar o já cadastrado;<br> 9. Clicar em “Publicar postagem”. 
Critérios de Êxito | O usuário deve ser capaz de adicionar roupas no seu guarda roupa com as devidas descrições exigidas pela plataforma, com fotos e vídeo para detalhar visualmente a peça. 

Casos de Teste | CT-03. Excluir anúncio de peça cadastrada
--- | --- 
Requisitos Associados | RF-02 - A aplicação deve permitir anunciar roupas destinadas a troca ou doação;<br> RF-06 - A aplicação deve permitir ao usuário a exclusão de anúncio e cadastro de produto. 
Objetivo do Teste | Verificar se o usuário consegue deletar anúncio publicado anteriormente. 
Passos | 1. Realizar login no sistema;<br> 2. No menu principal, escolher a opção “Guarda Roupa”;<br> 3. Ir na aba “Minhas publicações” ou “Publicações pendentes”;<br> 4. Clicar no ícone de lixeira que aparece no card do produto;5. Confirmar a escolha de exclusão de peça. 
Critérios de Êxito | O usuário ser capaz de excluir peça cadastrada em seu guarda roupa. 


Casos de Teste | CT-04. Excluir conta de usuário
--- | --- 
Requisitos Associados | RF-19: A aplicação deve permitir ao usuário a exclusão ou desativação de sua conta.
Objetivo do Teste | Verificar se o usuário consegue excluir sua própria conta caso não queira mais ser associado ao BabyBay.  
Passos | 1. Realizar login no sistema;<br> 2. No menu principal, escolher a opção “Configurações”;<br> 3. Selecionar a opção “Excluir conta”;<br> 4. Inserir e-mail usado no cadastro para confirmar decisão;<br> 5. Clicar em “Excluir minha conta permanentemente”. 
Critérios de Êxito | O usuário ser capaz de excluir sua conta através do caminho descrito acima, passando a não ser mais associado ao BabyBay. 


Casos de Teste | CT-05. Desativar conta de usuário 
--- | --- 
Requisitos Associados | RF-19: A aplicação deve permitir ao usuário a exclusão ou desativação de sua conta 
Objetivo do Teste | Verificar se o usuário consegue desativar sua própria conta caso precise de um tempo longe da plataforma (com limite de 30 dias) ou não queira mais ser associado ao BabyBay.  
Passos | 1. Realizar login no sistema;<br> 2. No menu principal, escolher a opção “Configurações”;<br> 3. Selecionar a opção “Desativar conta”;<br> 4.Inserir e-mail usado no cadastro para confirmar decisão; 5. Clicar em “Desativar minha conta”.
Critérios de Êxito | O usuário ser capaz de desativar sua conta por até 30 dias através do caminho descrito acima. Caso não retorne no período de tempo limite, ter sua conta permanentemente excluída do Banco de Dados. 


Casos de Teste | CT-06 Busca por produtos com filtros 
--- | --- 
Requisitos Associados | RF-08: A aplicação deve ter campo de busca por lojas e produtos;<br> RF-09: A aplicação deve possuir filtro de busca para idade, categoria e gênero;<br> RF-10:  A aplicação deve fornecer ao usuário a possibilidade de ajustar seu raio geográfico de busca. 
Objetivo do Teste | Permitir realizar a busca por um vestuário por filtros específicos de idade, categoria, tamanho, gênero e raio geográfico. 
Passos | 1. Realizar login no sistema;<br> 2. No menu principal, escolher a aba “Buscar roupas”; 3. Dentro do menu, clicar no ícone de “lupa” para digitar a roupa desejada;<br> 4. Clicar no campo “select” para marcar os filtros desejados, dentre as opções de idade, categoria, gênero e raio geográfico;<br> 5. Clicar em “Buscar Roupa”. 
Critérios de Êxito | O usuário deve ser capaz buscar uma roupa de acordo com os filtros desejados, sendo que após a escolha dos mesmos, o sistema exibe os anúncios para o usuário escolher o que mais lhe agrada 


Casos de Teste | CT-07. Opção do usuário de favoritar as roupas e lojas que gostou.  
--- | --- 
Requisitos Associados | RF-07: A aplicação deve exibir para o usuário a opção de favoritar produtos de interesse, bem como usuário 
Objetivo do Teste | Permitir o usuário salvar produtos preferidos.
Passos | 1. Realizar login no sistema;<br> 2. No menu principal, escolher a aba “Buscar Roupas”;<br> 3. Já na aba, selecionar os filtros desejados para realizar a busca;<br> 4. Clicar no anúncio desejado;<br> 5. Dentro do anúncio clicar em “Favoritar”, com uma estrela ao lado;<br> 6. Para visualizar seus favoritos, ir até o menu principal, clicar na aba “Meu Guarda Roupa”;<br> 7. Dentro do menu “Meu Guarda Roupa”, basta entrar na aba “Meus favoritos” que será redirecionado até uma lista de produtos curtidos. 
Critérios de Êxito | O usuário deve ser capaz de marcar os produtos favoritos, sendo que esses produtos devem ficar registrados na aba “Meus Favoritos”, dentro do menu “Meu Guarda Roupa”. 


Casos de Teste | CT-08. Permitir a troca de mensagens com as partes interessadas a fim de obter um acordo 
--- | --- 
Requisitos Associados | RF-11: A aplicação deve permitir a troca de informações entre as partes interessadas via caixa de perguntas e respostas 
Objetivo do Teste | Permitir realizar um troca de mensagens entre o anunciante e cliente 
Passos | 1. Realizar login no sistema;<br> 2. No menu principal, escolher a aba “Buscar roupas”; <br> 3. Dentro do menu, clicar no ícone de “lupa” para digitar a roupa desejada;<br> 3. Clicar no campo select para marcar os filtros desejados, dentre as opções de idade, categoria, gênero e raio geográfico;<br> 4. Clicar em “Buscar Roupa”;<br> 5. Caso deseje realizar uma troca, selecione uma das roupas anunciadas;<br> 6. Ao abrir o anúncio, clicar na opção “Eu quero!”;<br> 7. O inbox será aberto, com isso os usuários poderão trocar mensagens privadas de negociação. 
Critérios de Êxito | Os usuários devem ser capazes de realizar uma conversa em um chat privado. 

Casos de Teste | CT-09. Permitir a compra da moeda virtual do sistema “BabyCoin” com os principais meios de pagamento atuais 
--- | --- 
Requisitos Associados | RF-12 - O usuário poderá adquirir moedas virtuais “BabyCoin” mediante PIX ou TED para comprar peças de roupas. 
Objetivo do Teste | Permitir realizar a realização de um compra da moeda virtual BabyCoin para adquirir um vestuário com a moeda comprada. 
Passos | 1. Realizar login no sistema;<br> 2. No menu principal, escolher a aba “Minha carteira” no canto esquerdo;<br> 3. Já na aba “Minha carteira”, selecione a opção “Compre mais BabyCoins” na aba “Seu saldo”;<br> 4. Escolher qual das opções de compra de BabyCoins disponibilizadas o usuário deseja;<br> 5. Realizar transferência bancária ou PIX do valor da opção escolhida;<br> 6. Enviar comprovante bancário por e-mail. 
Critérios de Êxito | O usuário deve ser capaz de facilmente comprar a moeda de compra interna do site usando os principais meios de pagamento usando em território nacional .


Casos de Teste | CT-10. Permitir ao usuário aceitar ou cancelar a troca  
--- | --- 
Requisitos Associados | RF-13: A aplicação deve permitir ao usuário aceitar ou cancelar troca 
Objetivo do Teste | Permitir que a solicitação da troca por um cliente seja aceita ou recusada pelo anunciante, ou ainda cancelado pelo próprio cliente 
Passos | 1. Realizar login no sistema;<br> 2. No menu principal, escolher a aba “Buscar roupas”;<br> 3. Dentro do menu, clicar no ícone de “lupa” para digitar a roupa desejada; 4. Clicar no campo select para marcar os filtros desejados, dentre as opções de idade, categoria, gênero e raio geográfico;<br> 5. Clicar em “Buscar Roupa”;<br> 6. Caso deseje realizar uma troca, selecione uma das roupas anunciadas;<br> 7. Ao abrir o anúncio, clicar na opção “Eu quero!” e se comunicar com o anunciante;<br> 8. Na página de mensagens, o anunciante deverá clicar em uma das opções de confirmar ou recusar a troca, dispostas para ele como solicitação do usuário que quer adquirir a peça;<br> 9. Para o usuário solicitante da peça que gostaria de cancelar seu pedido, a mesma página de troca de mensagens e solicitação usuário/anunciante, clicar na opção de “Cancelar solicitação”;<br> 10. Redirecionar para o menu “Finalização de Troca”.
Critérios de Êxito | O cliente conseguir cancelar a solicitação do anúncio e o anunciante conseguir recusar ou aceitar a troca.


Casos de Teste | CT-11. Permitir a finalização da troca, sendo ela aceita ou rejeitada 
--- | --- 
Requisitos Associados | RF-14: A aplicação deve solicitar ao usuário a finalização da troca. 
Objetivo do Teste | Permitir que o pedido de troca solicitado por um cliente seja aceito, recusado ou cancelado pelo cliente. 
Passos | 1. Realizar login no sistema;<br> 2. No menu principal, escolher a aba “Buscar roupas”;<br> 3. Dentro do menu, clicar no ícone de “lupa” para digitar a roupa desejada;<br> 4. Clicar no campo select para marcar os filtros; desejados, dentre as opções de idade, categoria, gênero e raio geográfico;<br> 5. Clicar em “Buscar Roupa”;<br> 6. Caso deseje realizar uma troca, selecione uma das roupas anunciadas; 7. Ao abrir o anúncio, clicar na opção “Eu quero!”;<br> 8. Na página de mensagens, o anunciante deverá clicar em uma das opções de confirmar ou recusar a troca, dispostas para ele como solicitação do usuário que quer adquirir a peça;<br> 9. Redirecionar para o menu “Finalização de Troca”;<br> 10. No menu “Finalização Troca”, o usuário tem acesso a toda a transação envolvendo a troca, se foi aceita ou recusada pelo anunciante, ou cancelada pelo usuário solicitante. 
Critérios de Êxito | Permitir aos usuários envolvidos na troca acessar as informações referentes a ela. 


Casos de Teste | CT-12. Feedback da transação realizada, fornecer um sistema de avaliação de pontuação (1 a 5 estrelas). 
--- | --- 
Requisitos Associados | RF-15 A aplicação deve solicitar ao usuário a avaliação da troca 
Objetivo do Teste | Permitir ao usuário avaliar a outra parte após a finalização de uma troca. 
Passos | 1. Após o final de uma troca será enviado um e-mail para cada usuário envolvido na troca;<br> 2. O usuário deverá clicar em um link no e-mail e ser redirecionado para uma avaliação do outro usuário;<br> 3. Ele deverá escolher quantas estrelas de 1 a 5;<br> 4.Depois deverá escrever uma pequena resenha de até 240 caracteres sobre a experiência em trocar com o outro usuário;<br> 5.Assim que um dos usuários fizer a primeira avaliação será enviado um outro e-mail para o outro usuário que ainda não fez a avaliação informando que ele foi avaliado e que também precisa fazer uma avaliação para visualizar a avaliação recebida;<br> 6. Assim que ambos se avaliarem as avaliações serão “creditadas” para cada um;<br> 7. Enquanto não tiver realizado a avaliação o usuário não poderá fazer nova troca;<br> 8. As avaliações recebidas por cada usuário serão exibidas sempre que ele for realizar uma troca em forma de média de todas as avaliações recebidas para que os outros usuários possam saber as qualificações positivas e/ou negativas que ele possa ter recebido;<br> 9. Caso o usuário não tenha sido avaliado ainda deverá ser exibido no lugar da avaliação uma mensagem informando que o usuário ainda não finalizou nenhuma transação;<br> 10. Caso o usuário tente realizar alguma transação durante um período em que ele esteja com alguma avaliação pendente ele deverá ser direcionado para a avaliação e deverá realizar a avaliação pendente automaticamente e assim que avaliar deverá ser redirecionado para a página da transação que estava tentando fazer. 
Critérios de Êxito | Usuários conseguindo se avaliar e visualizar as avaliações uns dos outros sem nenhuma dificuldade entre os processos:<br> * E-mails recebidos adequadamente;<br> * Envio de avaliação sem travamento;<br> * Visualização das avaliações nos locais onde elas precisam ser visualizadas.


Casos de Teste | CT-13. Solicitação de suporte pelo usuário 
--- | --- 
Requisitos Associados | RF-16: A aplicação deve fornecer campo de ajuda e informações para orientação de uso  
Objetivo do Teste | Averiguar a interação entre usuário e plataforma através do menu “Suporte” 
Passos | 1. Realizar Login no sistema ;<br> 2. No menu principal, clicar em “Ajuda”;<br> 3. Dentro do menu “Ajuda”, clicar em “Solicitar Suporte”.<br> 4. Escolher a forma de suporte, que são: via e-mail ou Whatsapp;<br> 5. Registrar ocorrência de suporte;<br> 6. Após a finalização, avaliar suporte, com descrição opcional. 
Critérios de Êxito | Usuário conseguir solicitar suporte na plataforma, obtendo seu devido retorno 


Casos de Teste | CT-14 A aplicação deve disponibilizar a opção de denunciar “Produto” e denunciar “usuário”  
--- | --- 
Requisitos Associados | RF-17 - A aplicação deve exibir para o usuário a opção de denunciar postagens e usuários falsos ou maliciosos; 
Objetivo do Teste | Poder denunciar uma postagem de roupa ou usuário; 
Passos | 1. No anúncio, página de usuário (“Guarda-roupa de usuário) ou página de solicitação de troca (mensagens), clicar nas opções “Denunciar postagem ou usuário”;<br> 2. Escolha o motivo pelo qual está se denunciando aquela postagem ou usuário, dentre as opções listadas;<br> 3. Clicar em “Enviar”.
Critérios de Êxito | Ser capaz de denunciar um usuário ou uma postagem da aba de busca por um motivo específico. 
