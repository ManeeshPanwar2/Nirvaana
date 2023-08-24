using Nirvaana.Enums;
using Nirvaana.Interfaces;
using System;
using System.Collections.Generic;

namespace Nirvaana.Models
{
    public class Document : IDocument
    {
        public int id { get; set; }
        public string DocumentName { get; set; }
        public List<string> tags { get; set; }
        public DateTime Exiprationtime { get; set; }
        public DateTime UploadDate { get; set; }
        public List<User> DownloadAccess { get; set; }
        public AccessLevel accessLevel { get; set; } = AccessLevel.PrivateOnly;

        public bool ChangeAccessLeve(int documentid, List<AccessLevel> accessLevels)
        {
            throw new System.NotImplementedException();
        }

        public string DownloadFile(int documentId)
        {
            throw new NotImplementedException();
        }

        public bool IsDocumentExpired(int doucmentid)
        {
            throw new System.NotImplementedException();
        }

        public bool IsDocumentPublic(int documentId)
        {
            throw new System.NotImplementedException();
        }

        public bool UploadFile(string filename, string filepath, int filesize)
        {
            throw new NotImplementedException();
        }

        public List<int> UserDocuments(int userid)
        {
            throw new System.NotImplementedException();
        }
    }
}
