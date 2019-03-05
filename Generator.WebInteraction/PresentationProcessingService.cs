using Microsoft.Office.Interop.PowerPoint;
using System;
using System.IO;
using Generator.Database.Repositories.IRepository;

namespace Generator.WebInteraction
{
    class PresentationProcessingService : IPresentationProcessingService
    {
        private readonly IRecordPresentationRepository _recordPresentationRepository; 
        public PresentationProcessingService(IRecordPresentationRepository recordPresentationRepository)
        {
            _recordPresentationRepository = recordPresentationRepository;
        }

        public void SavePresentationToJPG(Presentation present)
        {
            var currentDirectory = Environment.CurrentDirectory;
            var currentDate = DateTime.Now.Date.ToString();
            var folderName = DateTime.Now.TimeOfDay.ToString();
            var targetPathDirectory = Path.Combine(currentDirectory, currentDate, folderName);

            present.SaveCopyAs(targetPathDirectory, PpSaveAsFileType.ppSaveAsJPG);

        }
    }
}
