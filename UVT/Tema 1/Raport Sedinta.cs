namespace Tema_1
{
    class Raport_Sedinta : Raport
    {
        string motiv;
        string[] subiecte;
        string[] autori;

        public Raport_Sedinta(string motiv)
        {
            this.motiv = motiv;
        }

        public Raport_Sedinta(string motiv, string[] subiecte, string[] autori) : this(motiv)
        {
            this.subiecte = subiecte;
            this.autori = autori;

            generareContinut();
        }

        #region Methods
        public void generareContinut()
        {
            generareTitlu();

            System.Console.WriteLine("Subiecte: ");
            foreach (string subiect in subiecte)
            {
                System.Console.WriteLine($"= {subiect}");
            }
            System.Console.WriteLine();

            generareIncheiere();
        }

        public void generareIncheiere()
        {
            System.Console.WriteLine("Autori: ");
            foreach (string autor in autori)
            {
                System.Console.WriteLine($"= {autor}");
            }
            System.Console.WriteLine("\n\n");
        }

        public void generareTitlu()
        {
            var titlu = new Titlu(motiv);
            System.Console.WriteLine("Motiv: " + titlu.motiv + " | " + "Date: " + titlu.date + "\n"); 
        }
        #endregion
    }
}
