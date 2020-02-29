using System;
namespace exercise_121
{
    public class Fitbyte
    {
        private int age;
        private double restingHeartRate;
        private double maxHeartRate;
        public Fitbyte(int age, int restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
            maxHeartRate = (206.3 - (0.711*age));
        }
        private double percentageOfMaximum;
        public double TargetHeartRate(double percentageOfMaximum)
        {
            return (maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate;
        }
    }
}