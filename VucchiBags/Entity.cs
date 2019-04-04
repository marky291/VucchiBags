using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucchiBags
{
    [Serializable]
    abstract class Entity
    {
        public int Id { get; }

        public Entity()
        {
            this.Id = this.GenerateIdentificationKey();
        }

        protected virtual int GenerateIdentificationKey()
        {
            return Math.Abs(Guid.NewGuid().GetHashCode());
        }
    }
}
