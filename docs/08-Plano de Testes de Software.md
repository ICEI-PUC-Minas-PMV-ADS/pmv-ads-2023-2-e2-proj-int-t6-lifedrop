# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

| **Caso de Teste** 	| **CT - 01 - Cadastrar Usuário** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 001 - O sistema deve possibilitar ao usuário se registrar na plataforma.|
| Objetivo do Teste 	|Verificar se o usuário consegue se cadastrar no site. |
| Passos 	| - Acessar o navegador<br> - Informar o endereço do site<br> - Clicar em “Cadastrar<br> - Preencher os campos obrigatórios (nome, e-mail, senha, origem)<br>- Clicar em "Criar Conta"<br>|
|Critério de Êxito |  - O cadastro foi realizado com sucesso.|

| **Caso de Teste** 	| **CT - 02 - Gerenciar Login** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 002 - O sistema deve permitir ao usuário gerenciar o login. |
| Objetivo do Teste 	|Verificar se o usuário consegue gerenciar o login.|
| Passos 	| - Acessar o navegador<br> - Informar o endereço do site<br> - Faça o login<br> - Clicar em “Meu Perfil” <br>- Gerenciar o perfil.<br>|
|Critério de Êxito | - O gerenciamento foi realizado com sucesso.|

| **Caso de Teste** 	| **CT - 03 - Gerenciar banco de sangue** 	|
|:---:	|:---:	|
|	Requisito Associado 	|  RF – 003 - O sistema deve permitir registrar e verificar o estoque disponível nos bancos de sangue.|
| Objetivo do Teste 	|Verificar se o usuário consegue gerenciar banco de sangue.|
| Passos 	| - Acessar o navegador<br> - Informar o endereço do site<br> - Faça o login<br> - Clicar em “Agende sua doação”<br> - Visualizar estoque de sangue.<br>|
|Critério de Êxito |  -O estoque do banco de sangue está visível|

| **Caso de Teste** 	| **CT - 04 - Gerenciar agendamentos** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 004 - O sistema deve permitir ao doador gerenciar agendamentos..|
| Objetivo do Teste 	|Verificar se o usuário consegue gerenciar agendamentos|
| Passos 	|- Acessar o navegador<Br> - Informar o endereço do site<br> - Faça o login<br> - Clicar em “Meu Perfil”<br> - Clicar em “alterar”.|
|Critério de Êxito |  - O gerenciamento foi realizado com sucesso. |

| **Caso de Teste** 	| **CT - 05 - Acessar histórico de doações ** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 005 - O sistema deve permitir o acesso ao histórico completo de doações do doador.|
| Objetivo do Teste 	|Verificar se o usuário consegue acessar o histórico de doações.|
| Passos 	| - Acessar o navegador<br> - Informar o endereço do site<br> - Faça o login<br> - Clique em “Meu perfil”<BR> - Acesse o histórico de agendamentos.|
|Critério de Êxito |  - O histórico de doações está visível |

| **Caso de Teste** 	| **CT - 06 - Verificação da aptidão do doador** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF – 006 - O sistema deve verificar se o doador está apto para a doação antes de permitir que o doador agende uma doação.|
| Objetivo do Teste 	|Verificar se o usuário consegue acessar o histórico de doações.|
| Passos 	| - Acessar o navegador<Br> - Informar o endereço do site<br> - Ao agendar a doação aparecerá se está apto ou não.|
|Critério de Êxito |  - Doador apto, ou não, para realizar a doação|

| **Caso de Teste** 	| **CT - 07 - Registro de emergências** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 007 - O sistema deve permitir ao administrador dos bancos de sangue registrar emergências.
| Objetivo do Teste 	|Verificar se o administrador consegue registrar emergências|
| Passos 	| - Acessar o navegador<br> - Informar o endereço do site<br> - Faça o login administrativo <Br>- Clique em “Painel Administrativo”<br> - Registre a emergência em “Solicitar doação emergencial”.|
|Critério de Êxito |  - Registro de emergências|

| **Caso de Teste** 	| **CT - 08 - Acesso ao painel administrativo** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF - 008 - O sistema deve permitir ao administrador do banco de sangue acessar o painel administrativo integrado.|
| Objetivo do Teste 	|Verificar se o administrador consegue ter acesso ao painel administrativo.|
| Passos 	| - Acessar o navegador<br> - Informar o endereço do site<br> - Faça o login administrativo <br> - Clique em “Painel Administrativo”.|
|Critério de Êxito |  - O painel administrativo está visível |
