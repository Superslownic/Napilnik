namespace NapilnikTask2
{
    public struct Product //В задании обозначается как Good, но так не говорят
    {
        public Product(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
