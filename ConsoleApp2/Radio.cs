using System;

namespace ConsoleApp2
{
    public class Radio : IDevice
    {
        private int volume = 0;
        private double channal = 100;
        public int ChangeVolume(int i)
        {
            volume += i;
            if (volume >= 100) return volume = 100;
            else if (volume <= 0) return volume = 0;
            else return volume;
        }

        public double ChannalDown()
        {
            channal -= 0.6;
            if (channal <= 0) return channal = 0;
            else return channal;
        }

        public double ChannalUp()
        {
            channal += 0.6;
            return channal;
        }
    }
}
