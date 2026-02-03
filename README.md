# Desafio POO - Sistema de Celulares (DIO)

## 📋 Descrição
O projeto tem por finalidade modelar um sistema de smartphones utilizando Programação Orientada a Objetos (POO). O sistema demonstra no console o funcionamento de diferentes marcas de celulares a partir de uma estrutura base comum.

## 🧠 Conceitos de POO Aplicados

* **Abstração:** A classe `Smartphone` foi definida como abstrata, servindo como um molde (template) obrigatório para qualquer novo celular. Ela não pode ser instanciada diretamente, garantindo que apenas modelos reais (como Nokia ou iPhone) existam no sistema.

* **Herança:** As classes `Nokia` e `Iphone` herdam as propriedades e métodos da classe mãe `Smartphone`, permitindo o reuso de funcionalidades comuns como "Ligar" e "Receber Ligação".

* **Polimorfismo:** Aplicado no método `InstalarAplicativo`. Através da sobrescrita (`override`), cada marca define seu próprio comportamento de instalação, permitindo que o mesmo comando funcione de formas diferentes dependendo do aparelho.

* **Encapsulamento (Bônus):** O uso de construtores e propriedades protege a integridade dos dados (como IMEI e Modelo) desde o momento da criação do objeto.

## 🚀 Como rodar
1. Certifique-se de ter o **SDK do .NET 6.0** (ou superior) instalado.
2. Clone o repositório .
3. No terminal, acesse a pasta do projeto e execute:
   ```bash
   dotnet run
