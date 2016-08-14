using LanguageStructure.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Language> languages = new List<Language>();
            var languagePTBR = new Language("Português", "pt-BR");
            languages.Add(languagePTBR);
            var languageENUS = new Language("English", "en-US");
            languages.Add(languageENUS);

            List<ObjectType> objectTypes = new List<ObjectType>();
            var keyTitle = new ObjectType("Title");
            objectTypes.Add(keyTitle);
            var keyDescription = new ObjectType("Description");
            objectTypes.Add(keyDescription);
            
            List<LanguageData> languageDatas = new List<LanguageData>();

            var titleId = Guid.NewGuid();
            var title1 = new LanguageData("Título", keyTitle, titleId, languagePTBR);
            var title2 = new LanguageData("Title", keyTitle, titleId, languageENUS);

            var descriptionId = Guid.NewGuid();
            var description1 = new LanguageData("Descrição", keyDescription, descriptionId, languagePTBR);
            var description2 = new LanguageData("Description", keyDescription, descriptionId, languageENUS);
        }
    }
}
