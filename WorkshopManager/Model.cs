using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WorkshopManager
{
    class Model
    {
        public  List<Car> Cars;
        public  List<Part> Parts;
        public void LoadDataFromFiles()
        {
            Cars = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText("data_cars.json"));
        }
    }
}
