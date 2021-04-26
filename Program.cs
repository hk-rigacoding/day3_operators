using System;

namespace day3_operators
{

    public class Telefons //veidoju vērtības kas vēlāk tiks definētas
    {
        public string nosaukums;
        public int gads;
        public double cena;
        public bool eiropa;
        int ints;
    }
    public class Pircejs //veidoju vērtības kas vēlāk tiks definētas
    {
        public string vards;
        public double nauda;
        //public string telef;
        public Telefons t;

    }




    class Program
    {

        static int Ievade ()
        {
            //ievadi šīs dienas (nedēļas) skaitli
            Console.WriteLine("Ievadi skaitli ...");
            //ievades dati
            string ievade = Console.ReadLine();
            //paartaisam par skaitli
            //int nedeeljas_diena = Convert.ToInt32(ievade);

            int nedeeljas_diena;

            bool rez = Int32.TryParse(ievade, out nedeeljas_diena);

            if (rez == false)
                return -1;

            //izvadīt skaitli kā nosaukumu
            return nedeeljas_diena;
        }




        static void Main(string[] args)
        {

            Telefons telefons1 = new Telefons(); //jauns objekts telefons 1
            telefons1.nosaukums = "Samsung";
            telefons1.gads = 2015;
            telefons1.cena = 249.99;
            telefons1.eiropa = true;

            Pircejs p1 = new Pircejs();
            p1.nauda = 69.51;
            p1.vards = "Pirmais !";
            p1.t = telefons1;


            Console.WriteLine("Pirceejs = " + p1.vards + " Telefons = " + p1.t.nosaukums);


            Pircejs p2 = new Pircejs();
            p2.nauda = 77;
            p2.vards = "Otrais !";
            p2.t = telefons1;
            

            Console.WriteLine("Pirceejs = " + p2.vards + " Telefons = " + p2.t.nosaukums);

            int skaitlis1 = 5, skaitlis3 = 8, skaitlis4 = 1;
            int skaitlis2 = 10;

            //+, - *, / %
            
            //1
            skaitlis1 = skaitlis1 + 1;

            //2
            skaitlis1 += 1;

            //3
            skaitlis1++;



            Console.WriteLine("Skaitlis1 = " + skaitlis1);

            skaitlis4 = skaitlis1++;
            skaitlis2 = ++skaitlis1;

            Console.WriteLine("Skaitlis4 = " + skaitlis4);
            Console.WriteLine("Skaitlis2 = " + skaitlis2);

            //skaitlis2 /= 2;
            //Console.WriteLine("Skaitlis2 =    " + skaitlis2);

            //double sk_d = 17;


            double skaitlis5 = (double)skaitlis2 / 0;

            Console.WriteLine("Skaitlis5 = " + skaitlis5);


            //17 / 3
            //15 / 3  = 5
            //2
            //kaa lietot ?
            int skaitlis6 = skaitlis2 % 2;


            //netipisks piemeers
            float y = 1.2f;
            y++;

            if (skaitlis1 == 0)//true
            {
                Console.WriteLine("Skaitlis 1 ir nulle");
            } else 
            {
                Console.WriteLine("Skaitlis 1 nav nulle");
            }


            //=4
            //=3

            skaitlis1 = 3;

            if (skaitlis1 > 3)//true
            {
                Console.WriteLine("Skaitlis 1 > 3");
            }
            else // izpildās cits
            {
                Console.WriteLine("Skaitlis 1 <= 3");
            }



            skaitlis1 = 3;

            if (skaitlis1 >= 3)//true
            {
                Console.WriteLine("Skaitlis 1 >= 3");
            }
            else // izpildās cits
            {
                Console.WriteLine("Skaitlis 1 < 3");
            }



            skaitlis1 = 4;

            if (skaitlis1 != 3 )//true
            {
                Console.WriteLine("Skaitlis 1 != 3");
            }
            else // izpildās cits
            {
                Console.WriteLine("Skaitlis 1 == 3");
            }


            skaitlis1 = 6;


            //|| vai
            //&& un

            if (skaitlis1 > 1 || skaitlis1 > 5 || skaitlis1 > 10)//true
            {
                Console.WriteLine("Skaitlis 1 != 3");
            }
            else // izpildās cits
            {
                Console.WriteLine("Skaitlis 1 == 3");
            }



            // != identisks
            skaitlis1 = 6;
            if (skaitlis1 > 1)//true
            {
                Console.WriteLine("Skaitlis 1  > 1");

                if (skaitlis1 > 5)
                {
                    Console.WriteLine("Skaitlis 1 > 5");
                }
                if (skaitlis1 > 10)
                {
                    Console.WriteLine("Skaitlis 1 > 10");
                }
            }
            else if (skaitlis1 > 5)
            {
                Console.WriteLine("Skaitlis 1 != 3");
            }
            else if (skaitlis1 > 10)
            {
                Console.WriteLine("Skaitlis 1 != 3");
            }


            skaitlis1 = 6;

            if (skaitlis1 > 1 && skaitlis1 > 5 && skaitlis1 > 10)//true
            {
                Console.WriteLine("Skaitlis 1 != 3");
            }
            else // izpildās cits
            {
                Console.WriteLine("Skaitlis 1 == 3");
            }


            skaitlis1 = 6;
            if (skaitlis1 > 1)
            {

                Console.WriteLine("Skaitlis 1 > 1");

                if (skaitlis1 > 5)
                {
                    Console.WriteLine("Skaitlis 1 > 5");
                    if (skaitlis1 > 10)
                    {
                        Console.WriteLine("Skaitlis 1 > 10");
                    }

                }
            }




            //(skaitlis1 == 0 || skaitlis1 == 1 || skaitlis1 == 2 )






            int diena = Ievade();

            //switch (Ievade())
            switch (diena)
            {

                case -1:
                    Console.WriteLine("Nepareiza diena !");
                    break;
                case 2:
                    Console.WriteLine("Otriena");
                    break;
                case 1:
                    Console.WriteLine("Pirmdiena");
                    break;
                case 3:
                    Console.WriteLine("Trešdiena");
                    break;
                case 4: Console.WriteLine("Ceturtdiena");
                    break;
                case 5:
                    Console.WriteLine("Piektdiena");
                    break;
                case 6:
                    Console.WriteLine("Sestdiena");
                    break;
                case 7:
                    Console.WriteLine("Svētdiena");
                    break;

                default: Console.WriteLine("Nepareiza nedēļas diena !!!");
                    break;
            }




            string test = "tests";

            switch (test)
            {

                case "1":
                    Console.WriteLine("1");
                    break;

                case "tests":
                    Console.WriteLine("tests");
                    break;


                default: Console.WriteLine("Nākotne");
                    break;
            }


            bool test_bool = false;

            switch (test_bool)
            {
                case false: Console.WriteLine(test_bool); break;
                case true: Console.WriteLine(test_bool); break;
            }


            diena = 1;

            if ((diena > 0 && diena < 8) || (diena == -1))
            //if ((diena > 0) && (diena < 8 || diena == -1))
            {
                //kods derīgām dienām un nepareizam reultātam

                int t = 6;
            }





            int rez_sk_simple;

            //garais pieraksts
            if (skaitlis1 == 1)//true
            {
                Console.WriteLine("Skaitlis 1 == 1");
                rez_sk_simple = skaitlis1;
            }
            else // izpildās cits
            {
                Console.WriteLine("Skaitlis 1 != 1");
                rez_sk_simple = -1;
            }
                                                //true           //false
           //ternārais
            string rez = skaitlis1 == 1 ? "Skaitlis 1 == 1" : "Skaitlis 1 != 1";

            //rez_sk piešķirt vērtību
            //atkarībā no skaitlis1 vērtības.
            //

            skaitlis1 = 3;

            //true/false =  true        false 
            int rez_sk = skaitlis1 == 1 ? skaitlis1 : -1;

            

            rez_sk = skaitlis1 == 1 ? 10 :
                                skaitlis1 == 2 ? 20 :
                                    skaitlis1 == 3 ? 30 : 0;

            Console.WriteLine(rez_sk);
            Console.WriteLine("Hello World!");
        }
    }
}
