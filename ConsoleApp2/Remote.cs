using System;

namespace ConsoleApp2
{
    public class Remote
    {
        protected IDevice _device;

        public Remote(IDevice device)
        {
            this._device = device;
        }

        public int ChangeVolume(int i)
        {
            return _device.ChangeVolume(i);
        }

        public double ChannalDown()
        {
            return _device.ChannalDown();
        }

        public double ChannalUp()
        {
            return _device.ChannalUp();
        }
    }
}
