# Calculadora em C# - Windows Forms

Este projeto é uma calculadora simples desenvolvida em C# utilizando Windows Forms (WinForms). O objetivo principal foi praticar conceitos fundamentais de programação orientada a objetos, manipulação de eventos, e a construção de uma interface gráfica interativa com funcionalidades úteis para o usuário final.

# Funcionalidades

- Operações básicas: adição, subtração, multiplicação e divisão.
- Cálculo de porcentagem (ex: 50 + 10%).
- Cálculo de potência (elevar ao quadrado).
- Botão de backspace para apagar o último dígito.
- Histórico de cálculos com visualização dinâmica.
- Suporte a separador decimal com vírgula.
- Interface gráfica simples e funcional.

# Aprendizados aplicados

- Manipulação de eventos com `Click`.
- Conversão de strings para double com `TryParse` (respeitando a cultura local).
- Controle de estados com variáveis auxiliares (`novoNumero`, `valor1`, `operacao`, etc).
- Uso de listas para registrar o histórico de operações.
- Controle de componentes dinâmicos como `ListBox` e `ListView`.

# Tecnologias utilizadas

- Linguagem: **C#**
- Interface gráfica: **Windows Forms (WinForms)**
- IDE: **Visual Studio 2022**

# Como rodar o projeto

1. Abra o projeto no **Visual Studio**.
2. Compile a solução (Ctrl + Shift + B).
3. Execute (F5) e interaja com a interface gráfica.

> O código está organizado em eventos e funções claras, o que facilita futuras modificações ou inclusão de novas operações.

# Estrutura geral

```plaintext
Calculadora/
│
├── Form1.cs               # Lógica principal e eventos
├── Form1.Designer.cs      # Interface visual gerada
├── Program.cs             # Ponto de entrada da aplicação
└── Calculadora.sln        # Solução do Visual Studio
