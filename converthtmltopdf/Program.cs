using System;
using System.IO;
using System.Runtime.CompilerServices;
using iText.Html2pdf;
using iText.Html2pdf.Css.Apply.Util;
using iText.Kernel.Pdf;
using iText.Layout.Font;
using iText.StyledXmlParser.Css.Resolve.Shorthand.Impl;
using Org.BouncyCastle.Utilities;

namespace ConvertHtmlToPdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string htmlContent = @"<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Ticket - 001-00002656</title>
     <style>
.ticket-header, 
.ticket-footer {
    background-color: #1f75c5; /* Ensuring same color */
    color: white;

}

html, body {
    height: 100%;
    
}
//.ticket-container {
//    min-height: 90vh; /* Takes 90% of viewport height */
//    display: flex;
//    flex-direction: column;
//    justify-content: space-between;
//}

       .ticket-footer {
    background: linear-gradient(to right, #5a98de, #8eb7f5);
    color: white;
    font-family: Arial, sans-serif;
    font-size: 12px;
    padding: 15px 20px;
}

//.footer-content {
//    display: flex;
//    justify-content: space-between;
//    align-items: flex-start;
//}

.footer-left {
    width: 60%;
}

.footer-right {
    width: 40%;
    text-align: right;
}

.footer-right table {
    width: 100%;
    border-collapse: collapse;
}

.footer-right td {
    padding: 3px 5px;
}

.footer-right .label {
    text-align: right;
    width: 20px;
}
.footer-right a {
    color: white;
    text-decoration: none;
}

.footer-right a:hover {
    text-decoration: underline; /* Optional hover effect */
}

        body {
            font-family: Arial, sans-serif;
            background-color: #ffffff;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            flex-direction: column;
        }
        .ticket-container {
            width: 700px;
            background-color: white;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 2px 2px 10px rgba(0, 0, 0, 0.1);
        }
        .ticket-header {
                       padding: 15px;
            font-size: 18px;
            font-weight: bold;
            border-top-left-radius: 10px;
            border-top-right-radius: 10px;
            display: flex;
            justify-content: space-between;
            align-items: center;
 min-height: 80px;
        }
        .ticket-header img {
            height: 30px;
        }
        .ticket-details {
            padding: 15px 0;
        }
        .ticket-details p {
            margin: 5px 0;
            font-size: 14px;
        }
        .ticket-details strong {
            font-weight: bold;
        }
               .ticket-footer {
                      padding: 15px;
            text-align: left;
            font-size: 12px;
            border-bottom-left-radius: 10px;
            border-bottom-right-radius: 10px;

        }
        .ticket-footer img {
            display: inline-block;
            vertical-align: middle;
            width: 100px; /* Adjust based on the footer logo */
            margin-right: 10px;
        }
        .footer-content {
            display: flex;
            align-items: center;
        }
        .footer-text {
            font-size: 12px;
            line-height: 1.5;
        }
        .footer-text strong {
            font-size: 14px;
        }

 table {
        width: 100%;
        border-collapse: collapse;
    }
    .label {
        text-align: left; /* Ensures the label is left-aligned */
        padding-right: 10px; /* Adds spacing between label and value */
        white-space: nowrap; /* Prevents labels from wrapping */
    }
    td {
        vertical-align: top; /* Aligns text to the top */
    }
    </style>
</head>
<body style=""height: auto; font-family: Calibri, sans-serif;"">

    <div class=""ticket-header""; style=""display: flex; align-items: center; justify-content: center;"">
    <div  style=""flex: 1; text-align: left;""><strong>
        Ticket - 001-00002656 - PLC / HMI Backups <br> In Progress</strong> 
    </div>
    <div text-align: right;"" >
        <img src=""C:\sanketlenovodats\icon&logos\logo.png"" alt=""Opensoft Logo"" style=""height: 50px;"">
    </div>
</div>

</div>
       
        <div class=""ticket-details"">
            <p><strong>Ticket Received:</strong> 09-08-2024</p>
            <p><strong>Ticket #:</strong> 001-00002656</p>
            <p><strong>Received By:</strong> Marc Bedford</p>
            <p><strong>Account:</strong> Viridor Beddington ERF</p>
            <p><strong>Client Contact:</strong> Joe Marper, Matthew Hopkins, Mitchell D Hurly</p>
            <p><strong>Subject:</strong> PLC / HMI Backups – To take additional backups inline with Support Contract</p>
            <p><strong>Ticket Category:</strong> Support Contract</p>
            <p><strong>Status:</strong> In Progress</p>
            <p><strong>Priority:</strong> Low</p>
            <p><strong>Required Date:</strong> 30-08-2024</p>
            <p><strong>DESCRIPTION:</strong> PLC / HMI Backups - To take additional backups in line with the Support Contract. 
                In line with the site's support contract to obtain additional backups undertaken under 
                project reference 6260. Michael will forward a list of the backups he has to identify 
                which further backups need obtaining.
 PLC / HMI Backups - To take additional backups in line with the Support Contract. 
                In line with the site's support contract to obtain additional backups undertaken under 
                project reference 6260. Michael will forward a list of the backups he has to identify 
                which further backups need obtaining.
 PLC / HMI Backups - To take additional backups in line with the Support Contract. 
                In line with the site's support contract to obtain additional backups undertaken under 
                project reference 6260. Michael will forward a list of the backups he has to identify 
                which further backups need obtaining.

            </p>
        </div>

         <div class=""ticket-footer"">
    <div class=""footer-content"">
        <div class=""footer-left"">
            <p><strong>Please contact us for further information:</strong></p>
            <p>Opensoft Systems Ltd.<br>
                Knaresborough Technology Park<br>
                Manse Lane<br>
                Knaresborough, HG5 8LF<br>
                North Yorkshire<br>
                United Kingdom
            </p>
        </div>
        <div class=""footer-right"">
            <table>
                <tr>
                    <td class=""label"" style=""padding-right: 9px;""><strong>t:</strong></td>
                    <td><a href=""tel:+441423642150"">+44 (0) 1423 642150</a></td>
                </tr>
                <tr>
     
                    <td class=""label"" style=""padding-right: 8px;""><strong>e:</strong></td>
                    <td><a href=""mailto:support@opensoftsystems.co.uk"">support@opensoftsystems.co.uk</a></td>
                </tr>
                <tr>
                    <td class=""label""><strong>  w:</strong></td>
                    <td><a href=""https://www.opensoftsystems.co.uk"">opensoftsystems.co.uk</a></td>
                </tr>
            </table>
        </div>
    </div>
</div>

    </div>

</body>
</html>";

            string outputPdfPath = @"C:\Users\sanke\OneDrive\Desktop\output.pdf";

            ConvertHtmlToPdf(htmlContent, outputPdfPath);

            Console.WriteLine("✅ PDF generated successfully: " + Path.GetFullPath(outputPdfPath));
        }

        static void ConvertHtmlToPdf(string html, string outputPath)
        {
            using (FileStream pdfStream = new FileStream(outputPath, FileMode.Create))
            {
                PdfWriter writer = new PdfWriter(pdfStream);
                PdfDocument pdf = new PdfDocument(writer);

                // ConverterProperties ensures auto page sizing
                ConverterProperties properties = new ConverterProperties();

                FontProvider fontProvider = new FontProvider();

                // Register Calibri Regular and Bold
                fontProvider.AddFont(@"C:\Windows\Fonts\calibri.ttf"); // Regular
                fontProvider.AddFont(@"C:\Windows\Fonts\calibrib.ttf"); // Bold

                properties.SetFontProvider(fontProvider);


                properties.SetBaseUri("file:///"); // Optional for local images

                // Convert HTML to PDF with auto page size
                HtmlConverter.ConvertToPdf(html, pdf, properties);

                pdf.Close();
            }
        }
    }
}
