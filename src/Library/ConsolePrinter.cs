using System;

namespace Full_GRASP_And_SOLID.Library
{   
    /*
    En base al patron Expert, esta clase seria la experta en 
    imprimir.
    Utilizando SRP, la clase tendria la responsabilidad de imprimir
    la receta.
    */
    public class ConsolePrinter
    {   
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetRecipeText());
        }
    }
}