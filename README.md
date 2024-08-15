# SyntaxHighlighter em C#

🌍 *[**Português**](README.md) ∙ [English](README_en.md)*

### Descrição
Este projeto é uma aplicação de editor de textos com destaque de sintaxe, construída usando C# e Windows Forms. Ele suporta o realce de sintaxe para as seguintes linguagens: JSON, XML, SQL, C++. O realçador ajusta dinamicamente a cor do texto em uma RichTextBox com base na linguagem selecionada, melhorando a legibilidade e a experiência de edição.

### Funcionalidades
- **Suporte a Múltiplas Linguagens**: Realça a sintaxe para JSON, XML, SQL, C++, e potencialmente mais, baseado na configuração do sistema.
- **Realce Dinâmico**: Atualiza automaticamente o realce conforme o texto é alterado.
- **Interação com Arquivos**: Abre e salva arquivos diretamente pela interface, facilitando a edição e visualização de arquivos instantaneamente.

### Pré-requisitos
- Microsoft Visual Studio 2022
- SDK do .NET 8.0 ou superior

### Instalação
1. **Clone o repositório**: Use Git ou faça checkout com SVN.
2. **Abra a solução no Visual Studio**: Navegue até o diretório clonado e abra o arquivo `SyntaxHighlighterCS.sln`.

### Uso
1. **Inicie a aplicação**: Construa e execute a aplicação através do Visual Studio.
2. **Abra um arquivo**: Clique no botão 'Abrir' e selecione um arquivo para carregar seu conteúdo no editor de texto.
3. **Selecione a sintaxe para realce**: Escolha a sintaxe apropriada no menu suspenso para iniciar o processo de realce.
4. **Edite e observe as mudanças**: Conforme você modifica o texto no editor, o realce de sintaxe será atualizado de acordo.
5. **Salve seu trabalho**: Use o botão 'Salvar' para gravar as alterações de volta no arquivo.

### Componentes
- `FormMain`: Formulário principal que fornece a interface do usuário.
- `HighlighterBase`: Classe base abstrata para criar realçadores específicos.
- `HighlighterRules`: Implementa regras de realce baseadas na linguagem selecionada.
- `HighlightersOptions`: Enum definindo opções de realce de sintaxe suportadas.

### Interface do Editor

![interface](print.png)

### Contribuições
Contribuições são bem-vindas! Por favor, faça um fork do repositório e abra um pull request com suas melhorias. Certifique-se de seguir o estilo de código existente.

### Licença
Distribuído sob a [Licença MIT](LICENSE).
