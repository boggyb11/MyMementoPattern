namespace MyMementoPattern
{
    public class Memento
    {
        private string _name;
        private int _level;
        private float _money;

        public Memento(string name, int level, float money)
        {
            Name = name;
            Level = level;
            Money = money;
        }

        public string Name { get => _name; set => _name = value; }
        public int Level { get => _level; set => _level = value; }
        public float Money { get => _money; set => _money = value; }
    }
}