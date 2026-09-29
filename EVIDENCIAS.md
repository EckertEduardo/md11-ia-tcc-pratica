# Questão 11 — Evidência de uso de IA no projeto

**Ferramenta:** Codex, conectado ao repositório clonado na minha máquina.

**Prompt:**

Leia o CLAUDE.md e use a skill .claude/skills/revisar-gerenciador-tarefas/SKILL.md para revisar o projeto GerenciadorDeTarefas.
Quero entender como as funções Adicionar, Concluir e Listar funcionam, principalmente como os IDs são gerados e como uma tarefa passa de pendente para concluída. Explique esses pontos indicando os trechos do código.
Depois, compile a solução e, se não houver erros, execute o programa. Forneça a entrada necessária para encerrar o Console.ReadLine() e confira se a saída corresponde ao comportamento esperado.
Apresente uma tabela com os cenários de validação, deixando claro quais foram realmente executados e quais foram avaliados apenas pela leitura do código. Ao final, informe se as instruções do guia e da skill foram seguidas e se ficou alguma limitação.
Não altere o código nem as configurações do projeto. Entregue a análise aqui na conversa e, se algum comando falhar, explique o que aconteceu.


**O que a IA fez:**

Ela preencheu a documentação e a skill e, depois, usou essas instruções para analisar o código. 
Explicou que `Adicionar` cria uma tarefa pendente e incrementa o ID, que `Concluir` marca a tarefa encontrada como concluída e que `Listar` mostra `[ ]` ou `[X]` conforme o estado de cada item.

Além da leitura do código, ela compilou a solução e executou o programa com estes comandos:

```powershell
dotnet build GerenciadorDeTarefas.sln
'' | dotnet run --project GerenciadorDeTarefas/GerenciadorDeTarefas.csproj --no-build
```

A compilação terminou sem avisos e sem erros, e os dois comandos retornaram código de saída `0`. Na primeira listagem, as três tarefas apareceram pendentes. Depois da chamada `Concluir(1)`, somente a tarefa #1 passou a aparecer com `[X]`; as tarefas #2 e #3 continuaram com `[ ]`. A entrada vazia no segundo comando permitiu encerrar o `Console.ReadLine()` sem alterar o código.

**Ela seguiu minhas instruções e o CLAUDE.md/Skill?**

Sim. Ela leu o guia e a skill antes de revisar o programa, respondeu em português e explicou suas conclusões com referências ao código. Respeitou a estrutura existente, sem criar classes, dependências ou funcionalidades que eu não havia solicitado.

Também seguiu a orientação de separar análise do código de resultados comprovados pela execução. A skill foi usada para organizar a revisão e os cenários de validação, e o programa só foi executado com `--no-build` depois que a compilação terminou com sucesso.

**O que precisei ajustar:**

Na revisão prática, não precisei solicitar uma correção no código: a compilação e a execução funcionaram, e o resultado correspondeu ao comportamento esperado. Os ajustes que pedi foram na documentação. Solicitei que as respostas do README ficassem mais naturais, sem os exemplos ligados a outro projeto.