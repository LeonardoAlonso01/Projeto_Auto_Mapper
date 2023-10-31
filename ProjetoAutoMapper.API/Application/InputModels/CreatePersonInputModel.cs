namespace ProjetoAutoMapper.API.Application.InputModels
{
    public class CreatePersonInputModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string? MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string CPF { get; private set; }

        public CreatePersonInputModel(int id, string name, string? middleName, string lastName, string cPF)
        {
            Id = id;
            Name = name;
            MiddleName = middleName;
            LastName = lastName;
            CPF = cPF;
        }
    }
}
