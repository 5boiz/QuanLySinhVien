using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy
{
    partial class Mock
    {
        public Root Data;

        public Mock()
        {
            Data = JsonConvert.DeserializeObject<Root>(File.ReadAllText("Data.json"));
        }

        public void XuatData()
        {
            string data = JsonConvert.SerializeObject(Data, Formatting.Indented);
            File.WriteAllText("DataText.json", data);

        }

    }
}
