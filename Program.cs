// See https://aka.ms/new-console-template for more information
﻿using System;
using Classes;
namespace Calc{
  
  class Program {
    public static void Main (string[] args) {
    Calculadora calc = new Calculadora();
    CalcSE calculadora = new CalcSE();


      Console.WriteLine(calculadora.subtrair(5,5));
      Console.WriteLine(calculadora.somar(5,5));
      Console.WriteLine(calculadora.multiplicar(5,5));
      Console.WriteLine(calculadora.divisao(5,5));

      Console.WriteLine(calc.subtrair(5,5));
      Console.WriteLine(calc.somar(10,5));
      Console.WriteLine(calc.multiplicar(5,2));
      Console.WriteLine(calc.divisao(10,5));
      
    }
  }
}