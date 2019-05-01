using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CalculatorC
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Double res = 0;
        String status = "";
        String from = "";
        String to = "";
        double amount = 0.0;

        public Form1()
        {
            InitializeComponent();
            metroTabPage1.Text = "Calculator";
            metroTabPage2.Text = "Currency";
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)
            {
                case "btndel":
                    if(txtdisplay.Text.Length > 0)
                    {
                        txtdisplay.Text = txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1);
                                            }
                    break;
                case "btnc":
                    lblstatus.ResetText();
                    txtdisplay.ResetText();
                    this.txtdisplay.Focus();
                    break;
                case "btnce":
                    txtdisplay.ResetText();
                    this.txtdisplay.Focus();
                    break;
                case "btnneg":
                   if(txtdisplay.Text.Length > 0)
                    {
                        if (!txtdisplay.Text.Contains("-"))
                        {
                            txtdisplay.Text = "-" + txtdisplay.Text;
                        }
                        else if (txtdisplay.Text.Contains("-"))
                        {
                            txtdisplay.Text = txtdisplay.Text.Substring(1, txtdisplay.Text.Length - 1);
                            
                        }
                    }
                    break;
                case "btndot":
                    if (!txtdisplay.Text.Contains("."))
                    {
                        txtdisplay.Text += ".";
                    }
                    break;
                default:
                    txtdisplay.Text += btn.Text;                    
                    break;
            }
            
        }

        private void MathOperation(object sender, EventArgs e)
        {
            try { 
            Button btn = sender as Button;
            status = btn.Name;
            res = Double.Parse(txtdisplay.Text);
            txtdisplay.Text = "";
                switch (status)
                {
                    case "btnadd":
                        lblstatus.Text = System.Convert.ToString(res) + " + ";
                        this.txtdisplay.Focus();
                        break;
                    case "btnsub":
                        lblstatus.Text = System.Convert.ToString(res) + " - ";
                        this.txtdisplay.Focus();
                        break;
                    case "btnmul":
                        lblstatus.Text = System.Convert.ToString(res) + " * ";
                        this.txtdisplay.Focus();
                        break;
                    case "btndvd":
                        lblstatus.Text = System.Convert.ToString(res) + " / ";
                        this.txtdisplay.Focus();
                        break;
                    case "btnpow":
                        lblstatus.Text = System.Convert.ToString(res) + " ^ ";
                        this.txtdisplay.Focus();
                        break;
                }
                       
                }
                catch(System.FormatException ex)
            {
                
            }
        }

        private void Btnequal_Click(object sender, EventArgs e)
        {
            equal();            
        }
        private void Enter_Pressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                equal();
            }
        }
        private void equal()
        {
            try
            {
                lblstatus.Text = "";
                switch (status)
                {
                    case "btnadd":
                        txtdisplay.Text = (res + Double.Parse(txtdisplay.Text)).ToString();
                        break;
                    case "btnsub":
                        txtdisplay.Text = (res - Double.Parse(txtdisplay.Text)).ToString();
                        break;
                    case "btnmul":
                        txtdisplay.Text = (res * Double.Parse(txtdisplay.Text)).ToString();
                        break;
                    case "btndvd":
                        txtdisplay.Text = (res / Double.Parse(txtdisplay.Text)).ToString();
                        break;
                    case "btnpow":
                        txtdisplay.Text = (Math.Pow(res, Double.Parse(txtdisplay.Text))).ToString();
                        break;
                }
            }
            catch (System.FormatException ex)
            {

            }
        }
        private void btnAdvancedCalc(object sender, EventArgs e)
        {
            try {
                Button btn = sender as Button;
                switch (btn.Name)
                {
                    case "btnsqrt":
                        double sqrt = Double.Parse(txtdisplay.Text);
                        lblstatus.Text = System.Convert.ToString("sqrt" + "(" + (txtdisplay.Text) + ")");
                        sqrt = Math.Sqrt(sqrt);
                        txtdisplay.Text = System.Convert.ToString(sqrt);
                        break;
                    case "btn1x":

                        double onex = Convert.ToDouble(1.0 / Convert.ToDouble(txtdisplay.Text));
                        txtdisplay.Text = onex.ToString();
                        break;
                }
            }
            catch(System.FormatException ex)
            {

            }
            

        }
        public void FetchJson(String from, String to, double amount)
        {

            using (var WebClient = new WebClient())
            {
                string rowJson = WebClient.DownloadString("https://free.currconv.com/api/v7/convert?q=" + from + "_" + to + "&compact=ultra&apiKey=209cae74f9c42be852a6");
                var data = (JObject)JsonConvert.DeserializeObject(rowJson);
                string rate = data[from + "_" + to].Value<string>();
                String format = rate.Replace(".", ",");
                double total = double.Parse(format) * amount;
                txtres.Text = total.ToString();
            }
        }
        private void btnconvert_click(object sender, EventArgs e)
        {
            from = cbfrom.Text;
            to = cbto.Text;
            amount = double.Parse(txtamount.Text);
            FetchJson(from, to, amount);
        }

        private void Numpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txtdisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(ch == 46 && txtdisplay.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
            }
            if(!char.IsDigit(ch) && ch !=8 && ch != 46)
            {
                e.Handled = true;
            }
            
        }

       
    }
}
