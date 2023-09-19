# Protótipo em ASP.NET para Grupo GPS
Este é um protótipo para o processo seletivo técnico, onde é necessario consumir uma API de busca de empresas (por CNPJ por exemplo) e ter uma opção para salvar os dados recebidos.

- API utilizada: `GET` `https://receitaws.com.br/v1/cnpj/{cnpj}`
- Documentação da API: `https://developers.receitaws.com.br/#/operations/queryCNPJFree`

## Sobre:

⏳ Executando:
  - Ao clonar o repositório, o projeto deve ser executado em `HTTPS`
  - Por default irá te direcionar para um form simples para o Input do CNPJ de uma empresa
    - Um exemplo para teste é o CNPJ do Mercado Livre, que usei para teste: `03361252000134`

📃 To-Do List:
  - Implementar CORS para fetch em AJAX
  - Implementar uma pagina nova com as informações recebidas após uma resposta positiva da API (empresa encontrada)
    - Esta página deve conter um botão de `Salvar` para gravar os dados localmente
  - Implementar mensagem de "Erro" quando não houver empresa encontrada
  - Verifiação para que o input do usuário seja valido
    - Somente numeros
    - Tamanho minimo
  - Estilizar as páginas da aplicação
  - Opção de buscar multiplos CNPJs de uma vez
    - Obs: A API tem um limite de 3 requisições por minuto
  - Desfazer de arquivos não utilizados (resquicios de conexão com MySQL por exemplo)

📌 Observações:
  - Esse é o primeiro projeto que uso ASP.NET. Minha experiência passada com C# era num escopo de desenvolvimento de games.
  - A URL da App será *bem* rudimentar. Eu tenho preferencia de nomear as rotas mais concisamente, como: `/empresa/{id}` mas não está em minha prioridades comparado às funcionalidades
  - Originalmente eu tinha o âmbito de armazenar as informações vindas pela API em um Banco de Dados MySQL. Isso incluiria a configuração para conexão ao mesmo pelo e migrações para gerar e popular um BD local. Infelizmente passei *muito* tempo tentando fazer essa conexão funcionar e decidi que não valeria à pena dado o prazo do projeto. Optei por simplificar e "mockar" esse aspecto e salvar os dados vindos dentro de um arquivo local (csv ou json)
  - Criação de Forms e passar seus dados para variaveis e scripts é muito mais simples que eu esperava em ASP.NET, já que usa JavaScript mesmo que parcialment
  
