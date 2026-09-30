---
name: adicionar-operacao-tarefa
description: Adiciona uma nova operação (ex.: remover, editar, listar pendentes) ao GerenciadorDeTarefas seguindo o estilo do Program.cs. Use quando eu pedir uma nova funcionalidade sobre as tarefas.
---

# Adicionar operação de tarefa

## Quando usar
Quando eu pedir uma nova operação sobre a lista de tarefas.

## Passos
1. Ler o `GerenciadorDeTarefas/Program.cs` inteiro antes de mexer.
2. Criar **uma** função local nova, junto das existentes (`Adicionar`,
   `Concluir`, `Listar`), com nome em português e PascalCase.
3. Usar a lista existente `List<(int Id, string Titulo, bool Concluida)>`.
   Não criar classes nem trocar a estrutura.
4. Tratar o caso de o id não existir e mostrar uma mensagem simples com
   `Console.WriteLine`.
5. Manter o formato de saída `[X] #1 — Título`.
6. Acrescentar uma chamada de teste da função no final do arquivo, antes
   do `Console.ReadLine()`.
7. Rodar `dotnet run` e conferir a saída.

## Resposta final
Explicar em poucas linhas, em português, o que foi criado e o que mudou
no arquivo.

## Não fazer
- Não alterar funções existentes sem eu pedir.
- Não instalar pacotes nem criar arquivos novos.