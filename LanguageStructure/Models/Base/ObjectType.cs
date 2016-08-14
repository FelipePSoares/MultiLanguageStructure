using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageStructure.Models.Base
{
    internal class ObjectType : DomainEntityBase
    {
        public ObjectType(String key, Boolean system = false)
        {
            this.Key = key;
            this.System = system;
        }

        internal String Key { get; set; }
        internal Boolean System { get; set; }
    }
}
