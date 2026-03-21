using KombatFighters.Models;
using Microsoft.JSInterop;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace KombatFighters.Services
{
    public class PdfExportService
    {
        private readonly IJSRuntime _js;
        public PdfExportService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task ExporterDeckEnPdf(List<CarteInfo> cartesAExporter)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var document = Document.Create(container => { /* ... Votre logique QuestPDF ici ... */ });

            byte[] pdfBytes = document.GeneratePdf();
            string base64 = Convert.ToBase64String(pdfBytes);

            await _js.InvokeVoidAsync("telechargerFichier", "MonDeck.pdf", base64);
        }
    }
}