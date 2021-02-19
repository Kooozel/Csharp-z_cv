namespace Train
{
    class Person
    {
        string firstName;
        string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

}
