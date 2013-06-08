namespace Models
{
    public class Villan : IPerson
    {
        private readonly Alignment _alignment;

        public Villan()
        {
            _alignment = Alignment.Evil;
        }
        
        public string Name { get; set; }

        public Alignment Alignment
        {
            get { return _alignment; }
        }

        public string Gloat()
        {
            return string.Format("I am a Villan and I am {0}!", _alignment);
        }
    }
}