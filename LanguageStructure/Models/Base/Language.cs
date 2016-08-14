using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageStructure.Models.Base
{
    internal class Language : DomainEntityBase
    {
        public Language(String nativeName, String code)
        {
            this.NativeName = nativeName;
            this.Code = code;
        }

        internal String NativeName { get; set; }
        internal String Code { get; set; }
    }
}
