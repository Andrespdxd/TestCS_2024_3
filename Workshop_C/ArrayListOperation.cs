namespace Workshop_C;
using System;
using System.Collections.Generic;

public class ArrayListOperation
{
    // 1. Encuentra el valor máximo en una lista
    public int GetMaxValue(List<int> numbers)
    {
        int maximo = numbers[0];
        foreach (int num in numbers)
        {
            if (num > maximo)
            {
                maximo = num;
            }
        }
        return maximo; // Solo declaración, sin implementación
    }

    // 2. Encuentra el valor mínimo en una lista
    public int GetMinValue(List<int> numbers)
    {
        int minimo = numbers[0]; 

        foreach (int num in numbers)
        {
            if (num < minimo)
            {
                minimo = num;
            }
        }
        return minimo; // Solo declaración, sin implementación
 
    }

    // 3. Calcula el promedio de una lista
    public double CalculateAverage(List<int> numbers)
    {
        if (numbers.Count == 0)
            return 0; 

        int suma = 0;
        foreach (int numero in numbers)
        {
            suma += numero;
        }

        double promedio = (double)suma / numbers.Count;
        return promedio;
    }

    // 4. Encuentra un elemento en una lista y devuelve su índice
    public int FindElement(List<int> numbers, int element)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == element)
            {
                return i; 
            }
        }
        return -1; 
    }

    // 5. Cuenta las veces que un elemento aparece en una lista
    public int CountOccurrences(List<int> numbers, int element)
    {
        int contador = 0;

        foreach (int numero in numbers)
        {
            if (numero == element)
            {
                contador++;
            }
        }
        return contador; 
   
    }

    // 6. Invierte un array de enteros
    public int[] ReverseArray(int[] array)
    {
        Array.Reverse(array);
        
        return array;
    }

    // 7. Ordena un array de enteros en orden ascendente
    public int[] SortArray(int[] array)
    {
        Array.Sort(array);
        return array;
    }

    // 8. Devuelve una lista de elementos únicos
    public List<int> GetUniqueElements(List<int> numbers)
    {
        return numbers.Distinct().ToList();
    }

    // 9. Suma todos los elementos de una lista
    public int SumElements(List<int> numbers)
    {
        int suma = 0;
        foreach (int numero in numbers)
        {
            suma += numero;
        }
        return suma;
    }

    // 10. Multiplica todos los elementos de una lista
    public long MultiplyElements(List<int> numbers)
    {
        int mult = 1;
        foreach (int numero in numbers)
        {
            mult *= numero;
        }
        return mult;
    }

    // 11. Obtiene el segundo elemento más grande de una lista
    public int GetSecondLargest(List<int> numbers)
    {
        int primero = int.MinValue;
        int segundo = int.MinValue;
        foreach (int i in numbers)
        {
            if (i > primero)
            {
                segundo = primero;
                primero = i;
            }
            else if (i > segundo)
                segundo = i;
        }
        return segundo;
    }

    // 12. Verifica si un array está ordenado
    public bool IsArraySorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    // 13. Elimina duplicados de una lista
    public List<int> RemoveDuplicates(List<int> numbers)
    {
        return numbers.Distinct().ToList();;
    }

    // 14. Rota un array por un número de posiciones
    public int[] RotateArray(int[] array, int positions)
    {
        if (positions == 0)
        {
            return array;
        }

        for (int i = 0; i < array.Length; i += positions)
        {
            array[i] = array[i + positions ];
        }

        return array;
    }

    // 15. Encuentra la mediana de una lista de enteros
    public double FindMedian(List<int> numbers)
    {
        numbers.Sort();
    
        int count = numbers.Count;
        
        if (count % 2 != 0)
        {
            return numbers[count / 2];
        }
        else
        {
            int middle1 = numbers[(count / 2) - 1];
            int middle2 = numbers[count / 2];
            return (middle1 + middle2) / 2.0;
        }
    }

    // 16. Calcula la desviación estándar de una lista
    public double CalculateStandardDeviation(List<int> numbers)
    {
        if (numbers.Count == 0)
            return 0.0;
        
        double media = numbers.Average();

        double suma = numbers.Sum(num => Math.Pow(num - media, 2));

        double varianza = suma / numbers.Count;

        return Math.Sqrt(varianza);
 
    }

    // 17. Comprueba si un valor está en la lista
    public bool CheckForValue(List<int> numbers, int value)
    {
        foreach (int numero in numbers)
        {
            if (numero == value)
            {
                return true;
            }
        }
        
        return false;
    }

    // 18. Divide un array en dos subarrays en un índice específico
    public Tuple<int[], int[]> SplitArray(int[] array, int index)
    {
        int[] firstPart = array.Take(index).ToArray();
        int[] secondPart = array.Skip(index).ToArray();

        return Tuple.Create(firstPart, secondPart);
    }

    // 19. Encuentra el subarray más largo en un array
    public int[] FindLongestSubarray(int[] array)
    {
        
        return null;
    }

    // 20. Encuentra la secuencia consecutiva más larga en una lista
    public List<int> FindLongestConsecutiveSubsequence(List<int> numbers)
    {
        return null;
    }

}

