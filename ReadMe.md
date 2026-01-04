# Bin2Dec - Conversor de Binário para Decimal

Este é um projeto desenvolvido em **C#** utilizando o framework **Avalonia UI** para ambiente **Linux (Ubuntu 24.04)**. O objetivo é converter sequências de até 8 dígitos binários (0s e 1s) em seu equivalente decimal.

## 🚀 O Desafio
Este projeto segue as restrições de um desafio de nível iniciante:
- [x] Não utiliza matrizes/arrays para armazenar os dígitos.
- [x] Utiliza uma única função matemática (`Math.Pow`) para determinar o valor decimal.
- [x] Notifica o usuário em caso de entrada inválida (caracteres diferentes de 0 ou 1).
- [x] Limita a entrada a 8 caracteres.

## 🛠️ Tecnologias Utilizadas
- **Linguagem:** C# (.NET 8/9)
- **Interface:** [Avalonia UI](https://avaloniaui.net/) (Cross-platform XAML framework)
- **Ambiente:** Ubuntu 24.04 LTS
- **Editor:** VS Code

## 🧠 Como funciona a conversão?
A lógica utiliza a base 2, onde cada posição do bit (da direita para a esquerda, começando do zero) representa uma potência de 2.
Exemplo: `1011`
- $1 \times 2^3 = 8$
- $0 \times 2^2 = 0$
- $1 \times 2^1 = 2$
- $1 \times 2^0 = 1$
- **Total: 11**

## 📥 Como executar no Linux

### Pré-requisitos
Certifique-se de ter o SDK do .NET instalado em seu Ubuntu:
```bash
sudo apt update
sudo apt install dotnet-sdk-8.0