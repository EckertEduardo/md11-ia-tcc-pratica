# Avaliação Individual — Módulo 11 — Tecnologias Emergentes e IA

**Data de entrega:** 29/09/2026

**Aluno:** Gabriel Becker

**Formato:** individual, de consulta aberta — use slides, anotações e a própria IA à vontade para pesquisar e testar suas respostas.

## Como participar

1. Faça um **fork** deste repositório.
2. Clone o seu fork localmente.
3. Responda as questões teóricas **direto neste README**, abaixo de cada uma.
4. Complete a parte prática (veja abaixo) editando `CLAUDE.md`, `.claude/skills/revisar-gerenciador-tarefas/SKILL.md` e `EVIDENCIAS.md`.
5. Abra um **Pull Request** do seu fork de volta para este repositório.

> O PR não será mergeado — ele existe só para eu avaliar o seu diff. Pode deixar aberto depois de enviar.

O objetivo não é decorar definições, e sim demonstrar que você entende os conceitos e sabe aplicá-los para ganhar eficiência ao usar IA no seu projeto de TCC. Responda com suas próprias palavras — copiar e colar resposta pronta de IA sem entender não demonstra o aprendizado esperado.

---

## Questões dissertativas

### Questão 1 — O que é um "agent"?
O que é um "agent" (agente de IA)? Explique com suas próprias palavras e dê um exemplo de situação em que faz mais sentido usar um agente do que um chat comum.

**Sua resposta:**

Um agente de IA é um sistema que consegue realizar uma tarefa em várias etapas a partir de um objetivo. 
Ele usa um modelo para interpretar o pedido, decidir o que fazer e utilizar as ferramentas disponíveis, como consultar arquivos ou executar comandos.
Por exemplo, para investigar um erro que envolve vários arquivos de um programa, um agente pode ler o código, localizar a causa, propor uma correção e executar verificações.
Isso faz sentido porque a tarefa exige ações e acompanhamento dos resultados. 
Já para entender o significado de um conceito ou esclarecer uma dúvida pontual, um chat comum costuma ser suficiente.

### Questão 2 — O que são guidelines?
O que são "guidelines" (diretrizes) ao usar uma IA generativa? Qual é o papel delas na qualidade das respostas geradas pelo modelo?

**Sua resposta:**

Guidelines são orientações que ajudam a IA a entender como deve realizar uma tarefa. 
Elas podem definir o contexto do projeto, o formato esperado das respostas, a linguagem desejada, os padrões de código e os limites do que pode ser alterado.
O papel dessas diretrizes é reduzir ambiguidades e tornar as respostas mais consistentes com a necessidade de quem está usando a ferramenta. 
Quando a IA conhece as regras e as prioridades, diminui a chance de sugerir algo genérico ou incompatível com o projeto.

### Questão 4 — Escolha de modelo e nível de esforço
Qual modelo de IA utilizar para cada tipo de tarefa? Dê um exemplo de tarefa simples e outra mais complexa, explicando como você escolheria o modelo em cada caso. O que é o "nível de esforço" (effort level) e quando faz sentido aumentá-lo ou diminuí-lo?

**Sua resposta:**

A escolha do modelo depende da dificuldade da tarefa e do equilíbrio entre qualidade, tempo de resposta e custo. 
Para corrigir a ortografia de um texto curto, eu escolheria um modelo mais leve e rápido, porque o objetivo é claro e exige pouca análise. 
Para investigar um erro que envolve diferentes partes de um sistema, eu escolheria um modelo com maior capacidade de raciocínio, pois seria necessário relacionar informações, comparar hipóteses e avaliar os efeitos de uma possível correção.
O nível de esforço, define quanto processamento o modelo dedica ao raciocínio antes de responder. 
Faz mais sentido aumentá-lo em problemas com várias etapas, decisões importantes ou informações difíceis de conciliar.

### Questão 5 — Como estruturar um bom prompt
Descreva os elementos que tornam um prompt mais eficaz (ex.: contexto, objetivo, formato esperado, exemplos, restrições).

**Sua resposta:**

Um bom prompt deixa claro qual o resultado final que o usuário deseja obter. 

Geralmente estruturo o prompt em tópicos:
1. Fornecendo contexto do que é o projeto, e o que o envolve.
2. Objetivo escrito de forma clara do resultado final desejado.
3. Contexto adicional, como: materiais de apoio, imagens ou trechos de código.
4. Definir o formato esperado do output, solicitando a inclusão de explicações, tabelas ou sugestões.
5. Definir as restrições como o tamanho da resposta, qual a arquitetura do sistema, o que pode ou não ser alterado. 
6. Se for aplicável, é válido fornecer exemplos de input e output que auxiliarão a IA a executar o prompt.
7. Por fim, definir critérios de revisão e qualidade para poder conferir se a solicitação foi atendida completamente.

O mais importante é ser claro e evitar instruções vagas ou que contradizem umas as outras.

### Questão 6 — Iteração de prompt
O que significa "iterar" um prompt? Por que a primeira resposta de uma IA geralmente não é a versão final, e como você usaria a resposta recebida para melhorar o próximo prompt?

**Sua resposta:**

Iterar um prompt significa revisar e melhorar a solicitação a partir da resposta recebida. 
A primeira resposta nem sempre é a versão final porque o pedido pode estar incompleto, alguma informação pode ter sido interpretada de outra forma ou o resultado pode não atender ao nível de detalhe esperado.
Eu começaria comparando a resposta com o objetivo da tarefa. Depois, apontaria o que ficou incorreto ou faltando, forneceria o contexto necessário e pediria um ajuste específico. 
Se a explicação estivesse muito genérica, por exemplo, indicaria qual parte precisa ser aprofundada e para qual público ela será usada. 
Assim, cada nova interação aproveita o que já ficou adequado e corrige os pontos restantes. 
Se a primeira resposta já atender aos critérios e estiver correta, não há necessidade de continuar alterando o prompt.

### Questão 7 — Zero-shot vs. few-shot
Qual é a diferença entre um prompt "zero-shot" e um prompt "few-shot"? Dê um exemplo de situação em que vale a pena incluir exemplos dentro do próprio prompt.

**Sua resposta:**

Um prompt zero-shot apresenta a tarefa sem incluir exemplos de como ela deve ser respondida. 
Já um prompt few-shot traz alguns exemplos de entrada e saída para mostrar o padrão desejado.
Em ambos os casos é possível fornecer contexto e instruções, a diferença está na presença desses exemplos.
Isso é útil, por exemplo, ao classificar comentários em positivos, negativos ou neutros. 
Posso mostrar que "Gostei do atendimento" deve receber a classificação "positivo", "O atendimento foi ruim" deve ser "negativo" e "O atendimento aconteceu ontem" deve ser "neutro". 
Depois, peço que a IA classifique novos comentários seguindo o mesmo critério. 
Escolher exemplos variados ajuda a esclarecer as categorias, embora casos ambíguos ainda precisem de revisão.

### Questão 8 — Memória e contexto entre sessões
O que significa uma IA "ter memória" entre sessões diferentes de conversa? Por que, em um projeto longo como o TCC, é importante decidir o que precisa ser "lembrado" e como fornecer esse contexto para a IA a cada nova conversa?

**Sua resposta:**

Uma IA ter memória entre sessões significa que a ferramenta consegue armazenar e recuperar determinadas informações para usar em conversas futuras. 
Isso depende dos recursos e das configurações da ferramenta, não significa que ela lembre de tudo, tenha acesso a todo o histórico ou aprenda permanentemente cada detalhe do projeto.
Em um trabalho longo como o TCC do curso, eu manteria registrados os objetivos, os requisitos, as decisões tomadas, os padrões adotados e as pendências. 
A cada nova conversa, forneceria um resumo atualizado e os arquivos relevantes para a tarefa, ou pediria a leitura desses registros quando a ferramenta tivesse acesso a eles. 
Decidir o que precisa ser lembrado evita repetir explicações, retomar decisões já descartadas e receber sugestões baseadas em informações antigas.

### Questão 9 — Avaliar a resposta da IA
Antes de aplicar a sugestão de uma IA no seu projeto, como você verifica se ela está correta? Descreva pelo menos 2 formas práticas de checar a confiabilidade de uma resposta gerada por IA.

**Sua resposta:**

Primeiro, eu compararia a sugestão com os requisitos do projeto, o código existente e a documentação oficial da tecnologia. 
Isso permite conferir se os métodos e recursos citados existem, se são compatíveis com a versão utilizada e se a solução respeita as regras do sistema. 
Quando a resposta inclui dados ou referências, também é preciso consultar a fonte e verificar se ela realmente sustenta a afirmação.
Depois, eu testaria a sugestão em um ambiente de desenvolvimento, observando o comportamento esperado e situações de erro ou limite. 
Para uma função que recebe dados, por exemplo, verificaria entradas válidas, inválidas e vazias. 
Também revisaria as alterações para identificar efeitos em outras partes do programa. 
Uma resposta bem escrita ou um código que compila são bons sinais, mas não bastam para comprovar que a solução funciona corretamente.

### Questão 10 — Dividir tarefas complexas em etapas
Por que, em tarefas mais complexas, pode ser melhor dividir o trabalho em um fluxo de etapas (ex.: primeiro classificar/organizar, depois processar, depois revisar) em vez de pedir tudo em um único prompt? Dê um exemplo aplicado a uma tarefa do seu TCC.

**Sua resposta:**

Dividir uma tarefa complexa em etapas ajuda a organizar as dependências e verificar cada resultado antes de avançar. 
Assim, fica mais fácil perceber uma interpretação errada, corrigir um problema e entender de onde veio cada decisão. 
Em um pedido muito amplo, uma falha no começo pode comprometer todo o restante e ser mais difícil de identificar na resposta final.
Em uma tarefa de desenvolvimento do TCC, como criar uma opção para listar apenas tarefas pendentes, eu começaria definindo a regra e o resultado esperado. 
Depois, pediria a análise do código que armazena e lista as tarefas, avaliaria uma proposta de alteração e só então partiria para a implementação. 
Por último, verificaria se tarefas concluídas foram excluídas da listagem, se as pendentes aparecem corretamente e como o programa se comporta quando a lista está vazia. 
Cada etapa teria um objetivo claro e com resultados que eu pudesse revisar.

> **Questão 3** (como escrever um bom CLAUDE.md) e a **Questão 11** (prática, evidência de uso real da IA) são respondidas nos próprios arquivos `CLAUDE.md` e `EVIDENCIAS.md` — veja a parte prática abaixo.

---

## Parte prática

1. **Complete o `CLAUDE.md`** na raiz deste repositório — é onde você responde a Questão 3, documentando o projeto para orientar um assistente de IA.
2. **Complete a Skill** em `.claude/skills/revisar-gerenciador-tarefas/SKILL.md`, com instruções reutilizáveis para uma tarefa recorrente do projeto. Renomeie a pasta `minha-skill/` para o nome real da sua skill.
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
