using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fifteensWinForm
{
    public delegate void CheckInput();
    public delegate void OkButton(string text, object sender, EventArgs e);
    public delegate void CancelButton(object sender, EventArgs e);
    
    public sealed partial class AskForm : Form
    {
        private readonly OkButton ok;
        private readonly CancelButton cancel;
       
        public AskForm(string ask, OkButton onOk, CancelButton onCancel)
        {
            InitializeComponent();
            this.Width = 585;
            this.Height = 400;

            ok = onOk;
            cancel = onCancel;
            Ask.Text = ask;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            ok(Input.Text, sender, e);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            cancel(sender, e);
        }
    }
}
