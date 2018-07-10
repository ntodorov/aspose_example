using System;
using System.IO;
using Aspose.Pdf;

namespace DrawingTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var doc = new Document();
            var page = doc.Pages.Add();

            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("Hello World!"));

            //int lowerLeftX = 40;
            //int lowerLeftY = 830;
            //int upperRightX = 120;
            //int upperRightY = 790;

            //var logoFile = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "logo.jpg");

            //FileStream imageStream = new FileStream(logoFile, FileMode.Open, FileAccess.Read);
            //page.Resources.Images.Add(imageStream);
            //page.Contents.Add(new Aspose.Pdf.Operators.GSave());
            //Aspose.Pdf.Rectangle rectangle = new Aspose.Pdf.Rectangle(lowerLeftX, lowerLeftY, upperRightX, upperRightY);
            //Aspose.Pdf.Matrix matrix = new Aspose.Pdf.Matrix(new double[] { rectangle.URX - rectangle.LLX, 0, 0, rectangle.URY - rectangle.LLY, rectangle.LLX, rectangle.LLY });
            //page.Contents.Add(new Aspose.Pdf.Operators.ConcatenateMatrix(matrix));
            //XImage ximage = page.Resources.Images[page.Resources.Images.Count];
            //page.Contents.Add(new Aspose.Pdf.Operators.Do(ximage.Name));
            //page.Contents.Add(new Aspose.Pdf.Operators.GRestore());


            var pdfFile = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "new.pdf");


            doc.Save(pdfFile);


            Console.WriteLine("all done..");


        }
    }
}
