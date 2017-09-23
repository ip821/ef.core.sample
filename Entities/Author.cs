namespace sample1.Entities
{
    public class Author
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string SecondName { get; private set; }

        private Author() { }
        public Author(string name) => Name = name;
    }
}