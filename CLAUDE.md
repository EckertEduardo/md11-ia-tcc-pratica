# Projeto: GerenciadorDeTarefas

O projeto adiciona uma tarefa a uma lista, permite marcar como concluída, e mostra tudo na tela.

## Stack
C#, .NET 8.0

## Como rodar
- dotnet run

## Estrutura
- A lista de tarefas é uma `List` de tuplas `(int Id, string Titulo, bool Concluida)`.
- O `Id` é gerado automaticamente por um contador (`proximoId`) que começa em 1 e incrementa a cada chamada de `Adicionar`.

## Regras/convenções
- Nomes dos métodos em português, PascalCase (ex: `Adicionar`, `Concluir`, `Listar`).
- `Concluir` avisa "id solicitado não foi encontrado" caso o Id não exista na lista.
- `Listar` sempre mostra todas as tarefas (concluídas e pendentes), sem filtro.

## O que a IA NÃO deve fazer
- Não criar uma classe `Tarefa` para substituir a tupla existente.
- Não traduzir os nomes dos métodos para inglês.
- Não remover o padrão de percorrer a lista com `for` sem necessidade.
- Não adicionar dependências externas (bibliotecas/pacotes) sem que eu peça.