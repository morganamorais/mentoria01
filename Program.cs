using System;

namespace mentoria_carrefour.Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
        
       
      Aluno aluno = new Aluno("Ana", 17, "ana@dio.me","Feminino", "3º ano", 9.5, 4.5);
      Aluno aluno2 = new Aluno("caio", 17, "caio@dio.me","masculino", "3º ano", 5.5, 4.5);
      
      Professor professor = new Professor("Jose", 53,"jose@dio.me", "Masculino", "Fisíca", 5.000);
       

        System.Console.WriteLine(aluno);
        aluno.mensagem();

        System.Console.WriteLine("--------------------------------------");

         
        System.Console.WriteLine(aluno2);
        aluno2.mensagem();

        System.Console.WriteLine("----------------------------------");

        System.Console.WriteLine(professor);

      

      


        }
        
    }
}
