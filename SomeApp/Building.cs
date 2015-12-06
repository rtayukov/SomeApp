using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeApp
{
    class Building: IEquatable<Building>
    {
        public int Floors;
        public int Area;
        public int Occupants;


        public override bool Equals(object obj)
        {
            return this.Equals(obj as Building);
        }

        public bool Equals(Building other)
        {
            if (Object.ReferenceEquals(this, null))
                return false;

            if (Object.ReferenceEquals(this, other))
                return true;

            return false;
            
        }
    }
}
