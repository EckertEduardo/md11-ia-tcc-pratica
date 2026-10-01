# Avaliação Individual — Módulo 11 — Tecnologias Emergentes e IA

**Data de entrega:** DD/MM/AAAA
**Formato:** individual, de consulta aberta — use slides, anotações e a própria IA à vontade para pesquisar e testar suas respostas.

## Como participar

1. Faça um **fork** deste repositório.
2. Clone o seu fork localmente.
3. Responda as questões teóricas **direto neste README**, abaixo de cada uma.
4. Complete a parte prática (veja abaixo) editando `CLAUDE.md`, `.claude/skills/minha-skill/SKILL.md` e `EVIDENCIAS.md`.
5. Abra um **Pull Request** do seu fork de volta para este repositório.

> O PR não será mergeado — ele existe só para eu avaliar o seu diff. Pode deixar aberto depois de enviar.

O objetivo não é decorar definições, e sim demonstrar que você entende os conceitos e sabe aplicá-los para ganhar eficiência ao usar IA no seu projeto de TCC. Responda com suas próprias palavras — copiar e colar resposta pronta de IA sem entender não demonstra o aprendizado esperado.

---

## Questões dissertativas

### Questão 1 — O que é um "agent"?
O que é um "agent" (agente de IA)? Explique com suas próprias palavras e dê um exemplo de situação em que faz mais sentido usar um agente do que um chat comum.

**Sua resposta:**
Um agente age sozinho numa tarefa: ele lê os arquivos, roda comandos, vê o resultado e decide o próximo passo até terminar. Um chat só lê o que foi perguntado e responde, em vez de pesquisar o conjunto inteiro. Faz mais sentido usar um agente quando a tarefa depende do projeto todo, por exemplo caçar um bug: ele procura onde o erro nasce, corrige e roda os testes.

### Questão 2 — O que são guidelines?
O que são "guidelines" (diretrizes) ao usar uma IA generativa? Qual é o papel delas na qualidade das respostas geradas pelo modelo?

**Sua resposta:**
Guidelines são regras que limitam o que a IA pode fazer, por exemplo não deletar o win32 do PC ou não commitar sem eu aprovar. Elas melhoram a qualidade porque a IA segue o padrão do meu projeto e eu não preciso corrigir a mesma coisa toda vez.

### Questão 4 — Escolha de modelo e nível de esforço
Qual modelo de IA utilizar para cada tipo de tarefa? Dê um exemplo de tarefa simples e outra mais complexa, explicando como você escolheria o modelo em cada caso. O que é o "nível de esforço" (effort level) e quando faz sentido aumentá-lo ou diminuí-lo?

**Sua resposta:**
Para tarefas simples, como mudar nomes de variáveis, dá pra usar um Haiku, que é mais rápido e barato. Para tarefas que exigem um bate-papo até chegar em alguma conclusão, eu gosto de usar o Sonnet no médio. Quando é algo muito mais complexo e maior, que engloba uma rede de arquivos, eu gosto de aumentar o esforço. O esforço é o quanto a IA pensa antes de responder: quanto mais, mais demora e mais gasta. Se for uma tarefa que já tem um plano traçado e o meu harness já sabe fazer com base nas minhas tarefas e skills, eu posso usar o Sonnet.

### Questão 5 — Como estruturar um bom prompt
Descreva os elementos que tornam um prompt mais eficaz (ex.: contexto, objetivo, formato esperado, exemplos, restrições).

**Sua resposta:**
Quanto mais detalhes e CONTEXTO você entregar, melhor ela sabe o que entregar. Além do contexto, o prompt fica melhor quando diz o objetivo, o formato que eu quero, exemplos e restrições (o que ela não pode fazer). Existe uma skill muito boa em que a IA te entrevista pra saber se o que você pediu é aquilo mesmo.

### Questão 6 — Iteração de prompt
O que significa "iterar" um prompt? Por que a primeira resposta de uma IA geralmente não é a versão final, e como você usaria a resposta recebida para melhorar o próximo prompt?

**Sua resposta:**
Iterar é usar a resposta da IA pra melhorar o próximo prompt. A primeira resposta geralmente não é a final porque às vezes eu não formulei bem a pergunta e faltou algo pra direcionar melhor a IA. Uma forma é editar o mesmo prompt: o chat volta antes daquele ponto e começa de novo, agora com o que faltou.

### Questão 7 — Zero-shot vs. few-shot
Qual é a diferença entre um prompt "zero-shot" e um prompt "few-shot"? Dê um exemplo de situação em que vale a pena incluir exemplos dentro do próprio prompt.

**Sua resposta:**
Zero-shot é quando eu peço sem dar nenhum exemplo, e few-shot é quando eu mando alguns exemplos junto pra IA seguir o mesmo padrão. Vale a pena mandar exemplo quando o formato importa, por exemplo pedir a descrição de uma habilidade nova no mesmo estilo das que já existem no meu jogo.

### Questão 8 — Memória e contexto entre sessões
O que significa uma IA "ter memória" entre sessões diferentes de conversa? Por que, em um projeto longo como o TCC, é importante decidir o que precisa ser "lembrado" e como fornecer esse contexto para a IA a cada nova conversa?

**Sua resposta:**
Memória é como ela sabe meu nome entre sessões ou que eu estudo C#. Ela guarda partes da conversa em arquivos que são carregados em cada conversa nova, pra trabalhar com você de um jeito que você já esteja acostumado, então ela se adapta ao usuário. Num projeto longo é importante decidir o que lembrar, porque o contexto tem limite. Uma forma que eu gosto de manter essa memória é pedir pra ela mesma gerar um documento de contexto no fim da sessão pra próxima começar dali. O /compact faz a mesma coisa dentro da conversa: ele usa as próprias regras pra resumir o que já foi falado e manda esse contexto pra frente. Eu acho que o contexto escrito por mim ainda economiza mais, mas isso é impressão minha, ainda não testei.

### Questão 9 — Avaliar a resposta da IA
Antes de aplicar a sugestão de uma IA no seu projeto, como você verifica se ela está correta? Descreva pelo menos 2 formas práticas de checar a confiabilidade de uma resposta gerada por IA.

**Sua resposta:**
A primeira forma é rodar e testar: se rodar errado, não está certo, e se rodar, talvez ainda não seja a melhor forma de fazer aquilo. A outra forma é ler o que ela fez, ter conhecimento e martelar até chegar numa forma melhor, comparando com a documentação quando tiver dúvida.

### Questão 10 — Dividir tarefas complexas em etapas
Por que, em tarefas mais complexas, pode ser melhor dividir o trabalho em um fluxo de etapas (ex.: primeiro classificar/organizar, depois processar, depois revisar) em vez de pedir tudo em um único prompt? Dê um exemplo aplicado a uma tarefa do seu TCC.

**Sua resposta:**
Dividir é melhor porque cada etapa fica menor e dá pra revisar antes de seguir: se der erro, eu pego cedo e não estraga o resto. No meu TCC, o No Prumo, primeiro decidimos fazer todas as entidades e agora vamos começar as páginas de fato. Isso já vai adiantar muito o projeto, porque as páginas usam as entidades, então agora é a parte fácil.

> **Questão 3** (como escrever um bom CLAUDE.md) e a **Questão 11** (prática, evidência de uso real da IA) são respondidas nos próprios arquivos `CLAUDE.md` e `EVIDENCIAS.md` — veja a parte prática abaixo.

---

## Parte prática

1. **Complete o `CLAUDE.md`** na raiz deste repositório — é onde você responde a Questão 3, documentando o projeto para orientar um assistente de IA.
2. **Complete a Skill** em `.claude/skills/minha-skill/SKILL.md`, com instruções reutilizáveis para uma tarefa recorrente do projeto. Renomeie a pasta `minha-skill/` para o nome real da sua skill.
3. **Conecte um assistente de IA ao código local** (Claude Code, GitHub Copilot, Cursor, ou outro de sua escolha) e use-o pelo menos uma vez de verdade, aplicando o `CLAUDE.md` e/ou a Skill que você criou em uma tarefa real do projeto `GerenciadorDeTarefas`.
4. **Complete o `EVIDENCIAS.md`** — é onde você responde a Questão 11, documentando essa experiência (ferramenta usada, prompt exato, o que a IA fez, se seguiu suas instruções).

### O que NÃO fazer

- ❌ Copiar as respostas, o CLAUDE.md ou a Skill de um colega
- ❌ Inventar uma evidência que não aconteceu de verdade
- ❌ Alterar arquivos fora do escopo pedido

## Sobre o projeto de exemplo

Dentro de `GerenciadorDeTarefas/` tem um console app simples em C# — um gerenciador de tarefas fictício — que serve de base para você praticar. Não é necessário adicionar funcionalidades novas ao app; o foco é a configuração e o uso da IA em cima desse código.

Abra `GerenciadorDeTarefas.sln` no Visual Studio, ou rode pelo terminal:

```bash
cd GerenciadorDeTarefas
dotnet run
```

---

## Critérios de avaliação (10 pontos)

| Critério | Pontos |
|---|---|
| Questões dissertativas (conjunto) | 4 |
| `CLAUDE.md` bem estruturado e específico ao projeto (Questão 3) | 2 |
| Skill funcional e realmente reutilizável | 2 |
| `EVIDENCIAS.md` — uso real da IA, seguindo (ou não) o CLAUDE.md/Skill (Questão 11) | 1 |
| Qualidade do Pull Request (descrição clara, organizado, dentro do escopo) | 1 |

## Entrega

Envie o **link do seu Pull Request** pelo Akademos até a data acima.
