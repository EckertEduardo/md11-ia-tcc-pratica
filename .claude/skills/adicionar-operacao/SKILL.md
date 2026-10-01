---
name: adicionar-operacao
description: Usar ANTES de adicionar uma operação nova ao GerenciadorDeTarefas — remover, editar, listar só as pendentes, buscar, desfazer conclusão, ou qualquer outra coisa que mexa na lista de tarefas do Program.cs.
---

# Adicionar uma operação ao GerenciadorDeTarefas

Toda operação nova segue o molde das que já existem (`Adicionar`, `Concluir`, `Listar`).
O objetivo é o código continuar parecendo escrito pela mesma pessoa.

## Passos

1. **Ler o `GerenciadorDeTarefas/Program.cs` inteiro** antes de escrever. Ele é curto, e o
   estilo está todo ali.
2. **Escrever a operação como função local**, logo depois da última função que já existe
   (antes das chamadas de demonstração):
   - nome = verbo no infinitivo, em português: `Remover`, `Editar`, `ListarPendentes`;
   - parâmetro pelo `id` (`int id`) quando a operação age numa tarefa só;
   - chaves sempre, mesmo em `if` de uma linha.
3. **Respeitar as regras da lista:**
   - a tarefa é a tupla `(int Id, string Titulo, bool Concluida)` — não criar classe;
   - pra mudar uma tarefa, substituir o item inteiro: `tarefas[i] = (tarefas[i].Id, ..., ...)`;
   - o `proximoId` só cresce — remover não devolve o Id;
   - id que não existe: não faz nada e não estoura exceção (igual ao `Concluir`);
   - operação que mostra tarefas usa o mesmo formato do `Listar`: `[X] #1 — Título`.
4. **Demonstrar a operação** no fim do bloco de chamadas, antes do `Console.ReadLine()`,
   no mesmo padrão que já está lá:
   ```csharp
   Remover(2);

   Console.WriteLine();
   Console.WriteLine("=== Depois de remover a tarefa #2 ===");
   Listar();
   ```
5. **Rodar e conferir a saída:** `cd GerenciadorDeTarefas` e `echo | dotnet run` (o `echo`
   responde o `Console.ReadLine()` do final; sem ele o comando trava).
   Conferir no console que a operação fez o que devia — compilar não basta.
6. **Mostrar o diff e parar.** Não commitar.

## Não fazer
- Não criar arquivo, classe, interface ou namespace novo.
- Não reescrever as funções que já existem pra "melhorar" — só acrescentar.
- Não apagar o comentário do final do `Program.cs`.
- Não adicionar pacote NuGet.
