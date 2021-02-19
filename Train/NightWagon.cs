namespace Train
{
    class NightWagon : PersonalWagon
    {
        Bed[] beds;
        int numberOfBeds;

        public int NumberOfBeds { get => numberOfBeds; set => numberOfBeds = value; }
        internal Bed[] Beds { get => beds; set => beds = value; }

        public NightWagon(int numberOfChairs,int numberOfBeds) : base(numberOfChairs)
        {
            this.numberOfBeds = numberOfBeds;
        }

        public override string ToString()
        {
            return $"Night wagon with {NumberOfChairs} sits and {NumberOfBeds} beds";
        }
    }
}
