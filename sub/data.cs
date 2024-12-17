using System;

namespace AutoVersion
{
    class data
    {
        private readonly int id;

        public data(int id)
        {
            this.id = id;
            Console.WriteLine($"id: {id}");
        }

        public data(string id)
        {
            this.id = int.TryParse(id, out this.id) ? this.id : 0;
            Console.WriteLine($"id: {id}");
        }

        ~data()
        {
            Console.WriteLine("destructor");
        }

        public void print()
        {
            Console.WriteLine($"id: {id}");
        }

        public int getId()
        {
            return id;
        }
    }
}
