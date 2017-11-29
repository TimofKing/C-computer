using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ans = 0, num = 0, Opn = 0 ,ans2=0,num2=0;
        Boolean Operation = false;
        private void button2_Click_1(object sender, EventArgs e)
        {
            Button bt;
            bt = (Button)(sender);
            string b = bt.Text;
            char c = Char.Parse(b);
            ans = ans + ans2;
            ans2 = 0;
            switch (c)
            {
                case '+':
                    Opn = 1;
                    Operation = true;
                    break;
                case '-':
                    Opn = 2;
                    Operation = true;
                    break;
                case '*':
                    Opn = 3;
                    Operation = true;
                    break;
                case '/':
                    Opn = 4;
                    Operation = true;
                    break;
                case 'C':
                    ans = 0;
                    num = 0;
                    break;
                case '=':                    
                    textBox1.Text = Convert.ToString(ans);
                    break;
            }
            textBox1.Text = Convert.ToString(ans);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Button bt;
            bt = (Button)(sender);
            int a = int.Parse(bt.Text);
            if (Operation == false)
            {
                num = a;
                ans = ans * 10 + num;
            }
            else if (Operation == true)
            {
                switch (Opn)
                {
                    case 1:
                        num2 = a;
                        ans2 = ans2 * 10 + num2;

                        break;
                    case 2:
                        num2 = a;
                        ans2 = ans2 * 10 - num2;

                        break;
                    case 3:
                        num2 = a;
                        ans2 = ans2 * 10 * num2;

                        break;
                    case 4:
                        num2 = a;
                        ans2 = ans2 * 10 / num2;

                        break;
                }
            }
            if (ans2 != 0)
            {
                textBox1.Text = Convert.ToString(ans2);
            }else
            {
                textBox1.Text = Convert.ToString(ans);
            }
           
        }

    }
}
