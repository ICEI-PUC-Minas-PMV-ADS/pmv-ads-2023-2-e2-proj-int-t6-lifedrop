# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir que os usuários se registrem na plataforma, fornecendo informações pessoais como nome, data de nascimento, gênero, tipo sanguíneo, localização, estado de saúde e histórico de doenças preexistentes. | ALTA | 
|RF-002| O sistema deve permitir que os usuários registrados façam login de forma segura na plataforma, utilizando e-mail e senha. | ALTA | 
|RF-003| O sistema deve criar um perfil pessoal para cada doador. Esse perfil deve exibir as informações básicas do doador, incluindo seu histórico de doações anteriores, nível de elegibilidade e um lembrete para a próxima doação sugerida. | MÉDIA |
|RF-004| O sistema deve disponibilizar aos doadores a capacidade de verificar o estoque de sangue disponível nos bancos de sangue. Isso ajudará os doadores a entender quais tipos sanguíneos são mais necessários. | MÉDIA | 
|RF-005| O sistema deve permitir que os doadores pesquisem bancos de sangue próximos e agendem doações em datas e horários convenientes para eles. O sistema deve confirmar a disponibilidade das datas e horários escolhidos. | ALTA | 
|RF-006| O sistema deve permitir que os doadores devem possam visualizar, modificar ou cancelar suas doações agendadas. Toda alteração deve ser registrada e confirmada pelo sistema.. | ALTA | 
|RF-007| O sistema deve permitir que os doadores acessem o histórico completo de suas doações anteriores, incluindo datas, locais e quantidades doadas. A informação deve ser apresentada de forma clara. | MÉDIA |
|RF-008| O sistema deve realizar uma verificação automática antes de permitir que um doador agende uma doação. Essa verificação deve confirmar se o doador atende aos requisitos de elegibilidade, incluindo a idade mínima e um intervalo adequado entre as doações. | ALTA |
|RF-009| O sistema deve permitir que os administradores dos bancos de sangue registrem situações de emergência que necessitem de doadores com tipos sanguíneos específicos. Além disso, o sistema deve notificar os doadores relevantes e sugerir horários de agendamento para atender às necessidades emergenciais. | ALTA |
|RF-010| O sistema deve proporcionar aos administradores dos bancos de sangue acesso a um painel administrativo integrado. Esse painel administrativo permitirá o gerenciamento eficaz de agendamentos, estoque de sangue e solicitações de doadores para situações emergenciais. | MÉDIA |
|RF-011| O sistema deve oferecer um sistema de suporte para responder às dúvidas dos usuários. Isso pode ser implementado por meio de um sistema de chat ao vivo ou um formulário de contato. | MÉDIA | 


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
|02| Não pode ser desenvolvido um módulo de backend        |


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
