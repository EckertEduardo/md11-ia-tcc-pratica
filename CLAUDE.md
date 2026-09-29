# Guia do projeto — GerenciadorDeTarefas

## Contexto

Este repositório contém um projeto console em C# com .NET 8. A aplicação mantém tarefas em memória, permite adicioná-las, marcá-las como concluídas e listar seu estado. Não possui banco de dados, API, interface web ou menu interativo.

O programa cria três tarefas de exemplo, exibe a lista inicial, conclui a tarefa de ID 1 e exibe a lista novamente. Ao final, `Console.ReadLine()` aguarda uma entrada. Os dados são perdidos quando o processo termina.

## Estrutura

- `GerenciadorDeTarefas.sln`: solução do Visual Studio.
- `GerenciadorDeTarefas/GerenciadorDeTarefas.csproj`: projeto executável `net8.0`, com `ImplicitUsings` e `Nullable` habilitados.
- `GerenciadorDeTarefas/Program.cs`: toda a lógica, com instruções de nível superior e funções locais `Adicionar`, `Concluir` e `Listar`.
- `README.md`: enunciado e respostas teóricas.
- `CLAUDE.md`: contexto e diretrizes para a IA.
- `.claude/skills/revisar-gerenciador-tarefas/SKILL.md`: habilidade reutilizável de revisão.
- `EVIDENCIAS.md`: registro da atividade realizada.

## Comportamento e convenções

- As tarefas usam `List<(int Id, string Titulo, bool Concluida)>`.
- Os IDs começam em 1 e avançam a cada adição; uma tarefa nova recebe `Concluida = false`.
- `Concluir` procura pelo ID e substitui a tupla correspondente, preservando ID e título.
- `Listar` mantém a ordem de inserção e exibe `[ ]` para pendentes e `[X]` para concluídas.
- Preserve o estilo existente: nomes e mensagens em português, quatro espaços, chaves em linhas próprias, PascalCase nas funções e camelCase nas variáveis.
- O projeto não declara pacotes externos nem possui uma suíte de testes automatizados.

## Orientações para o assistente

- Leia este guia, a skill aplicável e o código atual antes de apresentar conclusões sobre o comportamento do código.
- Responda em português e indique os arquivos ou trechos que sustentam as conclusões.
- Diferencie fatos encontrados no código, resultados de comandos realmente executados e sugestões ainda não verificadas.
- Não altere o aplicativo, o projeto, a solução ou o template compartilhado de PR para realizar uma revisão. 
- Não adicione dependências ou funcionalidades sem uma solicitação que justifique essa mudança.
- Não inclua `bin/`, `obj/` ou configurações pessoais nos commits.
- Nunca invente testes, saídas, evidências ou resultados. 
- Se um comando falhar, registre a falha e o que ficou sem verificar.
- Ao finalizar uma tarefa, informe o que foi feito, como foi verificado e as limitações encontradas.