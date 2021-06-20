namespace Numere_Rationale
{
    class Rational
    {
        #region Properties
        private int numarator;

        public int Numarator
        {
            get { return numarator; }
            set { numarator = value; }
        }

        private int numitor;

        public int Numitor
        {
            get { return numitor; }
            set { numitor = value; }
        }
        #endregion

        #region Constructors
        public Rational()
        {

        }

        public Rational(int numarator, int numitor)
        {
            Numarator = numarator;
            Numitor = numitor;
        }
        #endregion

        #region Methods
        public Rational adunare(Rational fractie2)
        {
            int numitorComun = cmmdc(this.Numitor, fractie2.Numitor);

            if (this.Numitor != fractie2.Numitor)
            {
                return new Rational(this.Numarator*fractie2.Numitor + this.Numitor*fractie2.Numarator, numitorComun);
            }
            else
            {
                return new Rational(this.Numarator + fractie2.Numarator, fractie2.Numitor);
            }
        }

        public override string ToString()
        {
            if (isDivizibil(Numarator, Numitor))
            {
                return $"{Numarator / Numitor}";
            }
            else
            {
                return $"{Numarator}/{Numitor}";
            }
        }

        public bool isDivizibil(int numarator, int numitor)
        {
            if (numarator % numitor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int cmmdc(int a,int b)
        {
            int x = a;
            int y = b;

            while (x!=y)
            {
                if (x>y)
                {
                    x = x - y;
                }
                else
                {
                    y = y - x;
                }
            }

            return (a * b) / x;
        }
        #endregion
    }
}
