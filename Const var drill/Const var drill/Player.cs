using System;
using System.Collections.Generic;
using System.Text;

namespace Const_var_drill
{
    class Player
    {
        public int id;
        public string name;
        public Player() : this(0, "") { }
        public Player(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Player(int id) : this(id, "") { }
        public Player(string name) : this(0, name) { }
    }
}
