﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CipherAlgorithm;

namespace cipher_maker
{
    public partial class Encrypt : Form
    {
        CipherClass component = new CipherClass();

        public void cipherText(string plainText)
        {
            component.openShift = 3;
            component.openPlain = plainText;
           
            textBoxCiphered.Text = component.returnCipher();
        }

        public Encrypt() => InitializeComponent();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxText;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string plain = textBoxText.Text;       
            cipherText(plain);      
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxText.Clear();          
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
