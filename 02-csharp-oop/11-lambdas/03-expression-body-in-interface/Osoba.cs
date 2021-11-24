namespace RS2.LambdaExpressionInInterface
{
    public class Osoba
    {
        private string firstName;
        private string lastName;
    
        public Osoba(string first, string last)
        {
            this.firstName = first;
            this.lastName = last;
        }

        public string Name => $"{firstName} {lastName}";

    }
}