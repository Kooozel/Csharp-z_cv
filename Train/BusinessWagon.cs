namespace Train
{
    class BusinessWagon : PersonalWagon
    {
        Person steward;
        public BusinessWagon(int numberOfChairs) : base(numberOfChairs)
        {

        }

        public BusinessWagon(int numberOfChairs,Person steward): base(numberOfChairs)
        {
            this.steward = steward;
        }

        internal Person Steward { get => steward; set => steward = value; }

        public override string ToString()
        {
            return $"Business wagon with {NumberOfChairs} sits, steward {steward}";
        }
    }
}
