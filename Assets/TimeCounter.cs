using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class TimeCounter
    {
        private float overallTime;
        private float startTime;
        private float firstLevelTime;
        private float secondLevelTime;
        private float thirdLevelTime;
        private float fourthLevelTime;
        private float fifthLevelTime;
        private float sixthLevelTime;

        public float StartTime { get => startTime; set => startTime = value; }
        public float FirstLevelTime { get => firstLevelTime; set => firstLevelTime = value; }
        public float SecondLevelTime { get => secondLevelTime; set => secondLevelTime = value; }
        public float ThirdLevelTime { get => thirdLevelTime; set => thirdLevelTime = value; }
        public float FourthLevelTime { get => fourthLevelTime; set => fourthLevelTime = value; }
        public float FifthLevelTime { get => fifthLevelTime; set => fifthLevelTime = value; }
        public float SixthLevelTime { get => sixthLevelTime; set => sixthLevelTime = value; }
        public float OverallTime { get => overallTime; set => overallTime = value; }
    }
}
