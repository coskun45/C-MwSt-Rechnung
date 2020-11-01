using System;

namespace onlineScharfeKuche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herzlich Wilkommen Online Scharfe Küche!");
            double pfeffer = 5.10, paprika = 3.90, curry = 4.50, shippingFee = 3.90, subTotal, amount, vat;
            int pfefferCount, paprikaCount, curryCount;


            Console.WriteLine();

            Console.Write("Pfeffer (à 5,10 ?):     ");
            pfefferCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Paprika (à 3,90 ? :     ");
            paprikaCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Curry   (à 4,50?) :     ");
            curryCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine();

            subTotal = (pfeffer * pfefferCount) + (paprika * paprikaCount) + (curry * curryCount);
            vat = (subTotal / 1.16) * 0.16;

            if (subTotal < 10)
            {


                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("Ihre Bestellung erreicht nicht den Mindestbestellwert von 10,00 Euro");
            }
            else
            {
                if (subTotal > 25 && subTotal < 30)
                {
                    Console.WriteLine("Herzlich Wilkommen Bei Scharfe Küche!");
                    Console.WriteLine("Pfeffer (à 5,10?):     " + pfefferCount);
                    Console.WriteLine("Paprika (à 3,90?):     " + paprikaCount);
                    Console.WriteLine("Curry (à 4,50?)  :     " + curryCount);
                    Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

                    Console.WriteLine("Ihnen fehlen nur noch 4,80 Euro bis zum kostenfreien Versand!");
                    Console.WriteLine("Wollen Sie noch eine Dose Pfeffer mehr bestellen und den Versand sparen(ja | nein)");
                    string answer = Console.ReadLine();

                    if (answer.ToUpper() == "JA")
                    {
                        pfefferCount++;
                        shippingFee = 0;

                        Console.WriteLine("Bestellbestätigung durch Scharfe Küche:");

                        Console.Write("Pfeffer                    ");
                        Console.Write(pfefferCount + " x " + pfeffer);
                        Console.Write("                      ");
                        Console.WriteLine(pfefferCount * pfeffer + "  EUR");

                        Console.Write("Paprika                    ");
                        Console.Write(paprikaCount + " x " + paprika);
                        Console.Write("                      ");
                        Console.WriteLine(paprikaCount * paprika + "  EUR");

                        Console.Write("Curry                      ");
                        Console.Write(curryCount + " x " + curry);
                        Console.Write("                      ");
                        Console.Write(curryCount * curry + "   EUR");

                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------------------------------------------------------");
                        Console.WriteLine();

                        subTotal = (pfeffer * pfefferCount) + (paprika * paprikaCount) + (curry * curryCount);

                        vat = (subTotal / 1.16) * 0.16;


                        Console.WriteLine("Zwischensumme                                           " + Math.Round(subTotal, 2) + "  EUR");

                        Console.WriteLine("Erhaltene MwST (%16)                                    " + Math.Round(vat, 2) + "  EUR");

                        Console.WriteLine("Versandpauschale                                          " +Math.Round( shippingFee, 2) + "   EUR");

                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        amount = subTotal + shippingFee;
                        Console.Write("Summe                                                    " + Math.Round(amount, 2));
                        Console.Write(" EUR");

                    }
                    else
                    {

                        Console.WriteLine("                      ");

                        Console.WriteLine("Bestellbestätigung duch Scharfe Küche:");

                        Console.Write("Pfeffer                    ");
                        Console.Write(pfefferCount + " x " + pfeffer);
                        Console.Write("                      ");
                        Console.WriteLine(pfefferCount * pfeffer + "  EUR");

                        Console.Write("Paprika                    ");
                        Console.Write(paprikaCount + " x " + paprika);
                        Console.Write("                      ");
                        Console.WriteLine(paprikaCount * paprika + "  EUR");

                        Console.Write("Curry                      ");
                        Console.Write(curryCount + " x " + curry);
                        Console.Write("                      ");
                        Console.Write(curryCount * curry + "  EUR");

                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------------------------------------------------------------");
                        Console.WriteLine();

                        Console.WriteLine("Zwischensumme                                           " + Math.Round(subTotal, 2) + " EUR");

                        Console.WriteLine("Erhaltene MwST (%16)                                      " + Math.Round(vat, 2) + " EUR");

                        Console.WriteLine("Versandpauschale                                        " + Math.Round(shippingFee, 2) + "  EUR");
                        Console.WriteLine("------------------------------------------------------------------------------------");
                        Console.WriteLine();
                        amount = subTotal + shippingFee;
                        Console.Write("Summe                                                                " + Math.Round(amount, 2));
                        Console.Write("EUR");

                        Console.WriteLine();
                    }
                }
                else
                {
                    if (subTotal > 30)
                    {
                        shippingFee = 0;
                    }

                    Console.WriteLine("                      ");

                    Console.WriteLine("Bestellbestätigung duch Scharfe Küche:");

                    Console.Write("Pfeffer                    ");
                    Console.Write(pfefferCount + " x " + pfeffer);
                    Console.Write("                      ");
                    Console.WriteLine($"{pfefferCount *  pfeffer:f2}" + "  EUR");

                    Console.Write("Paprika                    ");
                    Console.Write(paprikaCount + " x " + paprika);
                    Console.Write("                      ");
                    Console.WriteLine(paprikaCount * paprika + "  EUR");

                    Console.Write("Curry                      ");
                    Console.Write(curryCount + " x " + curry);
                    Console.Write("                      ");
                    Console.Write(curryCount * curry + "    EUR");

                    Console.WriteLine();
                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    Console.WriteLine("Zwischensumme                                           " + Math.Round(subTotal, 2) + "  EUR");

                    Console.WriteLine("Erhaltene MwST (%16)                                    " + Math.Round(vat, 2) + "   EUR");

                    Console.WriteLine("Versandpauschale                                        " + Math.Round(shippingFee, 2) + "     EUR");
                    Console.WriteLine("-----------------------------------------------------------------------------------------------");
                    Console.WriteLine();
                    amount = subTotal + shippingFee;
                    Console.Write("Summe                                                   " + Math.Round(amount, 2));
                    Console.Write("  EUR");

                    Console.WriteLine();
                }
            }

        }
    }
}
