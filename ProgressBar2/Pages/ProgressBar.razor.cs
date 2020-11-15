//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Timers;

//namespace ProgressBar2.Pages
//{
//    public partial class ProgressBar
//    {
//        //int expectedTime = 30000;
//        //int assignDuration = 5000;
//        //int loadDuration = 10000;
//        //int completeDuration = 150000;
//        //public DateTime count;

//        public int Second { get; set; }
//        public int Minute { get; set; }
//        public int Hour { get; set; }

//        public ProgressBar(int second, int? minute, int? hour)
//        {
//            this.Second = second;
//            this.Minute = (int)minute;
//            this.Hour = (int)hour;
//        }

//        public void Tick()
//        {

//            this.Minute++;
//            if (this.Second == 60)
//            {
//                this.Minute++;
//                this.Second = 00;
//            }

//            if (this.Minute == 60)
//            {
//                this.Hour++;
//                this.Minute = 00;
//            }

//        }

//        public string DisplayTime()
//        {
//            string time = this.Second.ToString("D2") + ":" + this.Minute.ToString("D2");
//            return time;

//        }


//        async void Time()
//        {
//            while (true)
//            {
//                Tick();

//                await Task.Delay(1000);
//            }
//        }

//        void ShowTime()
//        {
//            Console.WriteLine(DisplayTime());
//        }

//    }
//}
