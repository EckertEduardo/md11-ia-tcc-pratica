# CLAUDE.md — GerenciadorDeTarefas

## O que é este projeto
Console app simples em C# que gerencia uma lista de tarefas em memória
(adicionar, concluir e listar). Serve de base para praticar o uso de IA
no desenvolvimento. Não usa banco de dados nem arquivos: os dados
existem só enquanto o programa roda.

## Como rodar
```bash
cd GerenciadorDeTarefas
dotnet run
```
Também abre pelo Visual Studio com `GerenciadorDeTarefas.sln`.

## Estrutura
- `GerenciadorDeTarefas/Program.cs`: todo o código do app (top-level
  statements, sem classes).
- `.claude/skills/`: skills reutilizáveis do projeto.
- `EVIDENCIAS.md`, `README.md`: entregáveis da avaliação (não alterar
  sem eu pedir).

## Como o código é organizado
- As tarefas ficam em `List<(int Id, string Titulo, bool Concluida)>`.
  Manter essa estrutura; não trocar por classe nem por outra coleção.
- O próximo id vem da variável `proximoId`, que só aumenta.
- Toda a lógica está em funções locais dentro do `Program.cs`:
  `Adicionar`, `Concluir` e `Listar`.

## Padrões de código
- Nomes de funções e variáveis em **português**.
- Funções em PascalCase (`Remover`); variáveis em camelCase
  (`tarefasPendentes`).
- Usar `var` quando o tipo é óbvio.
- Sempre usar chaves `{ }` em `if`, `for` e `foreach`, mesmo com uma linha.
- Interpolação de string (`$"..."`) em vez de concatenação.
- Formato de exibição das tarefas: `[X] #1 — Título` (concluída) e
  `[ ] #1 — Título` (pendente).
- Comentários curtos em português, só onde o código não for óbvio.

## Regras de trabalho
- Fazer **uma mudança pequena por vez** e mostrar o que mudou antes de
  seguir para a próxima.
- Novas funções seguem o estilo das existentes e ficam junto delas, antes
  das chamadas de teste no final do arquivo.
- Se algo estiver ambíguo (ex.: o que fazer quando o id não existe),
  **perguntar antes** de escolher.
- Depois de qualquer mudança, rodar `dotnet run` e conferir a saída.

## O que NÃO fazer
- Não criar classes, pastas novas ou projetos novos sem eu pedir.
- Não instalar pacotes NuGet.
- Não alterar `README.md`, `EVIDENCIAS.md` nem arquivos de configuração.
- Não mudar o formato de saída existente.
- Não apagar o `Console.ReadLine()` do final.

## Idioma
Conversar e comentar em português do Brasil, com explicações simples.