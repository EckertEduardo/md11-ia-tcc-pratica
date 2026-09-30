# Questão 11 — Evidência de uso real da IA

## Ferramenta usada
GitHub Copilot Chat no Visual Studio, em modo Agente, com o modelo GPT-5 mini.

Tentei primeiro o Claude Code, mas o login exige assinatura paga (Pro, Max,
Team ou Enterprise) ou conta Console com cobrança por uso, e eu uso o plano
gratuito do Claude. Por isso usei o Copilot.

## Como passei o contexto
O Copilot não lê o CLAUDE.md sozinho. Anexei manualmente, pelo chat
(`#file:`), três arquivos: `CLAUDE.md`, o `SKILL.md` da skill
`adicionar-operacao-tarefa` e o `Program.cs`.

## Prompt exato
```
Siga as instruções do CLAUDE.md e os passos do SKILL.md em anexo.
Crie a função Remover(int id) no Program.cs.
```

## O que a IA fez
Alterou só o `Program.cs` (+29 linhas, nenhuma removida):
- criou a função local `Remover(int id)` (23 linhas);
- acrescentou uma chamada de teste (`Remover(2)` e `Listar()`) antes do
  `Console.ReadLine()`.

Antes de aplicar, ele pediu permissão para compilar a solução.

## Ela seguiu o CLAUDE.md e a Skill?
| Instrução | Seguiu? |
|---|---|
| Nome em português e PascalCase (`Remover`) | Sim |
| Usar a lista de tuplas, sem criar classe | Sim |
| Tratar id inexistente com mensagem | Sim |
| Chaves sempre, `var`, interpolação de string | Sim |
| Chamada de teste antes do `Console.ReadLine()` | Sim |
| Não alterar funções existentes nem outros arquivos | Sim (`git status` mostrou só o `Program.cs`) |

## O que precisei ajustar
Nada no código: rodei `dotnet run` e a saída ficou correta (a tarefa #2
foi removida e a lista final mostrou só as tarefas #1 e #3).

Ressalva: o teste só chama `Remover(2)`, um id que existe. O caminho do id
inexistente está no código, mas nenhum teste o executa.