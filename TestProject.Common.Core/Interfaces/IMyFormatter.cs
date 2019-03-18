using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestProject.Common.Core.Interfaces
{
    public interface IMyFormatter
    {
        void Serialize(Stream serializationStream, object graph);

        void Serialize(Stream serializationStream, object graph, Type type);

        object Deserialize(Stream serializationStream);

        object Deserialize(Stream serializationStream, Type type);

        object ReadObject(Stream stream, Type type);

        void WriteObject(Stream stream, object graph, Type type);
    }
}
