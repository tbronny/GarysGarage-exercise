using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Tesla modelS = new Tesla() {Name = "modelS", MainColor = "Rose Gold"};
            Cessna mx410 = new Cessna() {Name = "mx410", MainColor = "Yellow"};
            Ram rm1500 = new Ram() {Name = "rm1500", MainColor = "Black"};
            Zero fxs = new Zero() {Name = "fxs", MainColor = "Red"};

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            Console.WriteLine();
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            Console.WriteLine();
            rm1500.Drive();
            rm1500.Turn("up");
            rm1500.Stop();
            Console.WriteLine();
            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
        }
    }
}
