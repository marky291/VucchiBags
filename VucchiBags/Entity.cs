﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucchiBags
{
    [Serializable]
    abstract class Entity
    {
        /**
         * The unique identifier for the entity
         * 
         * @var integer
         */
        public int Id { get; }

        /**
         * Construct the entity
         */
        public Entity()
        {
            this.Id = this.GenerateIdentificationKey();
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
