using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqueezePageWizard
{
    public partial class Form1 : Form
    {
        string xfontcolor = "#F50018";
        string xHilight = "#ffff00";
        string xfont = "\"Times New Roman\", Times, serif";
        string xbgcolor = "lightblue";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            panel2.Visible = true;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string LayoutSelect = comboBox1.SelectedIndex.ToString();
            switch (LayoutSelect)
            {
                case "0":
                    pictureBox1.Image = (SqueezePageWizard.Properties.Resources.layout);
                    xfontcolor = "#F50018";
                    xHilight = "#ffff00";
                    xfont = "\"Times New Roman\", Times, serif";
                    xbgcolor = "lightblue";
                    break;
                case "1":
                    pictureBox1.Image = (SqueezePageWizard.Properties.Resources.layout2);
                    xfontcolor = "#771791";
                    xHilight = "#64F5A3";
                    xfont = "Arial, Helvetica, sans-serif";
                    xbgcolor = "#E2C1F5";
                    break;
                default:
                    pictureBox1.Image = (SqueezePageWizard.Properties.Resources.layout3);
                    xfontcolor = "#316E44";
                    xHilight = "#F5649E";
                    xfont = "Impact, Charcoal, sans-serif";
                    xbgcolor = "#C3F24B";
                    break;

            }

 }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string comcode =
                "<!Doctype html>\r\n" +
                "<html>\r\n" +
                "<head>\r\n" +
                "<title>" + ttlBox.Text + "</title>\r\n" +
                "<meta name=\"keywords\" content=\"" + textBox3.Text + "\">" +
                "<meta name=\"description\" content=\"" + deBox.Text+"\">" +
                "</head>\r\n" +
                "<body>\r\n" +

                "<div style=\"width: 700px ; margin-left: auto ;margin-right: auto ; text-align: center; background-color:" + xbgcolor + ";word-wrap: break-word;\">" +
                "<H1>" + "<SPAN style=\"background-color:" + xHilight + ";font-family:" + xfont + "\">" + "<font color =\"" + xfontcolor + "\">" + ttlBox.Text + "</font>" + "</span>" + "</H1>\r\n" +
                
                //super catchy statment what you avoid
                "<H2><i>" + "<SPAN style=\"background-color:" + xHilight + ";font-family:" + xfont + "\">" + "<font color =\"" + xfontcolor + "\">" + cp1.Text + "  " + "</font>" + "</span>" + "</i><H2>" +
                "<p style=\"padding-left: 20px; magin-left:30px; margin-right:30px\">" + conBox.Text + "</p>\r\n" +
                "<p style=\"magin-left:30px; margin-right:30px\">" + "<img src=\" C:\\Users\\crystal\\documents\\visual studio 2010\\Projects\\LPGen\\LPGen\\Resources\\checkimage.png\">" + benBox1.Text + "<br>" + benBox2.Text + "<br>" + benBox3.Text + "<br>" + benBox4.Text + "</p>\r\n" +
                //super catch statment 2 what you get
                "<H2><i>" + "<SPAN style=\"background-color:" + xHilight + ";font-family:" + xfont + "\">" + "<font color =\"" + xfontcolor + "\">" + cp2.Text + "  " + "</font>" + "</span>" + "</i><H2>" +
                "<p style=\"magin-left:30px; margin-right:30px\">" + benBox21.Text + "<br>" + benBox22.Text + "<br>" + benBox23.Text + "<br>" + benBox24.Text + "<br>" + benBox25.Text + "</p>\r\n" +
                // Need Sales pitch statement
                "</body>" + "</html>"

                ;
            codeBox.Text = comcode;
            System.IO.File.WriteAllText(@"C:\Users\crystal\Documents\Visual Studio 2010\Projects\SqueezePageWizard\SqueezePageWizard\Resources\index.html", comcode);
            this.webBrowser1.Navigate(@"C:\Users\crystal\Documents\Visual Studio 2010\Projects\SqueezePageWizard\SqueezePageWizard\Resources\index.html");

        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        

        
    }
}
