using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;
using TestProject.Common.Core;
using TestProject.Common.Core.Interfaces;

namespace TestProject.TaskLibrary.Tasks.Lesson13.Task1
{
    public class Task : IRunnable
    {
        public void Run(IConsole console)
        {
            console.WriteLine("------------------Lesson13 Task1-----------------------");
            var cars = new List<Car>
            {
                new Car { CarId = 1, Price = 10000, Quantity = 4, Total = 40000 },
                new Car { CarId = 2, Price = 20000, Quantity = 1, Total = 20000 },
                new Car { CarId = 3, Price = 15000, Quantity = 2, Total = 30000 }
            };

            IMyFormatter myFormatter = new MyFormatter();

            using (FileStream fs = new FileStream("BinarySerializedData.txt", FileMode.Create))
            {
                myFormatter.Serialize(fs, cars);
                console.WriteLine("Binary serialization completed");
            }

            using (FileStream fs = new FileStream("BinarySerializedData.txt", FileMode.Open))
            {
                var data = (List<Car>)myFormatter.Deserialize(fs);
                console.WriteLine("Binary deserialization completed");
                foreach (var item in data)
                {
                    console.Write($"Car: {item.CarId}, {item.Price}, {item.Quantity}, {item.Total}\n");
                }
            }

            using (FileStream fs = new FileStream("XMLSerializedData.XML", FileMode.Create))
            {
                myFormatter.Serialize(fs, cars, typeof(List<Car>));
                console.WriteLine("XML serialization completed");
            }

            using (FileStream fs = new FileStream("XMLSerializedData.XML", FileMode.Open))
            {
                var data = (List<Car>)myFormatter.Deserialize(fs, typeof(List<Car>));
                console.WriteLine("XML deserialization completed");
                foreach (var item in data)
                {
                    console.Write($"Car: {item.CarId}, {item.Price}, {item.Quantity}, {item.Total}\n");
                }
            }

            using (FileStream fs = new FileStream("JSONSerializedData.json", FileMode.Create))
            {
                myFormatter.WriteObject(fs, cars, typeof(List<Car>));
                console.WriteLine("JSON serialization completed");
            }

            using (FileStream fs = new FileStream("JSONSerializedData.json", FileMode.Open))
            {
                var data = (List<Car>)myFormatter.ReadObject(fs, typeof(List<Car>));
                console.WriteLine("JSON deserialization completed");
                foreach (var item in data)
                {
                    console.Write($"Car: {item.CarId}, {item.Price}, {item.Quantity}, {item.Total}\n");
                }
            }

            console.WriteLine("------------------------------------------------------");
        }
    }
}