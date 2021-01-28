using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RummyConsole.Functions
{
    public static class TotalClone
    {
        public static T Clone<T>(this T item)
        {
            var formatter = new BinaryFormatter();
            var stream = new MemoryStream();
            formatter.Serialize(stream, item);
            stream.Seek(0, SeekOrigin.Begin);
            var result = (T)formatter.Deserialize(stream);
            stream.Close();
            return result;
        }
    }
}
