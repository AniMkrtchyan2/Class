using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interface
{
    class Player : IPlaylabel, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("1 2 3 Start");
        }
        public void Pause() {
            Console.WriteLine("Pause");
        }
        public void Stop() {
            Console.WriteLine("Stop");
        }
        public void Record() {
            Console.WriteLine("Record is start");
        }
        void IRecordable.Pause() {
            Console.WriteLine("Record is Pause");
        }
        void IRecordable.Stop() {
            Console.WriteLine("Record is Stop");
        }

    }
}

