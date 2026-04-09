using System.Linq;  

string Options =    "1.Suma Y Validación numérica \n" +
                    "2.Calculo Y Condicionales \n" +
                    "3.Manipulación De Cadenas \n" +
                    "4.Operaciones Logicas \n" +
                    "5.Analisis Numerico \n" +
                    "6.Gestion De Tareas \n" +
                    "7.Arreglos Y Busqueda \n" +
                    "8.Programación Orientada A Objetos \n" +
                    "9.Crud De Objetos \n" +
                    "10.Salir"; 
  Console.WriteLine(Options);



  bool stop = true;
  List<int> numbers = new List<int>();

  while (stop)
  {
      Console.WriteLine("Choose A Option");
      string selected = Console.ReadLine();
      

      switch (selected)
      {
          case "1":
              sum();
              break;
          case "2":
              grade();
              break;
          case "3":
              gret();
              break;
          case "4":
              operations();
              break;
          case "5":
              listt();
              break;
          case "6":
              //task();
              break;
          case "10":
              Console.Write("saliendo");
              Console.Clear();
              Console.WriteLine(Options);
              stop = false;
              break;
          default:
              Console.Clear();
              Console.WriteLine($"Please Select A Valid OPtion \n" + Options);
              break;
      }
  }

  
  //Option One
  void sum()
  {
      //Declare The Variables
      int number1;
      int number2;
      Console.WriteLine("Enter The First Number");
      //Whatever The User Types This Saves In the Number 1
      number1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter The Second Number");
      //Whatever The User Types This Saves In the Number 1  
      number2 = int.Parse(Console.ReadLine());
      /*The Result Saves In The Result Number
      --And This Note Is For Me 
      If You Not Declare The Variable,Well Doesn't WorkS*/ 
      int result = number1 + number2;
      Console.WriteLine("The Result Of The Sum Is {0}",result);
      
  }

  //Option Two
  void grade()
  {
      double grade1;
      double grade2;
      double grade3;
      Console.WriteLine("Put Your First Grade AssHole");
      grade1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Put Your Second Grade AssHole");
      grade2 = double.Parse(Console.ReadLine());
      Console.WriteLine("Put Your Third Grade AssHole");
      grade3 = double.Parse(Console.ReadLine());
      double resultf = (grade1 + grade2 + grade3)/3;
      if (resultf >= 3.0)
      {
          //Console.WriteLine(resultf.ToDouble("F1"));
          Console.WriteLine($"Your Result is"+ resultf +"And You're Gay And Aproved");
      }

      else
      {
          Console.WriteLine("Your Too Much Gay");
      }
  }


  //Option Three
  void gret()
  {
      string name;
      string lastname;
      Console.WriteLine("Enter Your Name");
      name = (Console.ReadLine());
      Console.WriteLine("Enter Your LastName");
      lastname = (Console.ReadLine());
      string greet = (name + " " + lastname);
      Console.WriteLine("Hi,Como Estas?? {0}", greet);
  }

  //Option Fourth
  void operations()
  {
      int num1;
      int num2;

      dynamic Opt = ("+\n" +
                     "-\n" +
                     "*\n" +
                     "/\n");
      Console.WriteLine(Opt);
      Console.WriteLine("Choose");
      string beb = Console.ReadLine();
      switch (beb)
      {
          case "+":
          {
              Console.WriteLine("Choose The First Number");
              num1 = int.Parse(Console.ReadLine());
              Console.WriteLine("Choose The Second Number");
              num2 = int.Parse(Console.ReadLine());
              int matchsum = (num1 + num2);
              Console.WriteLine(matchsum);
              Console.WriteLine(Opt);

              break;
          }
          case "-":
          {
              Console.WriteLine("Choose The First Number");
              num1 = int.Parse(Console.ReadLine());
              Console.WriteLine("Choose The Second Number");
              num2 = int.Parse(Console.ReadLine());
              int matchrest = (num1 - num2);
              Console.WriteLine(matchrest);
              Console.WriteLine(Opt);

              break;
          }
          case "*":
          {
              Console.WriteLine("Choose The First Number");
              num1 = int.Parse(Console.ReadLine());
              Console.WriteLine("Choose The Second Number");
              num2 = int.Parse(Console.ReadLine());
              int matchmult = (num1 * num2);
              Console.WriteLine(matchmult);
              Console.WriteLine(Opt);

              break;
          }
          case "/":
          {
              Console.WriteLine("Choose The First Number");
              num1 = int.Parse(Console.ReadLine());
              Console.WriteLine("Choose The Second Number");
              num2 = int.Parse(Console.ReadLine());
              int matchdiv = (num1 / num2);
              Console.WriteLine(matchdiv);
              Console.WriteLine(Opt);

              break;
          }


          default:
          {
              Console.WriteLine("Chao Fish");
              break;
          }


      }
  }



  
  
  //Option Five
      void listt()
      {
          

          bool take = true;
          string Want =
          (
              "1.List \n" +
              "2.Add A 5 Numbers \n" +
              "3.The Total \n" +
              "4.Show The Highest Number \n" +
              "5.Show The Lowest Number "
          );
          while (take)
          { 
              

              Console.Clear();
          Console.WriteLine(Want);
          Console.WriteLine("          "+"What Do You Want??");
          string optimum = Console.ReadLine();
          Console.WriteLine(optimum);
          switch (optimum)
          {
              case "1":
              {
                  Console.WriteLine(numbers.Count());
                  foreach (int numbe in numbers)
                  {
                      Console.WriteLine($"Hey Bro If Don't You Look It -->{numbe}<-- Its Here");
                  }

                  Console.ReadLine();
                  break;

              }

              case "2":
              {
                  Console.WriteLine("Enter The First Number");
                  int number1 = int.Parse(Console.ReadLine());
                  numbers.Add(number1);
                  Console.WriteLine("Enter The Second Number");
                  int number2 = int.Parse(Console.ReadLine());
                  numbers.Add(number2);
                  Console.WriteLine("Enter The Third Number");
                  int number3 = int.Parse(Console.ReadLine());
                  numbers.Add(number3);
                  Console.WriteLine("Enter The Fourthy Number");
                  int number4 = int.Parse(Console.ReadLine());
                  numbers.Add(number4);
                  Console.WriteLine("Enter The Five Number");
                  int number5 = int.Parse(Console.ReadLine());
                  numbers.Add(number5);
                  Console.WriteLine(numbers.Count());
                  break;
              }

              case "3":
              {
                  take = true;
                  int sumTl = numbers.Sum();
                  Console.WriteLine($"AQUI ESTA {sumTl}");
                  break;
              }

              case "4":
              {
                  int mayo = 0;
                  foreach (int number in numbers)
                  {
                      if (number > mayo)
                      {
                          mayo = number;
                      }
                  }

                  Console.WriteLine(mayo);
                  break;
                  // int numberMax = number.Max(n => n.number);
              }

              case "5":
              {
                  int mayo = 0;
                  foreach (int number in numbers)
                  {
                      if (number < mayo)
                      {
                          mayo = number;
                      }
                  }

                  Console.WriteLine(mayo);
                  break;
              }

              default:
              {
                  Console.WriteLine("Choose A Valid Option");
                  Console.WriteLine(Want);
                  take = false;
                  break;
              }

          }


      }

          
          //Option Six
          //
          
  }
