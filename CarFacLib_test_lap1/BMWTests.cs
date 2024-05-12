using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFacLib_test_lap1
{
    public class BMWTests
    {
        [Fact]
        public void IsStopped_velocity20_false()
        {
            BMW bmw = new BMW();
            bmw.velocity = 20;

            bool result = bmw.IsStopped();

            Assert.False(result);
        }

        [Fact]
        public void IncreaseVelocity_valocity20Add20_40()
        {
            BMW bmw = new BMW();
            bmw.velocity = 20;
            double AddedVelocitoy = 20;

            
            bmw.IncreaseVelocity(AddedVelocitoy);

            
            Assert.Equal(40, bmw.velocity);
            Assert.InRange(bmw.velocity, 20, 60); 
        }

        [Fact]
        public void GetDirection_DirectionStopped_Stopped()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Stopped;

            
            string result = bmw.GetDirection();

            
            Assert.Equal(DrivingMode.Stopped.ToString(), result);

            Assert.StartsWith("S", result);
            Assert.EndsWith("ed", result);

            Assert.Contains("pp", result);
            Assert.DoesNotContain("aaa", result);

            
        }
        [Fact]
        public void GetDirection_DirectionBackward_Backward()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Backward;


            string result = bmw.GetDirection();


            Assert.Equal(DrivingMode.Backward.ToString(), result);

            Assert.StartsWith("B", result);
            


        }

        [Fact]
        public void GetMyCar_callFunction_SameCar()
        {
            BMW bmw = new BMW();

            
            Car car = bmw.GetMyCar();

            
            Assert.Same(bmw, car); 
        }
    }
}
