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
            public string Award { get; set; }   
            public string Skill1 { get; set; }  
            public string Skill2 { get; set; }  
            public string Skill3 { get; set; }  
            public string Skill4 { get; set; }  
            public string Skill5 { get; set; }  


        }

        private void F1_Load(object sender, EventArgs e)
        {

        }

        private void ButtGEN_Click(object sender, EventArgs e)
        {
                  
        }
    }
}