---
name: revisar-gerenciador-tarefas
description: Revisa o comportamento do console GerenciadorDeTarefas e produz cenários de validação rastreáveis ao código. Use para conferir Adicionar, Concluir, Listar ou o fluxo demonstrativo, sem modificar o aplicativo.
---

# Revisar o GerenciadorDeTarefas

## Entrada e objetivo

Receba a função ou o fluxo a revisar. Se o pedido não indicar um recorte, revise `Adicionar`, `Concluir`, `Listar` e o fluxo principal. Produza uma explicação verificável e cenários que possam ser reutilizados após mudanças no programa.

## Procedimento

1. Leia `CLAUDE.md`, `GerenciadorDeTarefas/Program.cs` e o `.csproj`. Baseie a revisão na versão atual do código.
2. Identifique os dados, as mudanças de estado e a sequência de chamadas. Cite arquivos e linhas relevantes.
3. Descreva a saída esperada a partir dessa leitura, identificando-a como previsão até haver execução.
4. Monte uma tabela com cenário, ação ou condição, resultado esperado e forma de verificação. Considere, quando aplicável: IDs sequenciais, nova tarefa pendente, conclusão de ID existente, ID inexistente, conclusão repetida e lista vazia.
5. Quando o pedido incluir execução, compile e rode usando os comandos do guia. Capture o resultado real, compare com o esperado e registre falhas. Se a compilação falhar, não rode um binário antigo como evidência da versão atual.
6. Classifique cada conclusão como `análise estática`, `verificado por execução` ou `não verificado`. O fluxo atual não exercita todos os cenários; não modifique o programa para simular cobertura que não existe.
7. Relacione as diretrizes do guia e desta skill que foram aplicadas e informe eventuais limitações.

## Saída

- Escopo e resumo do comportamento.
- Referências ao código.
- Saída esperada; saída observada, se houver execução.
- Tabela de cenários com o tipo de evidência de cada linha.
- Aderência às instruções e limitações.

Entregue o relatório na conversa. Esta skill não escreve evidências nem altera arquivos por conta própria.