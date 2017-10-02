using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterPerseptron
{
    class Neuron
    {
        private int n = 12;

        public int Theta { get; private set; }
        private int[] w;

        public int Generation { get; private set; }

        Neuron()
        {
            w = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
                w[i] = r.Next(30);
            Theta = r.Next(30);
            Generation = 0;
        }

        public bool React(string picture)
        {
            int s = 0;

            for (int i = 0; i < n; i++)
                s += int.Parse(picture[i].ToString());

            if (s >= Theta)
                return true;
            else
                return false;
        }

        public void Learn()
        {
            throw new NotImplementedException();
        }
    }
}
