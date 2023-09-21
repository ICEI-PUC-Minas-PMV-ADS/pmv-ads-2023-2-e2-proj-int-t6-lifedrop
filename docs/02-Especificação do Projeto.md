# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto, foi consolidada com a participação dos usuários em um trabalho de imersão feita pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas.
Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

## `Ana Clara`
<img src="/docs/img/Persona 1.png" width="150px"> | Ana Clara, 32 anos                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------------- |
| Ocupação                                                                                                                 | Dentista |
| Aplicativos preferidos                                                                                                   | Intagram , Facebook, Whatsapp |
| Motivações                                                                                                               | Abrir uma clinica maior, para alcançar a estabilidade financeira|
| Seus Hobbies                                                                                                             | Ler livros, ir a teatros e fazer viagens |
| Frustrações?                                                                                                             | Desvalorização do trabalho e falta de tempo |

## `Daniel`
<img src="/docs/img/Persona 2.png" width="150px"> | Daniel, 21 anos                                                                                     |
| ------------------------------------------------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------------- |
| Ocupação                                                                                                                 | Analista de Sistemas |
| Aplicativos preferidos                                                                                                   | Intagram, LinkedIn, Telegram e Tik Tok |
| Motivações                                                                                                               | Ser efetivado e conseguir uma renda extra, comprar seu primeiro carro |
| Seus Hobbies                                                                                                             | Jogar video game, cinema e cozinhar |
| Frustrações?                                                                                                             | Dificuldade de Locomoção e falta de tempo |

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Ana Clara           | acessar informações de como funciona a doação de sangue           | me informar sobre o tema e me tornar uma doadora              |
|Daniel              | saber aonde é o centro de doação mais próximo                     | para facilitar sua locomoção e poupar tempo |
|Ana Clara           | acompanhar o estoque de sangue disponível nos bancos de sangue    | saber a necessidade de cada tipo sanguíneo para poder agendar a minha doação              |
|Daniel              | ter um acesso a uma conta de usuário                              | para facilitar o preenchimento nos próximos agendamentos         |
|Ana Clara           | poder gerenciar os meus agendamentos na plataforma                | ficar ciente com a data, local e a hora que será realizada a doação de sangue.              |
|Daniel              | ser avisado quando puder doar de novo                     | para doar mais vezes no ano |
|Ana Clara           | acessar a plataforma de doação de sangue tanto no celular quanto no computador          | facilitar o meu dia dia podendo gerenciar o meu registro de doadora de qualquer lugar e a qualquer momento              |
|Daniel              | acessar o histórico de doações                     | para saber quantas vezes doei |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001|O sistema deve possibilitar ao usuário se registrar na plataforma. | ALTA | 
|RF-002| O sistema deve permitir ao usuário gerenciar o login. | ALTA | 
|RF-003| O sistema deve permitir registrar e verificar o estoque disponível nos bancos de sangue. | MÉDIA |
|RF-004| O sistema deve permitir ao doador gerenciar agendamentos. | ALTA | 
|RF-005| O sistema deve permitir o acesso ao histórico completo de doações do doador. | MÉDIA | 
|RF-006| O sistema deve verificar se o doador está apto para a doação antes de permitir que o doador agende uma doação. | ALTA | 
|RF-007| O sistema deve permitir ao administrador dos bancos de sangue registrar emergências | ALTA |
|RF-008| O sistema deve permitir ao administrador do banco de sangue acessar o painel administrativo integrado.  | MÉDIA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve carregar completamente em menos de 3 segundos, mesmo em conexões de internet mais lentas. | ALTA | 
|RNF-002|O site deve ser responsivo e adaptar-se adequadamente a diferentes dispositivos, tamanhos de tela e orientações. | ALTA |
|RNF-003| Durante campanhas de doação de sangue ou situações de emergência o site deve ser capaz de lidar com um aumento significativo no tráfego sem perda de desempenho. | MÉDIA |
|RNF-004| O site deve garantir que todas as informações pessoais fornecidas pelos usuários no momento do registro sejam armazenadas de forma segura. | ALTA |
|RNF-005| O sistema de suporte deve garantir um tempo médio de resposta de menos de 1 hora para as dúvidas dos usuários, seja por meio de chat ao vivo ou formulário de contato.|  MÉDIA |
|RNF-006| A interface do site deve ser intuitiva e de fácil navegação, permitindo aos usuários encontrar informações e realizar ações facilmente.|  MÉDIA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| O projeto não pode ser desenvolvido por terceiros que não fazem parte da equipe de desenvolvedores.|


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
