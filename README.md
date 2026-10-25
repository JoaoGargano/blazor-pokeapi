## Sobre o Projeto

Aplicação web desenvolvida em **Blazor WebAssembly (WASM)** (.NET) para busca e exibição de informações de Pokémons utilizando a API pública [PokéAPI](https://pokeapi.co/).

O objetivo principal da atividade é:
- Desenvolver uma aplicação SPA utilizando **Blazor WebAssembly**.
- Criar formulários interativos com `@bind` para captura de dados do usuário.
- Consumir a API externa da **PokéAPI** de forma assíncrona com `HttpClient` (`GetFromJsonAsync`).
- Desserializar estruturas complexas de JSON aninhado, extraindo obrigatoriamente a imagem oficial do Pokémon em `sprites.other.official-artwork.front_default`.
- Formatar e converter unidades (altura de decímetros para metros e peso de hectogramas para quilogramas).

## Funcionalidades

- **Busca por Nome ou ID:** Permite buscar qualquer Pokémon pelo nome (ex: `pikachu`, `ditto`, `charizard`) ou número de ID (ex: `25`).
- **Exibição dos Dados do Pokémon:**
  - **Imagem:** Imagem oficial de alta qualidade (`official-artwork`).
  - **ID:** Número identificador na Pokédex.
  - **Nome:** Nome do Pokémon.
  - **Altura:** Convertida para metros (`0,4 m`).
  - **Peso:** Convertido para quilogramas (`6 kg`).
- **Tratamento de Exceções:** Mensagens amigáveis para campos vazios ou Pokémons não encontrados.

## API Utilizada

- **Endpoint:** `https://pokeapi.co/api/v2/pokemon/{nome}`
- **Método:** GET
- **Campo da Imagem Obrigatório:**
  ```json
  "sprites": {
    "other": {
      "official-artwork": {
        "front_default": "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/25.png"
      }
    }
  }
  ```

## Tecnologias Utilizadas

- **C#** / **.NET**
- **Blazor WebAssembly (WASM)**
- **System.Net.Http.Json**
- **System.Text.Json.Serialization** / **Newtonsoft.Json**
- **Bootstrap 5** (Layout e estilização responsiva)

