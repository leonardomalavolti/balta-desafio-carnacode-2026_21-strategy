![CO-9](https://github.com/user-attachments/assets/62cd5af8-c493-4076-bde8-8261e5433ca4)

## 🥁 CarnaCode 2026 - Desafio 21 - Strategy

Oi, eu sou o Leonardo Malavolti Monteiro e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

### Sobre este desafio
No desafio **Strategy** eu tive que resolver um problema real implementando o **Design Pattern Strategy**.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)

## Problema
Um e-commerce precisa calcular frete usando diferentes transportadoras (Correios, FedEx, DHL, Transportadora Local), cada uma com sua própria lógica de cálculo.
O código atual usa condicionais para escolher o algoritmo, violando o Open/Closed Principle.

## Solução com Strategy
- Cada transportadora implementa a interface `IShippingStrategy`
- `ShippingCalculator` delega cálculo, prazo e disponibilidade para a estratégia atual
- Eliminadas estruturas switch/case
- Permite adicionar novas transportadoras sem modificar o código existente
- Algoritmos intercambiáveis em runtime
- Facilita teste isolado de cada estratégia

## Benefícios
- Código limpo e modular
- Cumpre Open/Closed Principle
- Facilita manutenção e extensão
- Permite composição de múltiplos algoritmos no futuro

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Incluir link para o repositório central]
