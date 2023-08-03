using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Memento_Pattern_Homework.models;


class MousePointerOriginator {

    // Private Fields

    private MousePointerUndoCareTaker mousePointerCareTaker;

    // Properties

    public int X { get; set; }
    public int Y { get; set; }
    public bool isPressed { get; set; }

    // Constructor

    public MousePointerOriginator() {
        mousePointerCareTaker = new();
    }

    // Functions

    public void Save()  {
        mousePointerCareTaker.MousePointerMemento = new MousePointerMemento {
            X = this.X,
            Y = this.Y,
            isPressed = this.isPressed
        };
    }

    public void Undo() {
        MousePointerMemento previousTextMemento = mousePointerCareTaker.MousePointerMemento;

        X = previousTextMemento.X;
        Y = previousTextMemento.Y;
        isPressed = previousTextMemento.isPressed;
    }

    public override string ToString()
        => $"X: {X}, Y: {Y}, Pressed: {isPressed}";

}