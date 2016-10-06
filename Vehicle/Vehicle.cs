using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public string VehicleName { set; get; }
        public string RegistrationNo { set; get; }

        private double speed;

        private double totalSpeed ;
        public double Speed
        {
            set
            {
                speed = value;
                if (minSpeed < 1 && maxSpeed < 1)
                {
                    minSpeed = speed;
                    maxSpeed = speed;
                }
                else
                {
                    if (minSpeed > speed)
                    {
                        minSpeed = speed;
                    }
                    if (maxSpeed < speed)
                    {
                        maxSpeed = speed;
                    }
                }
                count++;
            }
            get
            {
                return speed;
                
            }
        }
        private double minSpeed;
        private double maxSpeed;
        private int count;

        //private double MinSpeed
        //{
        //    set
        //    {
        //        if (minSpeed > Speed)
        //        {
        //            minSpeed = speed;
        //        }
        //        else
        //        {
        //            minSpeed = speed;
        //        }
               
        //    }
        //    get
        //    {
        //        return minSpeed;
        //    }
        //}

        //private double MaxSpeed
        //{
        //    set
        //    {
        //        if (value < Speed)
        //        {
        //            maxSpeed = value;
        //        }
        //    }
        //    get
        //    {
        //        return maxSpeed;
        //    }
        //}

      

        public double GetMinimumSpeed()
        {
            return minSpeed;
        }

        public double GetMaximumSpeed()
        {
            return maxSpeed;
        }

        public double CountTotalSpeed()
        {
            return totalSpeed += speed;
        }
        public double GetAverageSpeed()
        {
           // double countSpeed= totalSpeed += speed;
            double result = CountTotalSpeed() / count;
           
             //   result = 0;
            
            return result;
        }
    }
}
