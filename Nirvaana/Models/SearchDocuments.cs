using Microsoft.AspNetCore.Mvc;
using Nirvaana.Interfaces;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Nirvaana.Models
{
    public class SearchDocuments : ISearchDocuments
    {
        private Document document;
        public SearchDocuments()
        {
            document = new Document();
        }

        [HttpGet]
        public List<int> CheckDocumentsByKeyWords(List<string> keyword)
        {
            throw new System.NotImplementedException();
        }

        [HttpGet]
        public List<int> checkDocumentsByTags(string tags)
        {
            throw new System.NotImplementedException();
        }

        [HttpGet]
        public List<int> CheckDocumnetByNames(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}
