namespace ProjetoAutoMapper.API.Domain.Entities
{
    public class Person
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string? MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string CPF { get; private set; }

        public Person(int id, string name, string? middleName, string lastName, string cPF)
        {
            Id = id;
            Name = name;
            MiddleName = middleName;
            LastName = lastName;
            CPF = cPF;
        }
    }
}
