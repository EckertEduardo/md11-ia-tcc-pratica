# CLAUDE.md — GerenciadorDeTarefas

## Visão geral

Console app em C# (.NET 8) que simula um gerenciador de tarefas simples:
adicionar tarefa, concluir tarefa por id e listar tarefas com status
`[ ]`/`[X]`. É um projeto de estudo (avaliação do Módulo 11), não um
produto real — o foco é praticar o uso de IA sobre um código pequeno e
legível, não adicionar features.

## Como rodar/buildar

```bash
cd GerenciadorDeTarefas
dotnet build
dotnet run
```

Também pode ser aberto via `GerenciadorDeTarefas.sln` no Visual Studio/Rider.
Não há testes automatizados nem dependências externas (projeto sem NuGet
packages).

## Estrutura real de pastas e classes

```
GerenciadorDeTarefas.sln
GerenciadorDeTarefas/
  GerenciadorDeTarefas.csproj   # net8.0, ImplicitUsings + Nullable habilitados
  Program.cs                     # único arquivo de código, top-level statements
```

Não existem classes nem namespaces próprios. `Program.cs` é tudo:

- `tarefas` — `List<(int Id, string Titulo, bool Concluida)>`, a "base de dados" em memória (tupla nomeada, não um record/classe).
- `proximoId` — `int` incrementado a cada `Adicionar`.
- `Adicionar(string titulo)` — cria a tarefa e adiciona à lista.
- `Concluir(int id)` — percorre a lista com `for` e substitui a tupla cujo `Id` casa, marcando `Concluida = true`.
- `Listar()` — imprime cada tarefa no formato `[ ] #1 — Titulo` / `[X] #1 — Titulo`.

## Convenções observadas no código existente

- **Idioma**: tudo em português — nomes de variáveis, funções e comentários (`tarefas`, `titulo`, `Concluida`, `Adicionar`, `Concluir`, `Listar`). Mantenha esse padrão em qualquer código novo.
- **Estilo C#**: top-level statements (sem `class Program`, sem `static void Main`); funções locais declaradas com `void NomeFuncao(...)`.
- **Casing**: `camelCase` para variáveis locais (`tarefas`, `proximoId`); `PascalCase` para funções e para os campos da tupla (`Id`, `Titulo`, `Concluida`).
- **Modelo de dados**: tarefa é representada por tupla nomeada `(int Id, string Titulo, bool Concluida)`, não por classe/record — ao adicionar campos ou operações novas, siga esse padrão em vez de introduzir um tipo novo sem necessidade.
- **Chaves**: estilo Allman (chave `{` em linha própria), indentação de 4 espaços.
- **Saída**: `Console.WriteLine` com string interpolation; separador visual `—` (em dash) entre id e título.

## O que a IA deve fazer

- Seguir os nomes em português e o padrão de tupla já estabelecido ao propor novas operações (ex.: remover tarefa, listar só pendentes).
- Manter o código dentro de `Program.cs` como top-level statements, igual ao restante do arquivo, a menos que o usuário peça explicitamente para reestruturar em classes.
- Explicar mudanças de forma objetiva, já que o projeto é didático.

## O que a IA NÃO deve fazer

- Não adicionar funcionalidades novas ao app por conta própria — o README deixa claro que isso não é necessário; só faça se for explicitamente pedido.
- Não introduzir dependências externas (NuGet, frameworks de teste, etc.) sem pedido explícito.
- Não reescrever o projeto para usar classes, DI, banco de dados ou arquitetura em camadas — isso contraria o propósito didático e simples do exemplo.
- Não alterar `README.md` nem `EVIDENCIAS.md`.
- Não traduzir nomes de variáveis/funções para inglês.
