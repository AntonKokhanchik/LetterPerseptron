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
        private int speed = 1;

        public int Theta { get; private set; }
        private int[] w;

        Neuron()
        {
            w = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
                w[i] = r.Next(30);
            Theta = r.Next(30);
        }

        public bool React(string picture)
        {
            int s = 0;

            for (int i = 0; i < n; i++)
                s += int.Parse(picture[i].ToString()) * w[i];

            if (s >= Theta)
                return true;
            else
                return false;
        }

        public void Learn(string picture, int mistake)
        {
            for (int i = 0; i < n; i++)
                w[i] += mistake * int.Parse(picture[i].ToString()) * speed;
            Theta -= mistake * speed;
        }
    }
}
