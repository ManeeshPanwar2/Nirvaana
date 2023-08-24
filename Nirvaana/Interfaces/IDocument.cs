using Nirvaana.Enums;
using System.Collections.Generic;

namespace Nirvaana.Interfaces
{
    public interface IDocument
    {
        public List<int> UserDocuments(int userid);
        public bool UploadFile(string filename, string filepath, int filesize);
        public string DownloadFile(int documentId);
        public bool IsDocumentExpired(int documentId);
        public bool ChangeAccessLeve(int documentId, List<AccessLevel> accessLevels);
        public bool IsDocumentPublic(int documentId);
    }
}
