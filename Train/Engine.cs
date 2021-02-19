namespace Train
{
    class Engine
    {
        string type;

        public string Type { get => type; set => type = value; }

        
        public Engine(string type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return $"Engine type {type}";
        }
    }

}
