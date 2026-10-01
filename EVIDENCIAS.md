# Evidência de uso de IA no projeto

**Ferramenta usada:** GitHub Copilot

**Prompt exato:**
"Adicione uma validação em Concluir que avisa 'id solicitado não foi encontrado' se o Id não existir. Depois, adicione uma chamada de teste tipo Concluir(99) para eu ver a mensagem aparecer no console."

**O que a IA fez:**
Ela adicionou um `return;` dentro do `if`, assim que encontra e marca a tarefa — isso interrompe o loop mais cedo (antes, ele continuava percorrendo a lista à toa mesmo depois de achar). Adicionou `Console.WriteLine("id solicitado não foi encontrado");` fora do loop, que só executa se o `for` terminar sem encontrar o Id. Por fim, adicionou o comentário `// Chamadas de teste para demonstrar validação` e a chamada `Concluir(99);`, exatamente como pedido, permitindo ver o erro no console sem precisar digitar nada.

**Ela seguiu suas instruções (CLAUDE.md/Skill)?**
Sim, de primeira. Ela seguiu a Skill (manteve a tupla existente, não criou classe nova, e comentou o código), seguiu o CLAUDE.md (manteve nomes em português e PascalCase) e seguiu o Prompt também — usou a mensagem de erro exata pedida.

**O que precisei ajustar:**
Nada precisou ser ajustado — o resultado já veio correto na primeira tentativa, seguindo tanto o CLAUDE.md quanto a Skill sem necessidade de reformular o prompt.

**Observação extra:**
A IA foi além do que foi pedido, adicionando um `return` para otimizar o loop, evitando que ele continue percorrendo a lista à toa depois de já ter encontrado o Id.