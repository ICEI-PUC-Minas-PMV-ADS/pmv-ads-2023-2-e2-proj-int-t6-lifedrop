# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos com os artefatos criados (código fonte), deverão apresentadas as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Por exemplo: a tabela a seguir deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| O sistema deve possibilitar ao usuário se registrar na plataforma. | CadastrarConta/index.cshtml  / site.css / UsuarioController.cs  | 
|RF-002| O sistema deve permitir ao usuário gerenciar o login. | Login/index.shtml / site.css / UsuarioController.cs |
|RF-003| O sistema deve permitir registrar e verificar o estoque disponível nos bancos de sangue. | AgendeDoacao/index.cshtml / site.css / AgendeDoacaoController.cs |
|RF-004| O sistema deve permitir ao doador gerenciar agendamentos. | MeuPerfil/index.cshtml / site.css / MeuPerfilController.cs| 
|RF-005| O sistema deve permitir o acesso ao histórico completo de doações do doador. | MeuPerfil/index.cshtml / site.css / MeuPerfilController.cs| 
|RF-006| O sistema deve verificar se o doador está apto para a doação antes de permitir que o doador agende uma doação. | AgendeDoacao/index.cshtml / site.css / AgendeDoacaoController.cs | 
|RF-007| O sistema deve permitir ao administrador dos bancos de sangue registrar emergências |AgendamentoAdministrador/index.cshtml / site.css / AdministradorController.cs |
|RF-008| O sistema deve permitir ao administrador do banco de sangue acessar o painel administrativo integrado.  |PainelAdministrador/index.cshtml / site.css / AdministradorController.cs|


# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
