// See https://aka.ms/new-console-template for more information
namespace grading{
    class grades
    {
       
        static void Main(String[] args)
        {
            Console.WriteLine("How many students are there ?");
            int no = int.Parse(Console.ReadLine());
            char[] G=new char[no];
            Console.WriteLine("Enter the mark of the students respectively ");
            for (int i = 0; i < no; i++)
            {
                double a = Double.Parse(Console.ReadLine());
                if (a < 0)
                {
                    Console.WriteLine("the mark can not be negative");
                }
                else if (a <= 40)
                {
                    G[i] = 'F';
                }
                else if (a >= 40 && a < 60)
                {
                    G[i] = 'D';
                }
                else if (a >= 60 && a < 70)
                {
                    G[i] = 'C';
                }
                else if (a >= 70 && a < 80)
                {
                    G[i] = 'B';
                }
                else if (a >= 80 && a < 100)
                {
                    G[i] = 'A';
                }
                else if (a > 100)
                {
                    Console.WriteLine("The mark can not be Greater than 100 !");
                }
               
            }
            for(int i = 0; i < no ; i++)
            {
                Console.WriteLine(G[i]);
            }
        }
    }
 }
