using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;
using TestProject.Common.Core.Interfaces;

namespace TestProject.Common.Core
{
    public class MyFormatter : IMyFormatter
    {
        public object Deserialize(Stream serializationStream)
        {
            BinaryFormatter bf = new BinaryFormatter();
            return (object)bf.Deserialize(serializationStream);
        }

        public object Deserialize(Stream serializationStream, Type type)
        {
            XmlSerializer xs = new XmlSerializer(type);
            return (object)xs.Deserialize(serializationStream);
        }

        public object ReadObject(Stream stream, Type type)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(type);
            return (object)js.ReadObject(stream);
        }

        public void Serialize(Stream serializationStream, object graph)
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(serializationStream, graph);
        }

        public void Serialize(Stream serializationStream, object graph, Type type)
        {
            XmlSerializer xs = new XmlSerializer(type);
            xs.Serialize(serializationStream, graph);
        }

        public void WriteObject(Stream stream, object graph, Type type)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(type);
            js.WriteObject(stream, graph);
        }
    }
}
