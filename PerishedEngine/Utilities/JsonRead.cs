using LitJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerishedEngine.Utilities
{
    public class JsonRead
    {

        private string jsonString;
        private JsonData itemData;

        /// <summary>
        /// Reads the data from the file at the spcified path
        /// </summary>
        /// <param name="path">The path of the file to read</param>
        /// <returns>Return a JsonData</returns>
        public JsonData ReadData(string path)
        {
            jsonString = File.ReadAllText(path);
            itemData = JsonMapper.ToObject(jsonString);

            return itemData;
        }

    }
}
