using Nirvaana.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Nirvaana.Controllers
{
    public class SearchDocuments
    {
        private ISearchDocuments searchDocuments;
        public SearchDocuments(ISearchDocuments searchDocuments)
        {
            this.searchDocuments = searchDocuments;
        }

        public List<int> searchDocumentsByName(string documentName)
        {
            return searchDocuments.CheckDocumnetByNames(documentName);
        }

        public List<int> searchDocumentsByTags(string tags)
        {
            return searchDocuments.checkDocumentsByTags(tags);
        }

        public List<int> searchDocumentByKeyWords(string commaSepeartedKeyword)
        {
            return searchDocuments.CheckDocumentsByKeyWords(commaSepeartedKeyword.Split(',').ToList());
        }
    }
}
