namespace Models
{
    public class Alignment
    {
        public static readonly Alignment Good = new Alignment("Good");
        public static readonly Alignment Neutral = new Alignment("Neutral");
        public static readonly Alignment Evil = new Alignment("Evil");

        private readonly string _value;

        private Alignment(string value)
         {
             _value = value;
         }

        public override string ToString()
         {
             return _value;
         }
    }
}