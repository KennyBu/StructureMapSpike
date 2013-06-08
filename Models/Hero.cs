namespace Models
{
    public class Hero : IPerson
    {
        private readonly Alignment _alignment;

        public Hero()
        {
            _alignment = Alignment.Good;
        }

        public string Name { get; set; }
        
        public Alignment Alignment
        {
            get { return _alignment; }
        }

        public string Gloat()
        {
            return string.Format("I am a Hero and I am {0}!", _alignment);
        }
    }
}