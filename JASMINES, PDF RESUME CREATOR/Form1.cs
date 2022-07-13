using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq; 

namespace JASMINES__PDF_RESUME_CREATOR
{
    public partial class F1 : Form
    {
        private readonly string _fileName = @"E:\PROGRAMMING\JASMINES, PDF RESUME CREATOR\JASMINES, PDF RESUME CREATOR\Resume.json";
        public F1()
        {
            InitializeComponent();
        }

        public class RESUME
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Email { get; set; }   
            public string Phone { get; set; }   
            public string Website { get; set; } 
            public string Street1 { get; set; } 
            public string Street2 { get; set; } 
            public string Province { get; set; }    
            public string Municipality { get; set; }    
            public string PostalCode { get; set; }  
            public string Region { get; set; }  
            public string College { get; set; } 
            public string CollegeGraduated { get; set; }  
            public string HighSchool { get; set; }  
            public string HighSchoolGraduated { get; set; } 
            public string Elementary { get; set; }  
            public string ElementaryGraduated { get; set; } 
            public string Award { get; set; }   
            public string SoftwareSkill1 { get; set; }  
            public string SoftwareSkill2 { get; set; }  
            public string SoftwareSkill3 { get; set; }  
            public string HardwareSkill4 { get; set; }  
            public string SoftwareSkill5 { get; set; }  


        }

        private void F1_Load(object sender, EventArgs e)
        {

        }

        private void ButtGEN_Click(object sender, EventArgs e)
        {
            string jsonFile;
            using (var reader = new StreamReader(_fileName))
            {
                jsonFile = reader.ReadToEnd();  
            }
            var ResumeJson = JsonConvert.DeserializeObject<RESUME>(jsonFile);

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string Firstname = ResumeJson.Firstname;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            string Lastname = ResumeJson.Lastname;  
            string Email = ResumeJson.Email;    
            string Phone = ResumeJson.Phone;    
            string Website = ResumeJson.Website;    

            string Street1 = ResumeJson.Street1;        
            string Street2 = ResumeJson.Street2;        
            string Province = ResumeJson.Province;  
            string Municipality = ResumeJson.Municipality;
            string PostalCode = ResumeJson.PostalCode; 
            string Region = ResumeJson.Region;  

            string College = ResumeJson.College;    
            string CollegeGraduated = ResumeJson.CollegeGraduated;  
            string HighSchool = ResumeJson.HighSchool;
            string HighSchoolGraduated = ResumeJson.HighSchoolGraduated;  
            string Elementary = ResumeJson.Elementary;  
            string ElementaryGraduated = ResumeJson.ElementaryGraduated;

            string Award = ResumeJson.Award;    

            string SoftwareSkill1 = ResumeJson.SoftwareSkill1;  
            string SoftwareSkill2 = ResumeJson.SoftwareSkill2;  
            string SoftwareSkill3 = ResumeJson.SoftwareSkill3;  
            string HardwareSkill4 = ResumeJson.HardwareSkill4;
            string SoftwareSkill5 = ResumeJson.SoftwareSkill5;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"C:\Users\John Lloyd\Documents\Resume save";
                saveFileDialog.FileName = Lastname + " " + Firstname + ".pdf";
                saveFileDialog.Filter = "PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = Lastname + "_" + "Resume";
                    PdfPage page = pdf.AddPage();


                    XGraphics graph = XGraphics.FromPdfPage(page);

                    XFont bigfont = new XFont("Garet", 18, XFontStyle.Bold);
                    XFont smallfont = new XFont("Garet", 14, XFontStyle.Regular);
                    XFont titlefont = new XFont("Garet", 35, XFontStyle.Bold);

                    XPen pen = new XPen(XColors.Khaki);
                    XPen linerleft = new XPen(XColors.Gold); 
                    XPen linerright = new XPen(XColors.Gold);


                    graph.DrawRoundedRectangle(XBrushes.Linen, 0, 0, page.Width.Point, page.Height.Point, 30, 20);
                    graph.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);


                    graph.DrawString("JOHN LLOYD JASMINES", bigfont, XBrushes.Black, new XRect(0, 20, page.Width.Point - 20, page.Height.Point - 50), XStringFormats.TopRight);

                  
                    int marginleft = 25;
                    int initialleft = 200;
                    

                    string png = @"C:\Users\John Lloyd\Downloads\Jasmines Lloyd.png";
                    XImage image = XImage.FromFile(png);
                    graph.DrawImage(image, marginleft, 50, 150, 150);


                }
            }
            Application.Restart();
            Environment.Exit(0);
        }
    }
}