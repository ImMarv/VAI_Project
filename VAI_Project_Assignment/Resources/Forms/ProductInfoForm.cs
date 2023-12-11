using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace VAI_Project_Assignment
{
    public partial class ProductInfoForm : Form
    {
        string PDFButtonData = "";
        public ProductInfoForm(string softwareType, string description, string businessAreas, string modules, string clientTypes, string cloud, string additionalInfo)
        {
            InitializeComponent();

            txtSoftwareType.Text = softwareType;
            txtDescription.Text = description;
            txtBusinessArea.Text = businessAreas;
            txtModule.Text = modules;
            txtClientType.Text = clientTypes;
            txtCloud.Text = cloud;
            txtAdditionalInfo.Text = additionalInfo;
            // Similar to what I did with the notifications but once again it seems like it would be completely fine in practise.
            PDFButtonData = $"{txtSoftwareType}\n {txtDescription}\n {txtBusinessArea}\n {txtModule}\n {txtClientType}\n {txtCloud}\n {txtAdditionalInfo}";

        }

        // this is kind of a silly way to handle the PDFs but it does the job.
        // it essentially puts all the details as is onto a PDF for anyone to view on the button click
        public void PDFButton_Click(object sender, EventArgs e)
        {
            // Retrieves the string of variables from above
            string inputString = PDFButtonData;

            // Specifies the output PDF file path
            string outputPath = "output.pdf";

            // Creates a PdfWriter object to write to file
            using (PdfWriter writer = new PdfWriter(outputPath))
            {
                // Create a PdfDocument
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    // Adds document elements to the PDF
                    Document document = new Document(pdf);

                    // Add the string content to the PDF
                    document.Add(new Paragraph(inputString));
                }
            }

            Console.WriteLine($"PDF created at: {Path.GetFullPath(outputPath)}");

            // Open the generated PDF in the default web browser
            OpenPdfInBrowser(outputPath);
        }

        public void OpenPdfInBrowser(string pdfPath)
        {
            try
            {
                // Check if the file exists before attempting to open it
                if (File.Exists(pdfPath))
                {
                    // Use the default web browser to open the PDF file
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = pdfPath,
                        UseShellExecute = true
                    });
                }
                else
                {
                    Console.WriteLine("PDF file not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening PDF: {ex.Message}");
            }
        }
    }
}
