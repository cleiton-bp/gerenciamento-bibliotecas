# Projeto de Gerenciamento de Biblioteca em C#

## Descrição
Este projeto em C# implementa um sistema de gerenciamento de biblioteca, demonstrando conceitos fundamentais de Programação Orientada a Objetos (POO). As principais classes do projeto são `Base`, `Biblioteca`, `ItemBiblioteca`, e `Livro`. O código segue as convenções de nomenclatura e estilo de código em C# e está comentado para facilitar a compreensão.

## Classes

### Classe Base
- Classe abstrata com as propriedades:
  - `Id` (int): Identificador único para cada objeto.
- Contador estático privado `Contador` que é incrementado a cada criação de objeto e atribuído ao `Id`.

### Classe Biblioteca
- Classe abstrata.
- Gerencia uma lista de `ItemBiblioteca`.
- Métodos:
  - `AdicionarItem`: Adiciona um item à lista.
  - `RemoverItem`: Remove um item da lista.
  - `BuscarItemPorTitulo`: Busca um item por título.
  - `BuscarItemPorId`: Busca um item por id.

### Classe ItemBiblioteca
- Classe abstrata que herda da classe `Base`.
- Representa um item genérico em uma biblioteca.
- Propriedades:
  - `Titulo`: Título do item.
  - `Autor`: Autor do item.
  - Propriedade protegida `DescricaoInterna`.

### Classe Livro
- Herda de `ItemBiblioteca`.
- Representa um livro específico em uma biblioteca.
- Método `ExibirDescricaoInterna`: Imprime a `DescricaoInterna` do livro.

## Uso
Para utilizar essas classes, siga os passos abaixo:
1. Crie instâncias de `Livro` e `Biblioteca`.
2. Adicione os livros à biblioteca usando o método `AdicionarItem`.
3. Busque livros por título ou id usando os métodos `BuscarItemPorTitulo` ou `BuscarItemPorId`.
4. Exiba a descrição interna dos livros chamando o método `ExibirDescricaoInterna`.
5. Remova livros da biblioteca usando o método `RemoverItem`.

## Convenções de Código
O código segue as convenções de nomenclatura e estilo de código em C#. Comentários estão disponíveis para explicar a implementação e o uso de herança, sobrecarga de métodos/contrutores e propriedades protegidas.