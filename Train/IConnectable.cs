namespace Train
{
    interface IConnectable
    {
        void ConnectWagon(Train train);
        void DisconnectWagon(Train train);
    }
}
