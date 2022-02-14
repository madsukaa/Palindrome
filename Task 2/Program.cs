/*********************************************************************************************************************/
/*                                              TASK 2 : PALINDROME                                                  */
/*                                        NAME : AHMAD SUHAIMI BIN MASRI                                             */
/*                                                                                                                   */
/*********************************************************************************************************************/

using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of variables
            string InputString, TrashSymbolString = "";
            bool pal;

            //Read input value from user
            Console.Write("InputString: ");
            InputString = Console.ReadLine();

            //Convert string to char array
            char[] GetChar = InputString.ToCharArray();

            //Trace the symbol in the string by using function trashSymbol()
            //and display it 
            TrashSymbolString = trashSymbol(GetChar, TrashSymbolString);
            Console.WriteLine("TrashSymbolsString: " + TrashSymbolString);

            //Get the boolean of palindrome whether it is true or false
            //and display it
            pal = palindrome(GetChar);
            Console.WriteLine("Result should be: " + pal);
        }

        //Palindrome function to check whether the string is palindrome or not
        static public bool palindrome(char[] n)
        {
            //Declare the variables
            char[] tmp = new char[n.Length];
            bool pal = true;
            int b = 0;

            //for-loop to check the character that are not symbols
            for (int i = 0; i < n.Length; i++)
            {
                if (!Char.IsSymbol(n[i]) && !Char.IsPunctuation(n[i]))
                {
                    tmp[b] = n[i];
                    b++;
                }
            }

            //for-loop to create a new char array that had converted
            //to lower case 
            char[] palchar = new char[b];

            for (int i = 0; i < palchar.Length; i++)
            {
                palchar[i] = Char.ToLower(tmp[i]);
            }


            //for-loop to check whether the string is palindrome or not.
            for (int i = 0, t = palchar.Length - 1 ; i < palchar.Length; i++, t--)
            {
                if (palchar[i] != palchar[t])
                {
                    pal = false;
                    break;
                }
            }
            return pal;
        }

        //Function for trace trashsymbol in a string
        static public string trashSymbol(char[] n, string m)
        {
            //Declare the variables
            char[] tmp = { };
            bool dup = false;

            //for-loop to get the trash symbols
            for (int i = 0; i < n.Length; i++)
            {
                if (Char.IsSymbol(n[i]) || Char.IsPunctuation(n[i]))
                {
                    if(m != "")
                    {
                        tmp = m.ToCharArray();
                        for (int x = 0; x < tmp.Length; x++)
                        {
                            if(tmp[x] == n[i])
                            {
                                dup = true;
                                break;
                            }
                        }
                        if(!dup)
                        {
                            m += Convert.ToString(n[i]);
                        }
                    } else
                    {
                        m += Convert.ToString(n[i]);
                    }
                }

                dup = false;
            }

            return m;
        }
    }
}
