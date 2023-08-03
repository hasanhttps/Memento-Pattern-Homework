using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern_Homework.models;

class MousePointerMemento {
    public int X { get; set; }
    public int Y { get; set; }
    public bool isPressed { get; set; }
}