# Registro de Testes de Usabilidade

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="10-Plano de Testes de Usabilidade.md"> Plano de Testes de Usabilidade</a>

Para cada caso de teste definido no Plano de Testes de Usabilidade, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

## Cadastrar, acessar, e fazer logout da conta 
|Objetivo do Teste    | Sucesso | Resultado |
|------|-----------------------------------------|----|
| Verificar se o usuário consegue acessar por meio de outros dispositivos. |Sim | A tela se muda proporcional com a resolução do dispositivo utilizado|
| Cadastrar conta de usuário doador | Sim | Cadastro realizado com sucesso |
| Cadastrar conta de usuário administrador | Sim | Cadastro realizado com sucesso |
| Fazer login de usuário doador, na opção administrador | Não | Login não efetuado |
| Fazer login de usuário administrador, na opção doador | Não | Login não efetuado |
| Fazer logout da conta doador e administrador | Sim | Logout realizado com sucesso |

## Agendamentos 
|Objetivo do Teste    | Sucesso | Resultado |
|------|-----------------------------------------|----|
|Fazer agendamento do usuário doador |Não| No primeiro acesso a conta precisa preencher as informações na página “Meu Perfil” para conseguir realizar o agendamento| 
| Preencher todas as informações pessoais na página “Meu Perfil” | Sim | Informações salvas com sucesso |
| Não preencher todas as informações pessoais na página “Meu Perfil” | Não | Informação não são salvas, precisa preencher todos os campos.
| Fazer o agendamento após preencher as informações pessoais. | Sim | Agendamento realizado com sucesso. |
| Clicar em “agendar doação” sem preencher todos os campos. | Não | O agendamento só é concluído quando preenche todos os campos. | 
| Alterar e cancelar o agendamento na página “Meu Perfil” | Sim | Alteração realizada com sucesso. |
| Acessar página de orientações sobre doação | Sim | Orientações sobre doação disponivel para leitura | 

## Painel Administrador 
|Objetivo do Teste    | Sucesso | Resultado |
|------|-----------------------------------------|----|

