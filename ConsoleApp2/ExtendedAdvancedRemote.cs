namespace ConsoleApp2
{
    public class ExtendedAdvancedRemote : Remote
    {
        public ExtendedAdvancedRemote(IDevice device) : base(device)
        {
        }

        public int Mute()
        {
            return base._device.ChangeVolume(-100);
        }
    }
}
