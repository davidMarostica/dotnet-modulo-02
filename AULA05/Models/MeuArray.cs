using System;

namespace AULA05.Models
{
    // Classe genérica
    public class MeuArray<T>
    {
        private int capacidade = 10;
        private T[] array;
        private int contador = 0;

        public MeuArray()
        {
            array = new T[capacidade];
        }

        // Método para adicionar elementos
        public void AdicionarElementoArray(T elemento)
        {
            if (contador < capacidade)
            {
                array[contador] = elemento;
                contador++;
            }
            else
            {
                Console.WriteLine("Array cheio, não é possível adicionar mais elementos.");
            }
        }

        // Indexador
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < contador)
                {
                    return array[index];
                }
                throw new IndexOutOfRangeException("Índice fora do intervalo válido.");
            }
            set
            {
                if (index >= 0 && index < capacidade)
                {
                    array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Índice fora do intervalo válido.");
                }
            }
        }
    }
}