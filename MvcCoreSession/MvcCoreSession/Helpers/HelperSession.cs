using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace MvcCoreSession.Helpers
{
    public class HelperSession
    {
        //Tendremos dos metodos static
        public static byte[] ObjectToByte(Object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms=new MemoryStream())
            {
                formatter.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public static Object ByteToObject(byte[] datos)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream ms=new MemoryStream())
            {
                ms.Write(datos, 0, datos.Length);
                ms.Seek(0, SeekOrigin.Begin);
                Object obj = (Object)formatter.Deserialize(ms);
                return obj;
            }
        }

        //Metodo para recibir un objeto y devolver el string serializado
        public static string SerializeObject(object objeto)
        {
            string data = JsonConvert.SerializeObject(objeto);
            return data;
        }

        //METODO QUE RECIBIRA EL JSON Y DEVLVEMOS EL OBJETO
        //QUE LO REPRESENTA DESERIALIZADO
        public static T DeserializeObject<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
