using System;

namespace MyMementoPattern
{
    class PlayerSave
    {
        private string _name;
        private int _level;
        private float _money;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Console.WriteLine($"Name: {_name}");
            }
        }

        public int Level
        {
            get => _level;
            set
            {
                _level = value;
                Console.WriteLine($"Level: {_level}");
            }
        }

        public float Money
        {
            get => _money;
            set
            {
                _money = value;
                Console.WriteLine($"Money: {_money}");
            }
        }

        public Memento SaveMemento()
        {
            Console.WriteLine("Saving memento ......");
            return new Memento(_name,_level,_money);
        }
        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("Restoring memento ......");
            this._level = memento.Level;
            this._money = memento.Money;
            this._name = memento.Name;

            Console.WriteLine(_level);
            Console.WriteLine(_money);
            Console.WriteLine(_name);
        }
    }
}
