using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ProManage
{
    public static class Serializer
    {
        private static byte[] Serialize(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            formatter.Serialize(memoryStream, obj);
            return memoryStream.ToArray();
        }

        private static Object DeSerialize(byte[] barr)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();
            memoryStream.Write(barr, 0, barr.Length);
            memoryStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)formatter.Deserialize(memoryStream);
            return obj;
        }
    }
}
