# GerenciadorDeTarefas

## O que é o projeto
Console app em C# (.NET) que gerencia tarefas em memória: adicionar,
concluir e listar. Serve de base para praticar o uso de IA.

## Como rodar
cd GerenciadorDeTarefas
dotnet run

## Estrutura
- GerenciadorDeTarefas/Program.cs: todo o código (top-level statements)
  - lista `tarefas` com tuplas (Id, Titulo, Concluida)
  - funções locais: Adicionar(titulo), Concluir(id), Listar()
- GerenciadorDeTarefas.sln: solução do Visual Studio

## Convenções de código
- Métodos e funções em PascalCase, variáveis em camelCase
- Nomes, mensagens e comentários em português
- Funções curtas, uma responsabilidade cada
- Tarefas guardadas apenas em memória (sem banco nem arquivo)

## Regras para a IA
- Não alterar arquivos fora do que eu pedir
- Explicar o que vai mudar antes de mudar
- Não adicionar bibliotecas ou pacotes novos sem perguntar
- Não criar funcionalidades novas: o foco é a configuração da IA