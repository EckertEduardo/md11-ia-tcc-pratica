A ferramenta: GitHub Copilot no Visual Studio

O prompt exato Revise o arquivo Program.cs seguindo as regras do CLAUDE.md e os passos da skill revisor-codigo (em .claude/skills/revisor-codigo/SKILL.md). Não altere nada, só liste os problemas.

O que ele respondeu: Resumo: não foi possível localizar .claude/CLAUDE.md nem .claude/skills/revisor-codigo/SKILL.md no repositório; a revisão abaixo segue práticas comuns de revisão de código e os passos esperados de uma skill de revisor (especificação, separação de responsabilidades, validações, segurança, testabilidade).
Problemas encontrados em GerenciadorDeTarefas/Program.cs (linhas referenciadas):
1.	Arquivos de regra/skill ausentes
•	Não foi encontrado .claude/CLAUDE.md nem .claude/skills/revisor-codigo/SKILL.md no repositório — não foi possível aplicar regras/ passos específicos desses arquivos.
2.	Estado global mutável (linhas 1–2)
•	Variáveis top-level tarefas e proximoId são globais e mutáveis; reduz testabilidade e aumenta acoplamento.
3.	Falta de modelo/entidade (linhas 1,4,20)
•	Uso de tupla (int Id, string Titulo, bool Concluida) em vez de um record/class (ex.: TaskItem) prejudica clareza, extensibilidade e encapsulamento.
4.	Validação ausente em Adicionar (linhas 4–7)
•	Nenhuma validação de titulo (null/empty/trim) antes de adicionar; pode criar itens inválidos.
5.	Concluir: não interrompe após encontrar id e não sinaliza ausência (linhas 9–17)
•	Itera toda a lista mesmo após encontrar a tarefa; não retorna erro/indicador se id não existir — causa custo desnecessário e comportamento silencioso em casos inválidos.
6.	Mutação de coleção por índice (linha 15)
•	Substituir tupla na lista funciona, mas é frágil; operação seria mais clara com um tipo mutável/imutável com métodos apropriados.
7.	Falta de separação de responsabilidades (linhas 20–27, 33–41)
•	Lógica de domínio (manipular tarefas) e I/O (Console.WriteLine/ReadLine) estão misturadas; dificulta testes automatizados.
8.	Bloqueio de execução com Console.ReadLine (linha 42)
•	Uso de ReadLine para "pausar" impede execução automática/CI; preferir condicionais de execução em modo interativo ou abstrair I/O.
9.	Ausência de tratamento de erros e logs
•	Nenhum try/catch, nenhuma mensagem de erro para entradas inválidas nem logs para diagnosticar problemas em produção.
10.	Thread-safety (linhas 1–2,6,15)
•	Lista e proximoId não são seguros para acesso concorrente; se usado em ambiente multi-thread pode causar corrupção.
11.	Internacionalização e strings fixas (linhas 33,39)
•	Mensagens hard-coded em PT-BR; se for requisito multilíngue, falta suporte a recursos de localização. (apenas observação dependendo do escopo)
12.	Falta de testes automatizados
•	Não há infra mostrada para testes unitários; funções imperativas top-level dificultam escrever testes.
13.	Boas práticas de C#: naming/estrutura (estético)
•	Embora nomes em português sejam aceitáveis, padronizar convenções da equipe (ex.: nomes de métodos, sumarização XML) pode ser necessário.
Se desejar, posso gerar uma lista priorizada das correções ou aplicar mudanças mínimas sugeridas (criar TaskItem record, extrair um serviço de tarefas, adicionar validações e retornar indicadores/erros).


Se seguiu as instruções: Tentou seguir as instruções mas não conseguir acessar os caminhos.

