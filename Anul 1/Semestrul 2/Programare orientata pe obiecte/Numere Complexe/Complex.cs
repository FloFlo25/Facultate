namespace Numere_Complexe
{
    class Complex
    {
        #region Properties
        private int parteaReala;

        public int ParteaReala
        {
            get { return parteaReala; }
            set { parteaReala = value; }
        }

        private int parteaImaginara;

        public int ParteaImaginara
        {
            get { return parteaImaginara; }
            set { parteaImaginara = value; }
        }
        #endregion


        #region Constructors
        public Complex()
        {

        }

        public Complex(int parteaReala, int parteaImaginara) : this()
        {
            ParteaReala = parteaReala;
            ParteaImaginara = parteaImaginara;
        }
        #endregion


        public Complex adunare(Complex complex)
        {
            this.ParteaReala += complex.ParteaReala;
            this.ParteaImaginara += complex.ParteaImaginara;

            return this;
        }

        public Complex scadere(Complex complex)
        {
            this.ParteaReala -= complex.ParteaReala;
            this.ParteaImaginara -= complex.ParteaImaginara;

            return this;
        }

        public Complex impartire(Complex complex)
        {
            this.ParteaReala /= complex.ParteaReala;
            this.ParteaImaginara /= complex.ParteaImaginara;

            return this;
        }

        public Complex inmultire(Complex complex)
        {
            this.ParteaReala *= complex.ParteaReala;
            this.ParteaImaginara *= complex.ParteaImaginara;

            return this;
        }

        public override string ToString()
        {
            if (ParteaImaginara > 0)
            {
                return $"{ParteaReala} + {ParteaImaginara}i";
            }
            else
            {
                return $"{ParteaReala} - {ParteaImaginara}i";
            }

        }

    }
}
