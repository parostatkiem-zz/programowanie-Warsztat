using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopManager
{
    public class Car
    {
        private bool isDone;
        private string brand;
        private string model;
        private string engine;
        private uint year;

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
            return base.Equals(obj);
        }

        //  public Car()
    }

    
}

