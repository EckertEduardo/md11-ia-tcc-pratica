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
Um agent é uma IA que não só responde, mas também age. Ela recebe tarefas, decide e organiza os passos, usa ferramentas quando necessário(ler, editar, rodar comandos, busca na internet), confere o resultado e corrige caso exista algum erro até a tarefa ser concluída. O uso de um agente faz mais sentido quando a tarefa mexe em vários arquivos do projeto. Por exemplo, na hora de criar um sistema web, pedir a criação de controllers, DTOs, seguindo um certo padrão, exige que o agente leia o código padrão, crie os arquivos pedidos e rode para ver se existe algum erro.


### Questão 2 — O que são guidelines?
O que são "guidelines" (diretrizes) ao usar uma IA generativa? Qual é o papel delas na qualidade das respostas geradas pelo modelo?

**Sua resposta:**
São instruções e regras que determinamos para que a IA saiba como deve trabalhar, como por exemplo, padrão de código(que linguagem utilizar), idioma, o que deve ou não ser feito, estilo, entre outras definições. Essas regras ajudam a melhorar a qualidade do que queremos realizar porque tiramos da IA a parte da adivinhação, sem ter uma diretriz ela pode acabar respondendo ou realizando tarefas de forma genérica e fugir do padrão que queremos para o projeto.


### Questão 4 — Escolha de modelo e nível de esforço
Qual modelo de IA utilizar para cada tipo de tarefa? Dê um exemplo de tarefa simples e outra mais complexa, explicando como você escolheria o modelo em cada caso. O que é o "nível de esforço" (effort level) e quando faz sentido aumentá-lo ou diminuí-lo?

**Sua resposta:**
A escolha de modelo de IA depende da tarefa que você quer realiza, para tarefas simples como renomear uma variável ou corrigir um erro de digitação, podemos utilizar o Haiku, da família Claude. Já em tarefas mais complexas como projetar como o controle de estoque se conecta com outras partes do sistema, utilizamos Sonnet ou Opus. O nível de esforço determina o quanto a IA "pensa" antes de responder, ele é aumentado quando a tarefa é mais complexa e diminuido quando é uma operação simples.


### Questão 5 — Como estruturar um bom prompt
Descreva os elementos que tornam um prompt mais eficaz (ex.: contexto, objetivo, formato esperado, exemplos, restrições).

**Sua resposta:**
Um bom prompt deve existir contexto, ou seja, quem sou eu, qual o projeto, se já existe algum esqueleto do projeto estruturado. Também é importante ter um objetivo bem definido, passando pra IA exatamente o que deseja alcançar. Outra questão é o formato esperado, que tipo de código vai ser utilizado, comentários, tabelas, listas. Exemplos também ajudam muito no entendimento daquilo que você deseja, mostrar como você espera que o resultado seja. Além de claro, restrições, tudo aquilo que não pode ser feito, tecnologias para evitar e também idiomas.


### Questão 6 — Iteração de prompt
O que significa "iterar" um prompt? Por que a primeira resposta de uma IA geralmente não é a versão final, e como você usaria a resposta recebida para melhorar o próximo prompt?

**Sua resposta:**
É basicamente melhorar o prompt a cada interação com a IA. Avalio aquilo que ela me deu como resposta ao meu pedido e refaço ele com mais precisão, detalhes. A primeira resposta geralmente não é a que queremos porque acaba passando despercebido algumas coisas que deveriam ter sido ditas na primeira interação. Com essa resposta incompleta, analisa-se aquilo que foi respondido para ver o que faltou ou o que a IA possa ter entendido errado e no próximo prompt isso é lapidado para que assim consiga cobrir tudo aquilo que é esperado.


### Questão 7 — Zero-shot vs. few-shot
Qual é a diferença entre um prompt "zero-shot" e um prompt "few-shot"? Dê um exemplo de situação em que vale a pena incluir exemplos dentro do próprio prompt.

**Sua resposta:**
A diferença entre os dois está na inclusão ou não de exemplos dentro do seu pedido. O zero-shot é quando você pede algo sem exemplo, a IA vai se basear naquilo que ela já sabe e o few-shot você descreve um ou mais exemplos daquilo que se espera como resultado dentro do prompt. Vale a pena usar o few-shot quando aquilo que você vai pedir é mais específico e complexo para explicar apenas com palavras, por exemplo, fazer uma tela do front baseado em outra tela já existente dentro do projeto.


### Questão 8 — Memória e contexto entre sessões
O que significa uma IA "ter memória" entre sessões diferentes de conversa? Por que, em um projeto longo como o TCC, é importante decidir o que precisa ser "lembrado" e como fornecer esse contexto para a IA a cada nova conversa?

**Sua resposta:**
Significa que a IA guarda informações importantes, como preferências, decisões dentro de um projeto, para serem usadas em conversas futuras. Em um trabalho longo, como o TCC, isso importa porque existem muitas decisões que não podem ser esquecidas, como padrões, regras de negócio, entre outros. Por isso é importante deixar bem claro o que é preciso lembrar e fornecer isso a cada nova conversa, para não se perder tempo repetindo ou começando do zero a cada nova interação.


### Questão 9 — Avaliar a resposta da IA
Antes de aplicar a sugestão de uma IA no seu projeto, como você verifica se ela está correta? Descreva pelo menos 2 formas práticas de checar a confiabilidade de uma resposta gerada por IA.

**Sua resposta:**
O mais simples é executar o código, para ver se há algum tipo de erro, ver se compila tudo certinho. Conferir e testar os Swaggers, se as respostas são aquelas esperadas para cada campo criado. Também podemos sempre conferir na documentação oficial, no caso do C# através da Microsoft. Além de, claro, ler e enteder aquilo que o código.


### Questão 10 — Dividir tarefas complexas em etapas
Por que, em tarefas mais complexas, pode ser melhor dividir o trabalho em um fluxo de etapas (ex.: primeiro classificar/organizar, depois processar, depois revisar) em vez de pedir tudo em um único prompt? Dê um exemplo aplicado a uma tarefa do seu TCC.

**Sua resposta:**
Funciona melhor porque pedir para ser tudo feito de uma vez sobrecarrega a IA, ela tende a esquecer alguns detalhes importantes, misturar assuntos e até mesmo inventar algumas coisas ao longo do processo. Fazendo isso em etapas, as respostas são menores, mais fácil de serem analisadas por nós e testadas antes de seguir para os próximos passos. Por exemplo, no projeto integrador, na parte que ficou de minha responsabilidade, ela serviu de auxílio para listar o que já existia e organizar um plano de ação, estruturar com base naquilo que já tinha feito por outros colegas, para seguirmos no mesmo padrão. Assim ficou mais fácil para eu conseguir analisar e executar de maneira mais eficaz.


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
