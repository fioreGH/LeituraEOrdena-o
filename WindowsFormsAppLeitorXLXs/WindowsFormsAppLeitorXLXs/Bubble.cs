using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLeitorXLXs
{
    class Bubble
    {
        public int[] bubble(int[] v)
        {

            int i = 0;
            int j = 0;
            int k = 0;
            int auxiliar = 0;
            int tamanho = v.Length;

            for (i = 0; i < tamanho - 1; i++)
            {
                for (j = 0; j < tamanho - 1 - i; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        auxiliar = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = auxiliar;
                    }
                }
            }

            return v;

        }
    }
}
