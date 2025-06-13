# MergeSort em C#

Este trabalho tem como objetivo implementar o algoritmo **MergeSort** em linguagem C# como parte da disciplina **Análise e Complexidade de Algoritmos**.

## 📌 Objetivo

Demonstrar a implementação do algoritmo de ordenação MergeSort, explicando seu funcionamento por meio de código comentado, bem estruturado e com métricas de desempenho (ações e tempo).

---

## 🧠 Sobre o MergeSort

O MergeSort é um algoritmo de ordenação baseado no paradigma **Dividir e Conquistar**:

1. Divide o array em duas metades.
2. Ordena cada metade recursivamente.
3. Junta (merge) as duas metades ordenadas.

### Complexidade:

| Caso         | Complexidade |
|--------------|--------------|
| Melhor caso  | O(n log n)   |
| Caso médio   | O(n log n)   |
| Pior caso    | O(n log n)   |
| Espaço extra | O(n)         |

---

## 💡 Funcionamento do Código

- `OrdenarMetade`: Função recursiva que divide o array e chama `UnirMetades` para juntar e ordenar.
- `UnirMetades`: Junta duas metades já ordenadas em uma única sequência ordenada.
- `Main`: Inicializa o array, mede o tempo e conta o número de operações realizadas.

---

## ⚙️ Métricas Adicionais

- 🧮 **Total de ações realizadas**: Cada comparação e cópia é contabilizada.
- ⏱️ **Tempo de execução**: Medido em milissegundos com precisão de 3 casas decimais, usando `Stopwatch`.

---

## 🧪 Exemplo de entrada

```csharp
int[] array = { 85, 12, 3, 99, 4, 27, 65, 32, 19, 87, 11, 45, 67, 23, 9, 56, 74, 31, 98, 13 };
