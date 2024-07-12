using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUsingAString
{
    public class CalcFromString
    {
        //field
        private List<string> CalcList = new List<string>();
        // Property
        private string[] SymbolArray { get; } = { "/", "*", "+", "-" };



        //method
        public string RunCalc(string Calc)
        {
            // string symbol = null;
            //we need to add deliminators to the calculation

            //loop through each symbol 
            for (int i = 0; i < 4; i++)
            {
                string sym = SymbolArray[i];  // SymbolArray[i];

                //detect symbol in calc replace it with ,+,
                if (Calc.Contains(sym))
                {
                    //add deliminator
                    Calc = Calc.Replace(sym, @"," + sym + @",");
                }
            }
            // we need to split the calculation to an List


            CalcList.AddRange(Calc.Split(','));
            //BODMAS ()/*+-

            for (int i = 0; i < 4; i++)
            {
                string sym = SymbolArray[i];
                do //do multiple times
                {
                    //detect symbol in calc
                    if (CalcList.Contains(sym))
                    {
                        // Get the number before the symbol and after the symbol
                        int IndexOfSym = CalcList.IndexOf(sym);
                        int Index1 = IndexOfSym - 1; //number to the left
                        int Index2 = IndexOfSym + 1; //number to the right

                        Single num1 = Convert.ToSingle(CalcList[Index1]);
                        Single num2 = Convert.ToSingle(CalcList[Index2]);

                        switch (sym)
                        {
                            case "+":

                                //put the answer in the symbol place
                                CalcList[IndexOfSym] = (num1 + num2).ToString();
                                // remove the elemnts where the numbers used
                                CalcList.RemoveAt(Index2);
                                CalcList.RemoveAt(Index1);//if index1 is deleted first index2 changed place by one
                                break;
                            case "-":
                                CalcList[IndexOfSym] = (num1 - num2).ToString();
                                // remove the elemnts where the numbers used
                                CalcList.RemoveAt(Index2);
                                CalcList.RemoveAt(Index1);
                                break;
                            case "/":
                                CalcList[IndexOfSym] = (num1 / num2).ToString();
                                // remove the elemnts where the numbers used
                                CalcList.RemoveAt(Index2);
                                CalcList.RemoveAt(Index1);
                                break;
                            case "*":
                                CalcList[IndexOfSym] = (num1 * num2).ToString();
                                // remove the elemnts where the numbers used
                                CalcList.RemoveAt(Index2);
                                CalcList.RemoveAt(Index1);
                                break;
                        }


                    }
                } while (CalcList.Contains(sym));
            }

            //run cacl based on symbol used
            return CalcList[0];
        }
    }
}
