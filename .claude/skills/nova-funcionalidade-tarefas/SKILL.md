---
name: nova-funcionalidade-tarefas
description: Use esta skill sempre que for adicionar uma nova operação ao GerenciadorDeTarefas (ex.: remover tarefa, listar só pendentes, editar título, contar tarefas concluídas) seguindo exatamente o padrão já usado em Program.cs — tupla nomeada, funções locais em português, top-level statements.
---

# Nova funcionalidade no GerenciadorDeTarefas

Skill para implementar uma nova operação sobre a lista de tarefas em
`GerenciadorDeTarefas/Program.cs`, mantendo o código consistente com o que
já existe (sem introduzir classes, DI, banco de dados ou dependências).

## Passos

1. **Ler `Program.cs` inteiro antes de editar.** Identificar o modelo de dados atual (`tarefas`, tupla `(int Id, string Titulo, bool Concluida)`) e as funções existentes (`Adicionar`, `Concluir`, `Listar`) para replicar o estilo.
2. **Nomear a nova função em português, `PascalCase`**, coerente com o domínio (ex.: `Remover`, `ListarPendentes`, `Editar`, `ContarConcluidas`). Parâmetros em `camelCase`.
3. **Implementar como função local**, no mesmo estilo de `void Concluir(int id) { ... }` — usar `for`/`foreach` sobre `tarefas`, chaves em linha própria (Allman), 4 espaços de indentação. Não criar classe nova para isso.
4. **Se precisar alterar uma tarefa existente**, lembrar que a tupla é imutável: seguir o padrão de `Concluir`, reconstruindo a tupla inteira (`tarefas[i] = (tarefas[i].Id, novoValor, tarefas[i].Concluida)`), nunca tentar mutar um campo direto.
5. **Adicionar uma chamada de exemplo** da nova função perto das chamadas já existentes (`Adicionar(...)`, `Concluir(1)`, `Listar()`), para a funcionalidade aparecer rodando na saída do console — igual ao padrão "adicionar, mostrar, mudar estado, mostrar de novo" já usado no arquivo.
6. **Validar com `dotnet run`** dentro de `GerenciadorDeTarefas/` e confirmar que a saída no console mostra o comportamento esperado (ex.: tarefa removida não aparece mais em `Listar()`).
7. **Não tocar em `README.md`, `EVIDENCIAS.md` ou `CLAUDE.md`** ao executar esta skill — ela cobre apenas código em `Program.cs`.
