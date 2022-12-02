using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers
{
    public class Person
    {
        public required string Name { get; init; }
        public required int Age { get; set; }

        [SetsRequiredMembers]
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} ({Age})";
        }
    }
}
