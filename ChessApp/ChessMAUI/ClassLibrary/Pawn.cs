using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Pawn
    {
        private Type type;

        private Color color;

        public Type Type { get { return type; } }

        public Pawn(Type t)
        {
            type = t;
        }
    }
}
