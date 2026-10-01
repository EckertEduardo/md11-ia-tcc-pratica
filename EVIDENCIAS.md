# Evidência de uso real da IA

**Ferramenta:** Claude Code, com acesso ao repositório local deste fork.

Fiz dois testes. O primeiro criou o `CLAUDE.md` e a skill; o segundo, numa sessão nova, provou
que eles funcionam sozinhos.

---

## Teste 1 — criando o CLAUDE.md e a skill

**O que eu pedi:** que a IA escrevesse o `CLAUDE.md`, depois a skill, e depois usasse a skill
numa tarefa real, sem commitar nem abrir o PR. A tarefa foi a que o comentário do `Program.cs`
sugere: **remover uma tarefa**.

**O que ela fez:**
1. Antes de escrever o `CLAUDE.md`, rodou o app e achou uma pegadinha: o `Console.ReadLine()` do
   final deixa o `dotnet run` parado esperando Enter, o que trava um agente. A solução
   (`echo | dotnet run`) entrou no `CLAUDE.md`.
2. Renomeou a pasta `minha-skill/` pra `adicionar-operacao/` e escreveu o passo a passo de como
   acrescentar uma operação no estilo do `Program.cs`.
3. Seguiu a skill pra criar o `Remover(int id)` e rodou pra conferir — a #2 sumiu e a #3 manteve
   o Id 3:
   ```
   === Depois de remover a tarefa #2 ===
   [X] #1 — Estudar para a avaliação do Módulo 11
   [ ] #3 — Criar uma Skill reutilizável
   ```
4. Parou sem commitar.

**O furo:** a sessão foi aberta na pasta de outro projeto meu, então o `CLAUDE.md` e a skill não
foram carregados sozinhos — a IA seguiu a skill porque tinha acabado de escrevê-la. Isso não
prova que os arquivos funcionam. Daí o segundo teste.

---

## Teste 2 — sessão nova, IA sem contexto

Abri uma **sessão nova dentro desta pasta**, sem nada da conversa anterior.

**O prompt exato:**

> esse é o teste com uma IA zerada que faltou em evidencias

Ela leu este arquivo, viu que o teste pendente era pedir outra operação (ex.: listar só as
pendentes) e escolheu essa tarefa.

**O que ela fez:**
1. **Carregou o `CLAUDE.md` sozinha** e leu o `Program.cs` inteiro antes de escrever.
2. **Invocou a skill `adicionar-operacao` por conta própria**, porque o `CLAUDE.md` manda usá-la
   pra qualquer operação nova.
3. Criou o `ListarPendentes()` como função local, logo depois do `Remover`, com o mesmo formato
   de saída do `Listar`.
4. Rodou com `echo | dotnet run` — não travou — e conferiu: a #1, concluída, ficou de fora.
   ```
   === Só as tarefas pendentes ===
   [ ] #3 — Criar uma Skill reutilizável
   ```
5. Mostrou o diff e parou sem commitar.

---

## Ela seguiu o CLAUDE.md e a skill?

**Sim, nos dois testes:** tupla em vez de classe, função local com verbo no infinitivo em
português, chaves sempre, Id nunca reaproveitado, nenhum arquivo, classe ou pacote novo, o
comentário do final do `Program.cs` intacto, e nada commitado.

## O que aprendi e o que precisei ajustar

- **O `CLAUDE.md` sai melhor quando se roda o projeto antes de escrever.** Eu não sabia do
  problema do `Console.ReadLine()`; a IA achou rodando o programa.
- **Só uma sessão zerada testa a documentação.** No primeiro teste eu estava testando a memória
  da conversa, não os arquivos. Sem o segundo, eu não saberia se eles funcionam sozinhos.
- **No código, nada precisou de ajuste.** O atrito foi de ambiente: no segundo teste ela tentou
  editar o `Program.cs` por script e errou algumas vezes (sem `python` no PATH, e um `sed` que não
  pegou os acentos) até acertar. Por isso conferir a saída do programa vale mais do que confiar
  que a edição deu certo.
