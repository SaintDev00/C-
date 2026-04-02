
  string Options = "1.Suma Y Validación numérica \n" +
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

  
  while (stop)
  {
      Console.WriteLine("ingrese un valor");
      string selected = Console.ReadLine();


      switch (selected)
      {
          case "1":
              sumar();
              break;
          case "2":
              saludo();
              break;
          case "3":
              Console.Write("dfj");
              break;
          case "4":
              Console.Write("dfj");
              break;
          case "5":
              Console.Write("dfj");
              break;
          case "6":
              Console.Write("dfj");
              break;
          case "10":
              Console.Write("saliendo");
              stop = false;
              break;
          default:
              Console.Clear();
              Console.WriteLine($"Please Select A Valid OPtion \n" + Options);
              break;
      }
  }

  void sumar()
  {
      Console.WriteLine("hola");
      
  }
  
  void saludo()
  {
      Console.WriteLine("hola juan");
      
  }