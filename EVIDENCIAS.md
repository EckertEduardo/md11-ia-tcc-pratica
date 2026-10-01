<!--
QUESTÃO 11 (prática) — Evidência de uso real da IA

Implemente aqui a sua resposta: documente um exemplo real de prompt que
você usou com uma IA conectada a este projeto — ferramenta usada, prompt
exato, o que a IA fez, e se ela seguiu o seu CLAUDE.md/Skill (o que você
precisou ajustar, se precisou). Apague este comentário antes de entregar.
-->
## Ferramenta utilizada
Claude Code, rodando no terminal integrado do JetBrains Rider, na raiz do repositório.

## Prompts usados (exatos)

**Prompt 1 (criar CLAUDE.md e Skill):**
Estou fazendo uma avaliação do Módulo 11 (Tecnologias Emergentes e IA).
Leia o README.md deste repositório para entender o que é pedido e depois
explore a pasta GerenciadorDeTarefas/ (arquivos .cs, .csproj, estrutura).

Tarefa:
1. Preencha o CLAUDE.md na raiz, específico para este projeto: visão geral,
   como rodar/buildar, estrutura real de pastas e classes, convenções de
   código observadas no código existente (nomes, idioma, estilo), regras do
   que a IA deve e não deve fazer. Use nomes reais de arquivos e classes,
   sem frases genéricas. Seja curto e objetivo, em português.
2. Renomeie a pasta .claude/skills/minha-skill/ para o nome de uma skill
   útil e recorrente neste projeto (por exemplo, revisar código antes do
   commit ou criar uma nova funcionalidade seguindo o padrão do projeto) e
   preencha o SKILL.md com frontmatter (name, description) e passos claros
   e reutilizáveis.

Restrições: NÃO altere README.md, EVIDENCIAS.md nem código do app. Altere
apenas CLAUDE.md e a pasta da skill. No final, me diga o que criou e por quê.

**Prompt 2 (usar a skill numa tarefa real):**
Use a skill [nome da skill] para revisar o GerenciadorDeTarefas e me apontar 3 melhorias, sem alterar nenhum arquivo ainda.

## O que a IA fez
- Prompt 1: reescreveu o CLAUDE.md com conteúdo específico do GerenciadorDeTarefas
  (console app com tupla (int Id, string Titulo, bool Concluida) e funções
  Adicionar/Concluir/Listar, convenções observadas, regras do que evitar).
  Renomeou a pasta minha-skill/ para nova-funcionalidade-tarefas/ e preencheu o
  SKILL.md com frontmatter e 7 passos. Resultado: 3 arquivos alterados (+81 -23).
- Prompt 2: o Claude carregou a skill nova-funcionalidade-tarefas e analisou o
  Program.cs sem alterar arquivos. Apontou 3 melhorias: (1) falta a função
  Remover(int id); (2) falta ListarPendentes(); (3) Concluir(int id) não trata
  id inexistente e não usa break.

## Ele seguiu minhas instruções?
Sim. Só alterou o CLAUDE.md e a pasta da skill, sem tocar em README.md,
EVIDENCIAS.md ou Program.cs, e não fez commit. No prompt 2 respeitou o
"sem alterar nenhum arquivo". As sugestões seguiram as convenções do CLAUDE.md
(nomes em português, função local, tupla imutável).


