using Components;
using System;

namespace nes_emu
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            SayHello(i++);
            SayHello(i++);
            SayHello(i++);
            SayHello(i++);
            SayHello(i++);
            SayHello(i++);
            SayHello(i++);

            Bus bus = new Bus();

            while(bus.Cpu.Cycles > 0 || Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                bus.Cpu.Clock();
            }
        }

        internal static void SayHello(int i)
        {
            Console.WriteLine($"Hello World! {i}");
        }
    }
}
