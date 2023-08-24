using Microsoft.AspNetCore.Mvc;
using Nirvaana.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Nirvaana.Controllers
{
    public class DocumentController
    {
        private IDocument document;
        //Example For Scoped Injection
        //private IDocument document1;


        public DocumentController(IDocument Document /*IDocument document1*/)
        {
            document = Document;
            //this.document1 = document1;
        }

        [HttpGet]
        public List<int> ViewDocuments(int userId)
        {
            return new List<int>();
        }

        [HttpPost]
        public ActionResult UploadDocument(string filename, string filepath, int filesize)
        {
            if (document.UploadFile(filename, filepath, filesize))
            {
                //Logic for successfull 
                return new JsonResult(new  {Output=true});
            }
            else
            {
                //login if upload Fails
                return new JsonResult(new { Output = false });
            }
        }

        [HttpGet]
        public ActionResult DownloadFile(int documentid)
        {
            return new JsonResult(new { FilePath = document.DownloadFile(documentid) });
        }
    }
}
