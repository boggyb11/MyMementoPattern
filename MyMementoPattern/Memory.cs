
namespace MyMementoPattern
{
    //caretaker class
    public class Memory
    {
        private Memento _memento;

        public Memento Memento { get => _memento; set => _memento = value; }
    }
}
