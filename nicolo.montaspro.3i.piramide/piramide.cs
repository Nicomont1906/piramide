using System;

namespace Piramide
{
    public static class Piramide
    {
        public static int Piani(int mattoni)
        {
            if (mattoni < 1) return 0; 
            int piani = 1;
            int mattoni_rimasti = mattoni;
            while (mattoni_rimasti >= (2 * piani + 1) * (2 * piani + 1) - 2 * piani)
            {
                mattoni_rimasti -= (2 * piani + 1) * (2 * piani + 1) - 2 * piani;
                piani++;
            }
            return piani;
        }

        public static int Rimanenti(int mattoni)
        {
            int piani = Piani(mattoni);
            int mattoni_necessari = (2 * piani - 1) * (2 * piani - 1);
            return mattoni - mattoni_necessari;
        }
    }
}
