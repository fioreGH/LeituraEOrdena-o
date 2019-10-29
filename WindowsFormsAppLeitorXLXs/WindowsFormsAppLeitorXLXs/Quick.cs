using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLeitorXLXs
{
    class Quick
    {
        public int[] quick(int[] v, int inicio, int fim)
        {
            if (inicio < fim)
            {
                int posicaoPivo = separar(v, inicio, fim);
                quick(v, inicio, posicaoPivo - 1);
                quick(v, posicaoPivo + 1, fim);
            }
            return v;
        }


        public int separar(int[] vetor, int inicio, int fim)
        {
            int pivo = vetor[inicio];
            int i = inicio + 1, f = fim;
            while (i <= f)
            {
                if (vetor[i] <= pivo)
                    i++;
                else if (pivo < vetor[f])
                    f--;
                else
                {
                    int troca = vetor[i];
                    vetor[i] = vetor[f];
                    vetor[f] = troca;
                    i++;
                    f--;
                }
            }
            vetor[inicio] = vetor[f];
            vetor[f] = pivo;
            return f;
        }
    }
}
