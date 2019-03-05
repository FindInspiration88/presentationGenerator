using Microsoft.Office.Interop.PowerPoint;

namespace Generator.WebInteraction
{
    internal interface IPresentationProcessingService
    {
        void SavePresentationToJPG(Presentation present);
    }
}