using System;

namespace ConsoleApplication4
{
    class Jesus
    {
        static void Main(string[] args)
        {
               Console.WriteLine("enter the age");
                int age = int.Parse(Console.ReadLine());
            
               if (age >18 && age < 80) 
                {
                Console.WriteLine("can vote");
                }
              
                else if(age > 0 && age < 18)
                {
                 Console.WriteLine("cannot vote");
                }   
                else
                {
                    Console.WriteLine("invalid age");
                }
        
             
            
          Console.WriteLine("enter the mark");
            int mark = int.Parse(Console.ReadLine());
            if (mark > 90 && mark < 100)
            {
                Console.WriteLine("a");
            }
            else if (mark > 80 && mark < 90)
            {
               Console.WriteLine("b");
            }
             else if (mark > 70 && mark < 80) 
            {
                Console.WriteLine("c");
            }
            else if (mark >50  && mark < 70)
            {
                Console.WriteLine("d");
            }
            else if (mark > 35 && mark <50)
            {
                Console.WriteLine("e");
            }

            else
            {
                Console.WriteLine("invalid mark");
            }
           
              
            /* 
            
              int age = 32;
              string res = age > 18 ? "can vote" : "can Not vote";

              Console.WriteLine("result");
              
            
            
                         Console.WriteLine("enter the month");
                         int month = int.Parse(Console.ReadLine());
                         switch(month)
                         {
                             case 1:
                             Console.WriteLine("january");
                              break;
                           case 2:
                             Console.WriteLine("february");
                              break;
                           case 3:
                             Console.WriteLine("march");
                             break;

                           case 4:
                             Console.WriteLine("april");
                             break;

                           case 5:
                             Console.WriteLine("may");
                             break;

                           case 6:
                             Console.WriteLine("june");
                             break;
                           case 7:
                             Console.WriteLine("july");
                             break;
                           case 8:
                             Console.WriteLine("august");
                             break;

                           case 9:
                             Console.WriteLine("september");
                             break;

                           case 10:
                             Console.WriteLine("octomber");
                             break;

                           case 11:
                             Console.WriteLine("novembe");
                             break;
                          case 12:
                             Console.WriteLine("decamber");
                             break;
                           default:
                             Console.WriteLine("invalid month");
                             break;
                        }
             */
                  
             
                        Console.WriteLine("enter the number");
                         int n=int.Parse(Console.ReadLine());

                         if (n > 0)
                         {
                             Console.WriteLine("positive number");
                         }
                         else
                         {
                             Console.WriteLine("negative number");
                          }
            
                       
                         Console.WriteLine("enter the number1");
                         int n1 = int.Parse(Console.ReadLine());
                         Console.WriteLine("enter the number2");
                         int n2 = int.Parse(Console.ReadLine());
                         if (n1 == n2)
                         {
                             Console.WriteLine("equal");
                         }
                         else
                              {
                             Console.WriteLine("not equal");
                              }
                        
                     
                     
            
            Console.WriteLine("enter the number1");
            float              number1 =
            float.Parse(Console.ReadLine());
            Console.WriteLine("enter the number2");
            float              number2 =
            float.Parse(Console.ReadLine());
            if (number1==number2)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            
             
            
            Console.WriteLine("enter the value");
            int v = int.Parse(Console.ReadLine());
            if (v /2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            
             
            
            Console.WriteLine("enter the year");
            int y = int.Parse(Console.ReadLine());
            if (y % 4 == 0 && y % 100 != 0)
            {
                Console.WriteLine("leap year");
            }
            else if (y % 400 == 0)
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not leap year");
            }
             

           /* 
            Console.WriteLine("enter the age");
            int age = int.Parse(Console.ReadLine());
            if (age > 18 && age < 80)
            {
                Console.WriteLine("can vote");
            }

            else if (age > 0 && age < 18)
            {
                Console.WriteLine("can not vote");
            }
            else
            {
                Console.WriteLine("invalid vote");
            }
             */

            
            Console.WriteLine("enter the vaue");
            int h = int.Parse(Console.ReadLine());
            if (h > 170)
            {
                Console.WriteLine("tall");
            }
            else if (h<170 && h>150)
            {
            Console.WriteLine("medium");
            }
            else if (h<150)
            {
                Console.WriteLine("short");
            }
            else
            {
                Console.WriteLine("invailid ");
            }
          
            
            Console.WriteLine("enter the number a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number b ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the number c");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("largest number "+ a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("largest number"+b);
            }
            else if (c > a &&  c > b)
            {
                Console.WriteLine("largest number"+c);
            }
            else
            {
                Console.WriteLine("invalid number");
          

            /*
            Console.WriteLine("enter three value");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter three value");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter three value");
            int c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("smallest number"+a);
            }
            else if (b < a && b < c)
            {
                Console.WriteLine("smallest number"+b);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine("smallest number"+c);
            }
           */
            
             

            /*
                      Console.WriteLine("enter the number a");
                      int a = int.Parse(Console.ReadLine());
                      Console.WriteLine("enter the number b");
                      int b = int.Parse(Console.ReadLine());
                      Console.WriteLine("enter the number c");
                      int c = int.Parse(Console.ReadLine());
                      Console.WriteLine("enter the number d");
                      int d = int.Parse(Console.ReadLine());

                      if (a > b && a > c && a > d)
                      {
                          Console.WriteLine("largest number" + a);
                      }

                       else if (b > a && b > c && b > d)
                      {
                          Console.WriteLine("largest number" + b);
                      }
                       else if (c > a && c > b && c > d)
                      {
                          Console.WriteLine("largest number" + c);
                      }

                      else if (d > a && d > b && d > c)
                      {
                          Console.WriteLine("largest number" + d);
                      }
             */
             
             /*    
            Console.WriteLine("enter the  a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the  b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the  c");
            int c = int.Parse(Console.ReadLine());
            int ab =Math.Abs(a-b);
            int bc=Math.Abs(b-c);
            int ac=Math.Abs(a-c);

            int small=ab;
            if (bc<small)
            {
               small=bc;
            }
            if( ac<small) 
            {
                small=ac;
            }

            if (small == ab)
            {
                Console.WriteLine(a + " " +b +"closer");
            }
            if (small == ac)
            {
                Console.WriteLine(a + " " + c + "closer");
            }
            if (small == bc)
            {
                Console.WriteLine(b + " " + c + "closer");
            }
            */
           
            /*
            Console.WriteLine("enter the  a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the  b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the  c");
            int c = int.Parse(Console.ReadLine());
            int ab =Math.Abs(a-b);
            int bc=Math.Abs(b-c);
            int ac=Math.Abs(a-c);

            int large=ab;
            if (bc>large)
            {
               large=bc;
            }
            if( ac>large) 
            {
                large=ac;
            }

            if (large == ab)

            {
              Console.WriteLine(a + " " +b +"farther");
            }
            if (large == ac)
            {
                Console.WriteLine(a + " " + c + "farther");
            }
            if (large == bc)
            {
                Console.WriteLine(b + " " + c + "father");
           }
           */ 
            
             
          /* 
            Console.WriteLine("enter the  a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the  b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the  c");
            int c = int.Parse(Console.ReadLine());
            int ab =Math.Abs(a-b);
            int bc=Math.Abs(b-c);
            int ac=Math.Abs(a-c);

            int small=bc;
            if (bc<small)
            {
               small=bc;
            }
            if( ac>small) 
            {
                small=ac;
            }

            if (small == ab)
            {
                small = ab;
            }
            int large=ab;

            if (bc>large)
            {
               large=bc;
            }
            if( ac>large) 
            {
                large=ac;
            }
            if (ab > large)
            {
                large = ab;
            }
            int m = a + b + c - small - large;
            Console.WriteLine("small");
            Console.WriteLine("medium");
            Console.WriteLine("large");
            */
            
            
            Console.WriteLine("enter the letter");                                 
            string letter =(Console.ReadLine());
            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("constant");
            }
          
            
           /*
                        Console.WriteLine("enter the number");
                        int d = int.Parse(Console.ReadLine());
                        int res = d % 7;
                        if(res==1)
                        {
                            Console.WriteLine("monday");
                        }
                        else if (res == 2)
                        {
                            Console.WriteLine("tuesday");
                        }
                        else if (res == 3)
                        {
                            Console.WriteLine("wednesday");
                        }

                        else if (res == 4)
                        {
                            Console.WriteLine("thusday");
                        }

                        else if (res == 5)
                        {
                            Console.WriteLine("friday");
                        }
                        else if (res == 6)
                        {
                            Console.WriteLine("saturday");
                        }
                        else if (res == 7)
                        {
                            Console.WriteLine("sunday");
                        }
            * /
                     
           /*
              Console.WriteLine("enter the number a");
              int a = int.Parse(Console.ReadLine());
              
    
            Console.WriteLine("enter the number b");
              int b = int.Parse(Console.ReadLine());

              Console.WriteLine("enter the number c");
              int c = int.Parse(Console.ReadLine());

              if (a == b && b == c)
              {
                  Console.WriteLine("equilateral");
              }
              else if(a == b && b!=c)
              {
                  Console.WriteLine("isosceles");
              }
              else if (a!=b && b!=c)
              {
                  Console.WriteLine("scalene");
              }
              */
             
            /*
              Console.WriteLine("enter the row");
              int r = int.Parse(Console.ReadLine());

              Console.WriteLine("enter the coloum");
              int c = int.Parse(Console.ReadLine());
              if ((r + c) % 2 == 0)
              {
                  Console.WriteLine("black");
              }
              else 
              {
                  Console.WriteLine("weight");
              }
            */
              


           
             
                        Console.WriteLine("enter the days");
                        int days = int.Parse(Console.ReadLine());
                        switch (days)
                        {
                            case 1:
                                Console.WriteLine("31+jan");
                                break;
                            case 2:
                                Console.WriteLine("28+feb");
                                break;
                            case 3:
                                Console.WriteLine("31+mar");
                                break;

                            case 4:
                                Console.WriteLine("30+april");
                                break;

                            case 5:
                                Console.WriteLine("31+may");
                                break;

                            case 6:
                                Console.WriteLine("30+june");
                                break;
                            case 7:
                                Console.WriteLine("31 +july");
                                break;
                            case 8:
                                Console.WriteLine("31+august");
                                break;

                            case 9:
                                Console.WriteLine("30+sep");
                                break;

                            case 10:
                                Console.WriteLine("31+oct");
                                break;

                            case 11:
                                Console.WriteLine("30+nov");
                                break;
                            case 12:
                                Console.WriteLine("31+dec");
                                break;
                            default:
                                Console.WriteLine("invalid days");
                                break;
                        }
          
             
                     
            /*
            Console.WriteLine("enter the value a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the value a");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value a");
            int c = int.Parse(Console.ReadLine());

            if (a+b+c==180)
            {
                Console.WriteLine("triangle");
            }
            else
            {
                Console.WriteLine("invalid value");
            }
*/
            
           
            
            Console.WriteLine("enter the side");
                int side = int.Parse(Console.ReadLine());
            if( side == 3)
            {
                Console.WriteLine("triangle");
            }
            else if (side == 4)
            {
                Console.WriteLine("quadrilateral");
            }
            else if(side==5)
            {
                Console.WriteLine("pentagon");
            }
             else if(side==6)
            {
                Console.WriteLine("hexagon");
             }
            else if(side==7)
            {
                Console.WriteLine("heptagon");
            }
            else if(side==8)
            {
                Console.WriteLine("octagon");              
            }
            else if(side==9)
            {
                Console.WriteLine("nonagon");
            }
            else if (side == 10)
            {
                Console.WriteLine("hendecagon");
            }
            
            
           
            /*
            Console.WriteLine("enter the coordinate x");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the coordinate y");
            int b = int.Parse(Console.ReadLine());
            if( +a == +b)
            {
                Console.WriteLine("1");
            }
            else if(+a==-b)
            {
                 Console.WriteLine("2");
            }
            else if (-a == -b)
            {
                Console.WriteLine("3");
            }
            else if(-a ==+b)
            {
                Console.WriteLine("4");
            }
            else if(-b==0)
            {
                Console.WriteLine("5");
            }
            else if(+a==0)
            {
                Console.WriteLine("6");
            }
            else if (a == b)
            {
                Console.WriteLine("7");
            }
            else
            {
                Console.WriteLine("no coornate");
            }
            
            */
            
             
            Console.WriteLine("enter the puchais");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the sales");
            int s = int.Parse(Console.ReadLine());

            if (p > s)
            {
                Console.WriteLine("loss");
            }

            else if (p < s)
            {
                Console.WriteLine("profit");
            }

            
            
            
      
            Console.WriteLine("1.Addition(+)");

            Console.WriteLine("2.subraction(-)");
            
            Console.WriteLine("3.multiplication(*)");
            
            Console.WriteLine("4.division(/)");

            Console.WriteLine("5.modulo(%)");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("addition");
            }
            else if (choice == 2)
            {
                Console.WriteLine("subraction");
            }
            else if (choice== 3)
            {
                Console.WriteLine("multiplication");
            }
            else if (choice == 4)
            {
                Console.WriteLine("division");
            }
            else if (choice == 5)
            {
                Console.WriteLine("modulo");
            }
           
           /* 
            
            Console.WriteLine("rock");
            Console.WriteLine("paper");
            Console.WriteLine("scissor");
            Console.WriteLine( "enter ur choice");
            int user = int.Parse(Console.ReadLine());
            Random r = new Random();
            int com = r.Next(1,3);
            if (user == 1 && com == 3)
            {
                Console.WriteLine("user win");
            }
            else if (com == 1 && user == 2) 
            {
                Console.WriteLine("user win");
            }
            else if (com==2 && user==3)
            {  
              Console.WriteLine("user win");
            }
            else if (user == com)
            {
                Console.WriteLine("draw");
            }
            else
            {
                Console.WriteLine("com win");

            }
            */
            
           
          
           /*
            Console.WriteLine("enter the date");
            int oct = int.Parse(Console.ReadLine());
            if (oct <10)
            {
                Console.WriteLine("not manju birthday");
            }
            else if (oct == 10)
            {
                Console.WriteLine("HAPPY BIRTHDAY MANJU");
            }
            */
         

           












           

        }
    }
    }


