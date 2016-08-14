using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageStructure.Models.Base
{
    /// <summary>
    /// Base class for domain entities.
    /// </summary>
    internal class DomainEntityBase
    {
        public DomainEntityBase()
        {
            this.Id = GenerateNewGuid();
        }

        private Guid GenerateNewGuid()
        {
            return Guid.NewGuid();
        }

        public DomainEntityBase(Guid id)
        {
            if (id != new Guid() && id != null)
                this.Id = id;
            else
                this.Id = GenerateNewGuid();                
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        internal Guid Id { get; set; }
    }
}
