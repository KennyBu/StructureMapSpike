namespace Models
{
    public class PersonType
    {
        public static readonly PersonType Hero = new PersonType("HERO");
        public static readonly PersonType Villan = new PersonType("VILLAN");
        
        private readonly string _value;

        private PersonType(string value)
         {
             _value = value;
         }

        public override string ToString()
         {
             return _value;
         } 
    }
}