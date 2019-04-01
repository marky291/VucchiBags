using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucchiBags
{
    abstract class Entity
    {
        /**
         * The unique identifier for the entity
         * 
         * @var integer
         */
        protected int ID { get; set; }

        /**
         * Construct the entity
         */
        public Entity()
        {
            this.ID = this.GenerateIdentificationKey();
        }

        /**
         * Generate an unique ID for the entity.
         */
        protected virtual int GenerateIdentificationKey()
        {
            return Math.Abs(Guid.NewGuid().GetHashCode());
        }
    }
}
