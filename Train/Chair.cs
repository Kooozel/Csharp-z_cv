namespace Train
{
    class Chair
    {
        int number;
        bool reserved;
        bool nearWindow;

        public Chair()
        {
            reserved = false;
        }
        public Chair(int number, bool reserved, bool nearWindow)
        {
            this.number = number;
            this.reserved = reserved;
            this.nearWindow = nearWindow;
            this.reserved = false;
        }

        public int Number { get => number; set => number = value; }
        public bool Reserved { get => reserved; set => reserved = value; }
        public bool NearWindow { get => nearWindow; set => nearWindow = value; }
    }

}
