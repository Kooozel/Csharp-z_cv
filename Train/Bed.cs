namespace Train
{
    class Bed
    {
        int number;
        bool reserved;

        public Bed()
        {
                
        }
        public Bed(bool reserved)
        {
            this.reserved = reserved;
        }

        public int Number { get => number; set => number = value; }
        public bool Reserved { get => reserved; set => reserved = value; }
    }
}
