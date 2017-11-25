using System;

namespace ToDo
{
    public class Item
    {
        bool cleared;
        string text;

        public Item()
        {
        }
        public Item(string t)
        {
            text = t;
        }
    }
}
