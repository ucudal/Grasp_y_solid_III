//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    
            /*En vez de preguntar por el parametro de destino, imprimo directamente en consola y en archivo usando dos clases distintas
            Usa el patron polymorphism ya que antes preguntaba por el tipo y usaba logica condicional para decidir si imprimir
              en consola o en el archivo, en cambio ahora uso dos clases distintas conectas con la interface IPrinter */
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
        
    }
    public class FilePrinter : IPrinter
    {
        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
        
    }
}