namespace Exercicio9.Entities.Exceptions
{
    class DomainException : ApplicationException //Estou criando uma exceção. Ela deve herdar de ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
