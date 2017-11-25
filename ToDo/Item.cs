using System;
using System.Collections.Generic;

namespace ToDo
{
    public class Item
    {
        public bool cleared;
        public string name;
        public string description;
        public List<Item> items = new List<Item>();
        
        public Item(string name)
        {
            this.name = name;
        }
        public Item(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public Item(string name, bool cleared)
        {
            this.name = name;
            this.cleared = cleared;
        }
        public Item(string name, string description, bool cleared)
        {
            this.name = name;
            this.description = description;
            this.cleared = cleared;
        }
    }
}
