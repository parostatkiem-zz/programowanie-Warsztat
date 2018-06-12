using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace WorkshopManager
{
    public class Car
    {
        private bool isDone = false;
        private string brand;
        private string model;
        private string engine;
        private uint year =1990;

        public List<CarProblem> problems;

        public bool IsDone{get;set; }
        public string Brand { get; set; }

        public string Model { get; set; }
        public string Engine { get; set; }
        public uint Year { get; set; }

        public uint ProblemAmount()
        {
            // return (uint)problems.Count;
            return 0;
        }
        public override bool Equals(object obj)
        {
            //if (obj == null) return false;
            var comparedCar = obj as Car;
            if (comparedCar == null) return false;
            if (IsDone != comparedCar.IsDone) return false;
            if (Brand != comparedCar.Brand) return false;
            if (Model != comparedCar.Model) return false;
            if (Engine != comparedCar.Engine) return false;
            if (Year != comparedCar.Year) return false;
            if (problems.Count != comparedCar.problems.Count) return false;
            if (problems.Count>0)
                for(int i=0; i<problems.Count;i++)
                {
                    if (!problems[i].Equals(comparedCar.problems[i])) return false;
                }
            return true;
        }

        public Car Clone()
        {
            Car output = new Car();
            output.problems = new List<CarProblem>();
            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {
                propertyInfo.SetValue(output, propertyInfo.GetValue(this, null),null);
            }
            if(problems.Count>0)
             output.problems.AddRange(problems);
            return output;
        }

        
          public Car()
        {
            IsDone = false;
            Brand = "";
            Model = "";
            Engine = "";
            Year = 1996;
            problems = new List<CarProblem>();
        }
    }

    
}

