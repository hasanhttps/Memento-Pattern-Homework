using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern_Homework.models;

class MousePointerUndoCareTaker {

    private Stack<MousePointerMemento> _mementos;

    public MousePointerUndoCareTaker() {
        _mementos = new Stack<MousePointerMemento>();
    }

    public MousePointerMemento MousePointerMemento {
        get {
            return _mementos.Pop();
        }
        set {
            _mementos.Push(value);
        }
    }
}