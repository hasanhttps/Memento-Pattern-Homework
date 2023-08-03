namespace Memento_Pattern_Homework;
using Memento_Pattern_Homework.models;



internal class Program {
    static void Main(string[] args) {
         MousePointerOriginator mousePointerOriginator = new();

        mousePointerOriginator.X = 1;
        mousePointerOriginator.Y = 1;
        mousePointerOriginator.isPressed = true;

        mousePointerOriginator.Save();


        mousePointerOriginator.X = 2;
        mousePointerOriginator.Y = 1;
        mousePointerOriginator.isPressed = false;

        mousePointerOriginator.Save();

        mousePointerOriginator.X = 3;
        mousePointerOriginator.Y = 1;
        mousePointerOriginator.isPressed = false;

        mousePointerOriginator.Save();


        mousePointerOriginator.Undo();
        Console.WriteLine(mousePointerOriginator.ToString());

        mousePointerOriginator.Undo();
        Console.WriteLine(mousePointerOriginator.ToString());

        mousePointerOriginator.Undo();
        Console.WriteLine(mousePointerOriginator.ToString());
    }
}