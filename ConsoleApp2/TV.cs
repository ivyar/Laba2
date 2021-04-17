using System;

namespace ConsoleApp2
{
    public class TV : IDevice
    {
        private int volume = 0;
        private int channal = 1;
        public int ChangeVolume(int i)
        {
            volume += i;
            if (volume >= 100) return volume = 100;
            else if (volume <= 0) return volume = 0;
            else return volume;
        }

        public double ChannalDown()
        {
            channal -= 1;
            if (channal <= 0) return channal = 0;
            else return channal;
        }

        public double ChannalUp()
        {
            channal += 1;
            return channal;
        }
    }
}
