using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerSave playerSave = new PlayerSave();
            playerSave.Name = "Ben";
            playerSave.Level = 5;
            playerSave.Money = 50000f;

            Memory memory = new Memory();
            memory.Memento = playerSave.SaveMemento();


            playerSave.Name = "James";
            playerSave.Money = 2550f;
            playerSave.Level = 2;


            playerSave.RestoreMemento(memory.Memento);

            Console.ReadKey();
        }
    }
}
