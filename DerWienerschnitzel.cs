using System;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DerWienerschnitzel 
{
    public class BillSperm
    {
        public static void Welcome(string docName) 
        {
          // Create a Wordprocessing document. 
          using (WordprocessingDocument package = WordprocessingDocument.Create(docName, WordprocessingDocumentType.Document)) 
          {
            // Add a new main document part. 
            package.AddMainDocumentPart(); 

            // Create the Document DOM. 
            package.MainDocumentPart.Document = 
              new Document( 
                new Body( 
                  new Paragraph( 
                    new Run( 
                      new Text("Welcome to Der Weinerschnitzel"))))); 

            // Save changes to the main document part. 
            package.MainDocumentPart.Document.Save(); 
          } 
        }

        public static void Main(string[] args) 
        {
            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
                BillSperm.Welcome(args[0]) ;
            }
        }
    }
}

