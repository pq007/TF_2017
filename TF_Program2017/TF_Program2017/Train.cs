using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TF_Program2017
{
    public class Train
    {
        public int roadFlag;//1--溜放进路；2-调车进路
        public float _speed = 1;//车走行的速度
        public float _length = 0;//车走行的距离
        public TrackCircuit temptc;//占据的是哪个轨道电路
        public float carLength;//车的长度
        public float carWeight;//车的重量
        float s;
        public Train(int flag)
        {
            roadFlag = flag;
        }
        public void CountSpeed()
        {
            Thread th = new Thread(get);
            th.Start();
        }
        public void get()
        {
            while (true)
            {
                Delays.Delay(100);
                s = _speed * 2;
                _length += s;
                Console.WriteLine(_length);
                
            }
        }
    }
}
