using System.Collections.Generic;

namespace Nirvaana.Interfaces
{
    public interface ISearchDocuments
    {
        public List<int> CheckDocumnetByNames(string name);
        public List<int> checkDocumentsByTags(string tags);
        public List<int> CheckDocumentsByKeyWords(List<string> keyword);
    }
}
