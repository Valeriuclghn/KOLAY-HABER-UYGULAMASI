﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RSS_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            XmlTextReader xmloku = new XmlTextReader("http://www.haberturk.com/rss");
            while(xmloku.Read()) 
            { 
                if(xmloku.Name== "title") 
                { 
                  listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            XmlTextReader xmloku = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");
            while (xmloku.Read()) 
            { 
                if(xmloku.Name== "title") 
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            XmlTextReader xmloku = new XmlTextReader("https://www.fotomac.com.tr/rss/anasayfa.xml");
            while(xmloku.Read()) 
            {
                if(xmloku.Name== "title") 
                {
                    listBox1.Items.Add(xmloku.ReadString());   
                }
            }
        }
    }
}
