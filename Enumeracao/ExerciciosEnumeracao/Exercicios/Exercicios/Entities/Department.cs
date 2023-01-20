namespace Exercicios.Entities
{
    class Department //essa classe estará vinculada a classe worker.
    {
        public string Name { get; set; } // essa classe vai receber o nome do departamento.

        public Department() { }        
        public Department (string name)
        {
            Name = name;
        }
    }
}
