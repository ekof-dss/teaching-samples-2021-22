using System.Text;

namespace DSS.PropertyBackingField
{
    internal class FictionCharacter
    {
        private string firstName;
        private string lastName;

        public FictionCharacter(string firstname = "XXX", string lastName = "XXX")
        {
            this.firstName = firstname;
            this.lastName = lastName;
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FullName
        {
            get { return firstName + " " + lastName; }
            set { 
                string[] sekvenca = value.Split(" ".ToCharArray());
                if( sekvenca.Length == 1){
                    firstName = "XXX";
                    lastName = sekvenca[0];
                }
                else if(sekvenca.Length == 2)
                {
                    firstName = sekvenca[0];
                    lastName = sekvenca[1];
                }
                else
                {
                    StringBuilder sb = new StringBuilder("");
                    for (int i = 0; i < sekvenca.Length-1; i++)
                        sb.Append(sekvenca[i] + " ");
                    firstName = sb.ToString().TrimEnd();
                    lastName = sekvenca[sekvenca.Length - 1];
                }
            }
        }

    }
}