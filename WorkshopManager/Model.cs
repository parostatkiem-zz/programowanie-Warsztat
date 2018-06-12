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
            if (Cars == null)
            {
                Cars = new List<Car>();
                throw new Exception("The file appears to be empty");
               
            }

        }

        public void SaveDataToFiles()
        {
            using (StreamWriter sw = new StreamWriter("data_cars.json"))
            {
                sw.Write(JsonConvert.SerializeObject(Cars));
            }
        }

        public void AddNewCar(Car c)
        {
            if (c == null) throw new Exception("Given car appears to be null") ;
            Cars.Add(c);
        }
    }
}
