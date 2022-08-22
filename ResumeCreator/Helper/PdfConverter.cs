using IronPdf;
using ResumeCreator.Models;


namespace ResumeCreator.Helper
{
    public class PdfConverter
    {
        public void CreateHtml(ViewModel viewModel)
        {                           
            var htmlToPdf = new HtmlToPdf(); // Instantiates Chrome Renderer
            var pdf = htmlToPdf.RenderHtmlAsPdf("<!DOCTYPE html><style>.photo{position: absolute; margin: 10px; right: 10px; top: 10px;}</style><html lang='en'><head> <meta charset='UTF - 8'> <meta http-equiv='X - UA - Compatible' content='IE = edge'> <meta name='viewport' content='width = device - width, initial - scale = 1.0'> <title>Document</title></head> <div class='personal'> <h2>" + viewModel.personalDetails.Name + "</h2> <p>" + viewModel.personalDetails.Address + "</p><P>" + viewModel.personalDetails.City + "</P> <P>" + viewModel.personalDetails.State + "</P> <P>" + viewModel.personalDetails.Country + "</P> <p>" + viewModel.personalDetails.ZipCode + "</p><p>" + viewModel.personalDetails.Email + "</p><p>" + viewModel.personalDetails.PhoneNumber + "</p></div><div class='photo'> <P>photo</P> </div><hr> <div class='summary'> <h2>summary</h2> A software develpor,have a 5+ experience </div><hr> <div class='experience'> <h2>Experience</h2> <p>" + viewModel.experienceDetails.Experience1 + "</p><p>" + viewModel.experienceDetails.Experience1 + "</p></div><hr> <div class='education'> <h2>Education</h2> <p>" + viewModel.educationDetails.Education1 + "</p><p>" + viewModel.educationDetails.Education1 + "</p></div><hr></body></html>");
            string path = "E:\\Sufiyan iqbal\\ResumeCreator\\ResumeCreator\\bin\\IronPdfTemp\\Dictionaries";
            pdf.SaveAs(path+"\\html_saved.pdf"); // Saves our PdfDocument object as a PDF

        }
    }
}