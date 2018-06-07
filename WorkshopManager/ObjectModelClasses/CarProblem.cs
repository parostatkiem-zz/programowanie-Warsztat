using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopManager
{
    public class CarProblem
    {
        bool isFixed;
        string name;

        public string Name { get; set; }
        public bool IsFixed { get; set; }

        public CarProblem(string _name, bool _isFixed=false)
        {
            Name = _name;
            IsFixed = _isFixed;
        }
    }
}
