namespace AutoVersion
{
    class data
    {
        private readonly int id;

        public data(int id)
        {
            this.id = id;
        }

        public data(string id)
        {
            this.id = int.TryParse(id, out this.id) ? this.id : 0;
        }
    }
}
