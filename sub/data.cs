using System;

namespace AutoVersion
{
    class data
    {
        private int id; // id of data

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

        public int getId() // get id
        {
            return id;
        } 

        public void setId(int id) // set id
        {
            this.id = id;
        }

        public void print() // print id
        {
            Console.WriteLine($"id: {id}");
        }
    }
}
