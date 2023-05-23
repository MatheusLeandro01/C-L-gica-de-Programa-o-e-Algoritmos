using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[3];

            try
            {
                /*for (var i = 0; i <= 4; i++) //forçando um erro
                {
                    //System.IndexOutOfRangeException
                    Console.WriteLine(arr[i]);
                }*/
                Cadastrar("");
            }
            catch(IndexOutOfRangeException e) // os erros devem ser tratados do mais específico ao mais genérico
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Não encontrei o índice na lista");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Falha ao cadastrar texto");
            }
            catch (MinhaException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.QuantoAconteceu);
                Console.WriteLine("Exceção customizada");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Ops, algo deu errado");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }
        }
        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new MinhaException(DateTime.Now);            
        }
        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuantoAconteceu = date;
            }
            public DateTime QuantoAconteceu { get; set; }
        }
    }
}