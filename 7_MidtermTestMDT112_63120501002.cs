using System;

namespace _7_MidtermTestMDT112_63120501002
{
    class Program
    {
        static void Main(string[] args)
        {
            int Main()
            {
                double Number1;
                Console.WriteLine();
                double Number2;
                Console.WriteLine();
                double Number3;
                Console.WriteLine();
                double Number4;
                Console.WriteLine();
                double Number5;
                Console.WriteLine();
                double Number6;
                Console.WriteLine();

                while (1)
                {
                    Input("\n Enter operator and number [p0 exit] : ");
                    Output(" %c %f", &operator, &input);

                    if (double == 'p')
                    {
                        break;
                    }

                    switch (double)
                    {
                        case '(a+bi)+(c+di)=(a+c)+(b+d)i':
                            result += input;
                            break;
                        case '(a+bi)-(c+di)=(a-c)+(b-d)i':
                            result -= input;
                            break;
                        case '(a+bi)(c+di)=(ac-bd)+(ad+bc)i':
                            result *= input;
                            break;
                        case '(a+bi)(c+di)=((ac+bd)(c2+d2))+((bc-ad)(c2+d2))i; c+di0':
                            result /= input;
                            break;
                        case '(a+bi)n=(a+bi)(a+bi)n-1,(a+bi)0=1;n1':
                            result /= input;
                            break;
                        case 'a+bi=a2+b2':
                            result /= input;
                            break;
                    }
                    Output(" Result is %.2f\n", result);
                }
                Console.ReadLine();
            }
        }
    }
}



