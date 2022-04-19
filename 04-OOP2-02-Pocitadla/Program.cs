using System;

namespace _04_OOP2_02_Pocitadla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Counter
    {
        public int Count { get; protected set; }
        public virtual void Next()
        {
            Count++;
        }
        public virtual void Reset()
        {
            Count = 0;
        }
    }
    class StepCounter : Counter
    {
        private int _step;

        public StepCounter(int step)
        {
            _step = step;
        }

        public override void Next()
        {
            Count += _step;
        }
    }
    class DownCounter : StepCounter
    {
        private int _initialValue;
        public DownCounter(int step, int initialValue) : base(-step)
        {
            _initialValue = initialValue;
            Reset();
        }
        public override void Reset()
        {
            Count = _initialValue;
        }
        //public bool IsFinished => Count <= 0;
        public bool IsFinished
        {
            get
            {
                return Count <= 0;
                //if (Count <= 0)
                //    return true;
                //else
                //    return false;
            }
        }

    }
}
