using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Program
    {
        static void OrdenarMetade(int[] array, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int meio = (inicio + fim) / 2;

                OrdenarMetade(array, inicio, meio);     //Ordena a metade esquerda
                OrdenarMetade(array, meio + 1, fim);    //Ordena a metade direita
                UnirMetades(array, inicio, meio, fim);  //Junta tudo

            }
        }
        static void UnirMetades(int[] array, int inicio, int meio, int fim)
        {
            // Calcula o tamanho das metades
            int n1 = meio - inicio + 1;
            int n2 = fim - meio;

            // Cria arrays temporários para armazenar as metades
            int[] esquerda = new int[n1];
            int[] direita = new int[n2];

            // Array.Copy é um método estático da classe Array que copia elementos de um array de origem para um array de destino
            // Sintaxe: Array.Copy(origem, índiceOrigem, destino, índiceDestino, quantidade)

            // Copia 'n1' elementos do array original, começando em 'inicio', para o array 'esquerda'
            // Os elementos serão colocados em 'esquerda' a partir da posição 0
            Array.Copy(array, inicio, esquerda, 0, n1);

            // Copia 'n2' elementos do array original, começando em 'meio + 1', para o array 'direita'
            // Os elementos serão colocados em 'direita' a partir da posição 0
            Array.Copy(array, meio + 1, direita, 0, n2);

            // - e: controla a posição atual no array 'esquerda'
            // - d: controla a posição atual no array 'direita'
            // - o: controla a posição atual no array original
            int e = 0, d = 0, o = inicio;

            // Primeiro loop: Compara elementos das duas metades e insere o menor no array original

            while (e < n1 && d < n2)   // Enquanto houver elementos em AMBAS as metades
            {
                if (esquerda[e] <= direita[d])  // Se o elemento da esquerda for menor ou igual
                {
                    array[o++] = esquerda[e++]; // Copia da esquerda e avança ambos índices (o e e)
                }
                else   // Se o elemento da direita for menor
                {
                    array[o++] = direita[d++];  // Copia da direita e avança ambos índices(o e d)
                }
            }

            // Segundo loop: Copia os elementos restantes da metade esquerda (se houver)

            while (e < n1)
                array[o++] = esquerda[e++];

            // Terceiro loop: Copia os elementos restantes da metade direita (se houver)

            while (d < n2)
                array[o++] = direita[d++];

        }

//Passo a passo do merge:
//Compara 3 e 4 → Copia 3 → Array: [3, ?, ?, ?]
//Compara 8 e 4 → Copia 4 → Array: [3, 4, ?, ?]
//Compara 8 e 7 → Copia 7 → Array: [3, 4, 7, ?]
//Acabou a direita → Copia o 8 que sobrou → Array final: [3, 4, 7, 8]
            static void Main()
            {
                int[] array = { 85, 12, 3, 99, 4, 27, 65, 32, 19, 87, 11, 45, 67, 23, 9, 56, 74, 31, 98, 13 };
                OrdenarMetade(array, 0, array.Length - 1);
                Console.WriteLine("MergeSort: " + string.Join(", ", array));
            }
        }
    }
    

