using System;


namespace ConsoleApplicationset3
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
                    for(int i=1;i<=5;i++)
                    {
                        Console.WriteLine("*");
                    }
            */
            /*      for (int i = 10; i <=15; i++)
                   {
                       Console.WriteLine("i");
                   }
       */
            /* int i = 1;
             for(  ;i<=10;  )
             {
                 Console.WriteLine( i);
                 i++;
             }
 */
            /* for (int i = 5; i >= 1; i--)
             {
                 Console.WriteLine(i);
             }
             */
            /*
            for(int i=5;i<=1;i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
               int sum = 0;
               for (int i = 0;i<=5;i++)
               {
                 sum = sum + i;
               }
                Console.WriteLine(sum);
              */


            /*  Console.WriteLine("enter the value");
              int n1= int.Parse(Console.ReadLine());
              Console.WriteLine("enter the value");
              int n2 = int.Parse(Console.ReadLine());
              for (int i = n1; i >= n2; i--)
              {
                  Console.WriteLine("i");
              }
              */
            /*
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine(n);
            }
            */
            /*
            Console.WriteLine("enter the  m number");
            int m= int.Parse(Console.ReadLine());

            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());

            for (int i = m; i<= n; i++)
            {
                Console.WriteLine(i);
            }
            */
            /*
            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) 
              if(i % 2 == 0)
              {
                Console.WriteLine(i);
               }
            */
            /*
           Console.WriteLine("enter the n number");
           int n = int.Parse(Console.ReadLine());
           for (int i = 1; i <= n; i++)
               if (i % 2 != 0)
               {
                   Console.WriteLine(i);
               }
           */
            /*
            Console.WriteLine("enter the  m number");
            int m= int.Parse(Console.ReadLine());
            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());
            for(int i=m;i<=n;i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            */
            /*
            Console.WriteLine("enter the  m number");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());
            for (int i = m; i <= n; i++)
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);

                }
            */
           /*
            Console.WriteLine("enter the n number");
            int n= int.Parse(Console.ReadLine());
            for(int i=1;i<=100;i++)
                if (i % n == 0)
                {
                    Console.WriteLine(i);
                }
            */
            /*
                        Console.WriteLine("enter the n number");
                        int n = int.Parse(Console.ReadLine());
                        for(int i=1;i<=20;i++)
                        {
              
                                Console.WriteLine(i*n);
                            }
                     */
            /*
              Console.WriteLine("enter the n number");
              int n = int.Parse(Console.ReadLine());
              int sum = 0;
              for(int i = 0;i<=n;i++)
                  if(i % 2==0)
              {
                  sum=sum+i;
              }
              Console.WriteLine(sum);
              
             * /
              /* 
               Console.WriteLine("enter the n number");
              int n = int.Parse(Console.ReadLine());
              int sum = 0;
              for(int i = 0;i<=n;i++)
                  if(i % 2!=0)
              {
                  sum=sum+i;
              }
              Console.WriteLine(sum);
            
              */
            /*
            Console.WriteLine("enter the  k number");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i =1; i<=n; i++)
              if (i % k == 0)
                {
                    sum = sum + i;
                }
           
       Console.WriteLine(sum);
          */
            /*
            Console.WriteLine("enter the  n number");
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i <=1; i++)
                if (n % 3 ==0)
                {
                    Console.WriteLine("fizz");
                }
                 else if (n % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                  else if (n % 3 % 5 != 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
            */

           /*
              Console.WriteLine("enter the numbers");
              int n = int.Parse(Console.ReadLine());
              int sum = 1;
              for (int i = 1; i <=n ;i++)
              
              {
                  sum = sum * i;
              }
              Console.WriteLine(sum);
             */
            /*
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            for(int i=1;i<=n;i++)
            {
                Console.WriteLine("enter the mark");
                int mark=int.Parse(Console.ReadLine());
                total = total + mark;
            }
            Console.WriteLine(total);
            Console.WriteLine(total/n);
            */

            /*
            
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("enter the round");
                int round = int.Parse(Console.ReadLine());
                total=total+ round;
                Console.WriteLine(total);

            }
            */
            /*
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i); ;
                i++;
            }
            */
            /*
            while (true)
            {
                Console.WriteLine("do u want to close");
                string res = Console.ReadLine();
                if (res == "yes")
                {
                    break;
                }
            }
            */
            /*
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);
            */
            /*
            string res = " ";
            do
            {
                Console.WriteLine ("do u want to close");
                 res = Console.ReadLine();
            }
            while (res == "yes");
            */
            /*
            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
            */
            /*
            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            
            while (i <= n)
            {
                if (i % 2 == 0)
                Console.WriteLine(i);
                i++;
            }
            */
            /*
            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            do
       
            {
                if (i % 2 == 0) 
                Console.WriteLine(i);
               
                i++;
            }
            while(i<=n);
            */

/*
            while (true)
            {

                Console.WriteLine("1.Addition(+)");

                Console.WriteLine("2.subraction(-)");

                Console.WriteLine("3.multiplication(*)");

                Console.WriteLine("4.division(/)");

                Console.WriteLine("5.modulo(%)");
                int res = int.Parse(Console.ReadLine());

                if (res == 1)
                {
                    int a = 10;
                    int b = 5;
                    Console.WriteLine(a + b);
                }
                else if (res == 2)
                {
                    int a = 10;
                    int b = 5;
                    Console.WriteLine(a - b);
                }

                Console.WriteLine("do u want to close");
                String ures = Console.ReadLine();

                if (ures == "yes")
                {
                    break;
                }
            }
            */
            
            /*
             int uc = 0;
             int cc = 0;
             for (int i = 1; i <=3; i++)
             {
                 Console.WriteLine("draw");
                 Console.WriteLine("user win");
                 Console.WriteLine("ai win");
                 Console.WriteLine("enter ur choice");
                 int n = int.Parse(Console.ReadLine());
                 Random r = new Random();
                 int ai =r.Next (1,3);
                 if (n % 2 != 0)
                 {
                     Console.WriteLine("user win");
                     uc++;
                 }
                 else if (n % 2 == 0)
                 {
                     Console.WriteLine("ai win");
                     cc++;
                 }
                 else if (uc == cc)
                 {
                     Console.WriteLine("draw");
                 }
                 break;


             }
             * */
             
            /*
            Console.WriteLine("enter m number");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int i = m;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
            */
            /*
            Console.WriteLine("enter m number");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int i = m;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= n);
            */
            /*
            Console.WriteLine("enter m number");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int i = m;
            while (i <= n)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }
            */
            /*
            Console.WriteLine("enter m number");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int i = m;
            while (i <= n)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
                i++;
            }
            */
            /*
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <=100) 
            {
                if(i%n==0)
                    Console.WriteLine( i);
                i++;
            }

            */
            /*
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while(i<=20)
            {
             
                    Console.WriteLine(i*n);
                i++;
            }
            */
            /*
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            do
            {
                Console.WriteLine(i * n);
                i++;
            }
            while (i <= 20);

            */
            /*
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int i  = 1;
            int sum = 0;
            while (sum<= n)
            {
                sum = sum + i;
                    Console.WriteLine(sum);
               i++;
            }
            */
            /*
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            do
            {
                sum = sum + i;
                Console.WriteLine(sum);
                i++;
            }
            while (sum <= n) ;
            */
            /*
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            do
            {
                if (i % 2 == 0)
                    sum = sum + i;
                Console.WriteLine(sum);
                i++;
            }
            while (i <= n);
            */
            /*
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            int sum = 0;
            while (i <= n) 
            {
                if (i % 2 != 0)
                    sum = sum + i;
                Console.WriteLine(sum);
                i++;
            }

            */
            /*
            Console.WriteLine("enter n mumber");
            int n = int.Parse(Console.ReadLine());
           
              int i=1;
            while(i<=1)
            
                
                if (n % 3 == 0)
                    {
                        Console.WriteLine("fizz");
                        i++;
                    }
                    else if (n % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    i++;
                }
                   else if ( n % 3 % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                      i++;
                }
            
                else
                      {
                       Console.WriteLine("invalid number");
                       i++
                     }
            */
            /*
            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            do
            
              if (n%3==0)
              {
                  Console.WriteLine("fizz");
                  i++;
              }

              else  if (n%5==0)
              {
                  Console.WriteLine("buzz");
                  i++;
              }
              else if (n%3%5==0)
              {
                  Console.WriteLine("fizzbuzz");
                  i++;
              }
              while(i<=1);
            */
            /*
            Console.WriteLine("enter n number");
            int n = int.Parse(Console.ReadLine());
            int sum  = 1;
            int i = 1;
            while (i <= n)
            {
                sum = sum * i;

                Console.WriteLine(sum);
                i++;
            }

            */
            /*
            Console.WriteLine("enter the n number");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 1;
            do
            {
                sum = sum * i;
                Console.WriteLine(sum);
                i++;
            }
            while (i <= n);

            */
            /*
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int total=0;
            int i=1;
            while(i<=n)
            {
                Console.WriteLine("enter the mark");
                int mark=int.Parse(Console.ReadLine());
                total=total+mark;
                i++;
            }

            Console.WriteLine(total);
            Console.WriteLine(total/n);
            
          */
            /*
             Console.WriteLine("enter n number");
             int n = int.Parse(Console.ReadLine());
             int total=0;
             int i = 0;
             do
             {
               Console.WriteLine("enter the mark");
                 int mark=int.Parse(Console.ReadLine());
                 total=total+mark;
                 i++;
                
             Console.WriteLine(total);
            Console.WriteLine(total/n);
             
             }
            
           while(i<=n);
            */
            /*
            Console.WriteLine("enter the number");
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            int i = 0;
            while(i<=n)
            {
                Console.WriteLine("enter the round");
                int round = int.Parse(Console.ReadLine());
                total = total + round;
                i++;
            }

            Console.WriteLine(total);
            */
            /*

                        Console.WriteLine("enter the number");
                        int n = int.Parse(Console.ReadLine());
                        int total = 0;
                        int i = 0;
                        do
                        {
                            Console.WriteLine("enter the round");
                            int round = int.Parse(Console.ReadLine());
                            total = total + round;
                            i++;
                            Console.WriteLine(total);
                        }

                        while (i <= n);
                        */















        }
    }

      
            }
         
          
         
        
          
