using System;

namespace ConsoleApp1
{
    class Stack
    {
        int[] values;
       char[] valuesChar;
        


        public Stack()
        {
            values = new int[0];//array pentru stack de tip int
            valuesChar = new char[0];//array pentru stack de tip char
        }

        public string RPN(string expresie)
        {
            string text = expresie.Replace(" ", "");//stregem spatiile albe daca sunt

            /*    (  )     prioritate 0
                  *  /     prioritate 1
                  +  -     prioritate 2
            */

            char[] elementeExpresie = text.ToCharArray();
            int lungimeElemente = elementeExpresie.Length;

            char[] fp = new char[lungimeElemente];//array Polonez
            Stack st = new Stack();//stack pentru operatori

            int j = 0;
            for (int i = 0; i < lungimeElemente; i++)
            {
                #region gettype
                /*int j = 0;
                if (elementeExpresie[i].GetType() == typeof(int))
                        {
                            fp[j] = elementeExpresie[i];
                        }
                        else
                        {
                            st.Push(elementeExpresie[i]);
                        }
                        */
                #endregion

                //2+5*5
                int k = i;
                //numere
                if (prioritate(elementeExpresie[i]) == -1)
                {
                    fp[j] = elementeExpresie[i];
                    j++;
                    continue;
                }
                else
                {
                    //* sau /                    
                    if (prioritate(elementeExpresie[i]) == 1)
                    {
                        st.pushChar(elementeExpresie[i]);
                        continue;
                    }

                    //+ sau -
                    if (prioritate(elementeExpresie[i]) == 2)
                    {
                        st.pushChar(elementeExpresie[i]);
                        st.popChar();
                        do
                        {
                            if (st.valuesChar.Length > 0)
                            {
                                fp[j] = st.popChar();
                                j++;
                                k--;

                            }
                        } while (prioritate(elementeExpresie[k]) == 1);
                        st.pushChar(elementeExpresie[i]);
                    }

                    //( sau )
                    if (prioritate(elementeExpresie[i]) == 0)
                    {
                        if (elementeExpresie[i] == ')')
                        {
                            while (elementeExpresie[k] != '(')
                            {
                                fp[j] = st.popChar();
                                j++;
                                k--;
                            }
                        }
                    }
                }
                
            }

            fp[lungimeElemente - 1] = st.popChar();
            Console.WriteLine($"Lungime elem: {lungimeElemente}");

            foreach (char item in fp)
            {

                Console.Write(item);
            }
            st.View();

            return " ";
        }


        public void pushChar(char ValueToAdd)
        {
            char[] temp = new char[valuesChar.Length + 1];
            for (int i = 0; i < valuesChar.Length; i++)
            {
                temp[i + 1] = valuesChar[i];
            }
            temp[0] = ValueToAdd;
            valuesChar = temp;
        }

        /*public void pushChar(char ValueToAdd)
        {
            char[] temp = new char[valuesChar.Length + 1];
            for (int i = 0; i < valuesChar.Length; i++)
            {
                temp[i + 1] = valuesChar[i];
            }
            temp[0] = ValueToAdd;
            valuesChar = temp;
        }*/

        public char popChar()
        {
           // Console.WriteLine(valuesChar.Length);
            char toReturn = valuesChar[valuesChar.Length - 1];
            char[] temp = new char[valuesChar.Length - 1];
            for (int i = 0; i < valuesChar.Length - 1; i++)
            {
                temp[i] = valuesChar[i + 1];
            }
            valuesChar = temp;
            return toReturn;
        }
        public void Analisis(char[] expresie)
        {
            for (int i = 0; i < expresie.Length; i++)
            {
                foreach (char operand in operanzi)
                {
                    if (expresie[i] == operand)
                    {

                    }

                }
            }
        }
        public int prioritate(char op)
        {
            if (op == '(' || op == ')')
            {
                return 0;
            }
            else if (op == '*' || op == '/')
            {
                return 1;
            }
            else if (op == '+' || op == '-')
            {
                return 2;
            }
            return -1;
        }

        //int push and pop
        public int Pop()
        {
            int toReturn = values[values.Length - 1];
            int[] temp = new int[values.Length - 1];
            for (int i = 0; i < values.Length - 1; i++)
            {
                temp[i] = values[i + 1];
            }
            values = temp;
            return toReturn;
        }
        public void Push(int ValueToAdd)
        {
            int[] temp = new int[values.Length + 1];
            for (int i = 0; i < values.Length; i++)
            {
                temp[i + 1] = values[i];
            }
            temp[0] = ValueToAdd;
            values = temp;
        }

        public void View()
        {
            foreach (var value in values)
            {
                Console.Write(value + " ");
            }
        }
    }
}
