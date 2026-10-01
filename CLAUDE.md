# GerenciadorDeTarefas — guia pro Claude

Console app em C# que adiciona, conclui e lista tarefas numa lista em memória. É um projeto de
**estudo**, pequeno de propósito: serve pra praticar o uso de IA em cima de um código simples.
Não tem banco, arquivo, nem entrada do usuário — as tarefas são criadas no próprio código.

## Comandos
- Rodar: `cd GerenciadorDeTarefas` e `dotnet run`
- Só compilar: `dotnet build`
- **Pegadinha:** o programa termina com `Console.ReadLine()`, então o `dotnet run` fica parado
  esperando um Enter. Rodando pelo terminal do agente, mandar o Enter junto: `echo | dotnet run`.
- Não tem projeto de testes. A verificação é rodar e conferir a saída no console.

## Como o código é (e deve continuar sendo)
- **Tudo em `GerenciadorDeTarefas/Program.cs`**, com top-level statements. Sem classes, sem
  namespaces, sem arquivos novos.
- A lista é `List<(int Id, string Titulo, bool Concluida)>` — uma tupla nomeada, não uma classe.
- Cada operação é uma **função local** com nome de verbo no infinitivo, em português:
  `Adicionar`, `Concluir`, `Listar`. Uma operação nova segue o mesmo padrão (ex.: `Remover`).
- O `Id` vem do contador `proximoId`, que só cresce. Remover uma tarefa **não** reaproveita o Id.
- A tupla é imutável: pra mudar uma tarefa, substitui o item inteiro na lista
  (`tarefas[i] = (...)`), como o `Concluir` faz.
- A saída usa o formato `[X] #1 — Título` (concluída) e `[ ] #1 — Título` (pendente).
- `.NET 8`, com `ImplicitUsings` e `Nullable` ligados.
- Nomes de variáveis e textos em português.

## Para adicionar uma operação nova
Usar a skill `adicionar-operacao` (em `.claude/skills/`).

## O que NÃO fazer
- Não transformar o projeto em classes, camadas, interfaces ou "arquitetura" — ele é simples de propósito.
- Não adicionar pacotes NuGet.
- Não mudar o `TargetFramework` nem o `.csproj` sem eu pedir.
- Não mexer no `README.md` (ele é o enunciado da avaliação) nem em arquivos fora do que foi pedido.
- Não apagar o comentário do final do `Program.cs`.
- **Não commitar nem dar push.** Mostrar o que mudou e esperar eu aprovar.
