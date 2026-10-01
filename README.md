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

É um modelo de linguagem que não apenas responde uma pergunta, mas executa um loop.

Explicação: Ele recebe uma tarefa, decide o que fazer, usa determinadas ferramentas e observa o resultado e repete até concluir a mesma.

Exemplo: Quando você precisa criar um site com HTML semântico, CSS e JavaScript bem estruturado você usa um agent em vez de um chat comum.


### Questão 2 — O que são guidelines?
O que são "guidelines" (diretrizes) ao usar uma IA generativa? Qual é o papel delas na qualidade das respostas geradas pelo modelo?

**Sua resposta:**

São regras que você dá para a IA e ela tem que seguir as mesmas, elas servem para que você não tenha que sempre repetir as mesmas coisas para a IA e para o agent fazer.


### Questão 4 — Escolha de modelo e nível de esforço
Qual modelo de IA utilizar para cada tipo de tarefa? Dê um exemplo de tarefa simples e outra mais complexa, explicando como você escolheria o modelo em cada caso. O que é o "nível de esforço" (effort level) e quando faz sentido aumentá-lo ou diminuí-lo?

**Sua resposta:**

O nível de esforço é quanto você quer utilizar da capacidade da IA, quando você quer fazer um TCC de algo complexo você aumenta e quando é uma pergunta simples de "sim" ou "não" você diminuí.

Tarefa simples: Quero tirar um pequena dúvida de onde posso comprar um determinado produto, remédio ou comida eu uso o "nível de esforço" mais fraco da IA.

Tarefa complexa: Quero fazer um TCC que tem vários requisitos, eu uso um "nível de esforço" maior para a IA me entregar as melhores respostas para eu não passar vergonha por ter algo errado no meu TCC.


### Questão 5 — Como estruturar um bom prompt
Descreva os elementos que tornam um prompt mais eficaz (ex.: contexto, objetivo, formato esperado, exemplos, restrições).

**Sua resposta:**

Seja bastante detalhista falando os mínimos detalhes para a IA fazer o que você quer.


### Questão 6 — Iteração de prompt
O que significa "iterar" um prompt? Por que a primeira resposta de uma IA geralmente não é a versão final, e como você usaria a resposta recebida para melhorar o próximo prompt?

**Sua resposta:**

Iterar um prompt é refazer um pedido com base no seu pedido anterior, em vez de esperar a IA acertar de primeira.

A primeira resposta da IA nunca será ideal, por isso é sempre bom analisar a resposta que a IA te entregou, passo a passo: Primeiro você compara o prompt que você enviou com a resposta da IA, se a resposta não for o que você pediu altere o prompt e identifique o que a IA fez de errado e reescreva o prompt falando que ela fez de errado.


### Questão 7 — Zero-shot vs. few-shot
Qual é a diferença entre um prompt "zero-shot" e um prompt "few-shot"? Dê um exemplo de situação em que vale a pena incluir exemplos dentro do próprio prompt.

**Sua resposta:**

Zero-Shot: Você pede uma tarefa para a IA, sem dar nenhum exemplo de como terá que ser a resposta final, a IA usa apenas o que ela já "sabe" para fazer o formato.

Few-Shot: Você pede uma tarefa para a IA, dando exemplos dentro do prompt de como deve ser o formato do resultado, para a IA seguir os mesmo padrão que foi pedido no prompt.

Exemplo: Quando a resposta que você quer é específica e difícil de descrever só com regras, se você quer que a IA gere alguns testes seguindo um padrão exato de nomenclatura e estrutura que sua equipe usa, fica mais fácil mostrar 2 exemplos reais padrão do que tentar explicar todas as regras em texto.


### Questão 8 — Memória e contexto entre sessões
O que significa uma IA "ter memória" entre sessões diferentes de conversa? Por que, em um projeto longo como o TCC, é importante decidir o que precisa ser "lembrado" e como fornecer esse contexto para a IA a cada nova conversa?

**Sua resposta:**

Significa que ela armazena as conversas para no "futuro" sem você ter que reexplicar tudo para ela novamente, sem isso toda nova conversa começa sem ela saber os detalhes, se você pedir algo para a IA tipo "Você lembra o nome do meu Projeto e qual linguagem estou usando?", com isso ela procura na memória até achar, se ela não achar ela irá te responder dizendo que não achou em nenhuma conversa anterior.

Porque é importante para o TCC: É importante em um projeto bem longo como o TCC, porque o projeto vai mudando conforme o tempo vai passando, como as tecnologias escolhidas, as decisões de arquitetura, nomes das entidades e ter que sempre em toda nova conversa explicar isso novamente é uma grande perda de tempo e você pode acabar esquecendo algum detalhe importante, por isso vale a pena pedir para a IA armazenar determinadas partes de alguns chats ao longo do tempo.


### Questão 9 — Avaliar a resposta da IA
Antes de aplicar a sugestão de uma IA no seu projeto, como você verifica se ela está correta? Descreva pelo menos 2 formas práticas de checar a confiabilidade de uma resposta gerada por IA.

**Sua resposta:**

Pedir uma segunda análise para a IA, com um "nível de esforço" maior ou pedindo para um agente analisar, pedir para a mesma IA reanalisar a resposta com um "nível maior de esforço/atenção", ou levar a resposta para outra IA revisar, ajuda a encontrar erros facilmente que passaram despercebidos na primeira resposta.


### Questão 10 — Dividir tarefas complexas em etapas
Por que, em tarefas mais complexas, pode ser melhor dividir o trabalho em um fluxo de etapas (ex.: primeiro classificar/organizar, depois processar, depois revisar) em vez de pedir tudo em um único prompt? Dê um exemplo aplicado a uma tarefa do seu TCC.

**Sua resposta:**

É importante dividir tarefas complexas em etapas para não sobrecarregar a IA para ela não acabar te entregando respostas indesejadas/erradas ou faltando alguma coisa. Isso acontece quando você pede tudo de uma vez, os erros são gerados com mais facilidade e podem se acumular: se alguma etapa inicial(Domain) sai errada, tudo o que foi construído em cima dela sai errado também.

Exemplo: Quando eu estava fazendo os controllers, pedi um por um para não acabar sobrecarregando a IA com muita coisa, porque se ela me mandasse um controller errado eu corrigia ele sozinho sem comprometer os outros ou sem que a IA misturasse tudo apenas em um.


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
