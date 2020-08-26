using System;
using System.Diagnostics;
using System.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;

namespace Imagepdf
{
	class Program
	{
		static void Main(string[] args)
		{

                // Create a new PDF document
     PdfDocument doc = new PdfDocument();
            //Add a page to the document
            PdfPage page = doc.Pages.Add();
            //Get page size to draw image which fits the page
            SizeF pageSize = page.GetClientSize();
            //Create PDF graphics for the page
            PdfGraphics graphics = page.Graphics;
            //Load the image from the disk
            PdfBitmap image = new PdfBitmap("F:\visualbasic images.s1.jpg");
            //Draw the image
            graphics.DrawImage(image, new RectangleF(0, 0, pageSize.Width, pageSize.Height));
            //Save the document
            doc.Save("OutputImage.pdf");
            //Close the document
            doc.Close(true);
            //This will open the PDF file so, the result will be seen in default PDF viewer
            Process.Start("OutputImage.pdf");


        }
    }
}
