using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TestProject.TaskLibrary.Tasks.Lesson13.Task1
{
    [DataContract]
    [Serializable]
    public class Car
    {
        [DataMember]
        public int CarId;

        [DataMember]
        public decimal Price;

        [DataMember]
        public int Quantity;

        [DataMember]
        public decimal Total;

        public Car()
        {

        }
    }
}
