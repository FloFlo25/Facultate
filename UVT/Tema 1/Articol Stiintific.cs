namespace Tema_1
{
    public class Articol_Stiintific : Raport
    {
        string titluArticol;
        string[] autori;
        string bibliografie;
        Sectiune[] sectiune;

        #region Methods
        public void generareTitlu()
        {
            System.Console.Write($"Titlu: {titluArticol} |  Autori: ");
            for (int i = 0; i < autori.Length; i++)
            {
                if (i==autori.Length-1)
                {
                    System.Console.Write(autori[i]);
                    break;
                }
                System.Console.Write(autori[i] + ", ");
            }
            System.Console.WriteLine("\n\n");
        }

        public void generareContinut()
        {

        }

        public void generareIncheiere()
        {

        }

        #endregion
    }
}
