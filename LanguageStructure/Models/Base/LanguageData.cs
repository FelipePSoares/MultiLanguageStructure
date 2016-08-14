using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageStructure.Models.Base
{
    internal class LanguageData : DomainEntityBase
    {
        public LanguageData(String value, ObjectType objectType, Guid objectId, Language language)
        {
            this.ObjectType = objectType;
            this.ObjectId = objectId;
            this.Language = language;
            this.Value = value;
        }
        public Int32 RequestCount { get; set; }
        public String Value { get; set; }
        public Guid ObjectId { get; set; }
        public Language Language { get; set; }
        public ObjectType ObjectType { get; set; }
    }
}
