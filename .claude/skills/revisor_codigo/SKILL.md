---
name: revisor_codigo
description: Revisa código C# do GerenciadorDeTarefas seguindo as convenções do CLAUDE.md. Use quando eu pedir para revisar um arquivo .cs.
---

# Revisar código C#

## Quando usar
Sempre que eu pedir revisão de um arquivo .cs do projeto.

## Passos
1. Leia o arquivo indicado e o CLAUDE.md da raiz
2. Verifique:
   - nomes fora do padrão (PascalCase para funções, camelCase para variáveis)
   - funções longas ou que fazem mais de uma coisa
   - código repetido ou que pode ser simplificado
   - nomes, mensagens e comentários que não estão em português
3. Liste os problemas do mais importante ao menos importante
4. Sugira a correção de cada um, sem alterar o arquivo até eu aprovar

## Formato da resposta
Para cada problema:
- Arquivo e linha
- Problema
- Sugestão de correção

## Regras
- Não alterar nenhum arquivo sem minha aprovação
- Não sugerir bibliotecas novas
- Não propor funcionalidades novas