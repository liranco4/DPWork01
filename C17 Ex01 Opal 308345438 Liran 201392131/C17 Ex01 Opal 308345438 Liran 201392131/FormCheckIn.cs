using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C17_Ex01_Opal_308345438_Liran_201392131
{
    public partial class FormCheckIn : Form
    {
        private FacebookOperation FacebookOp { get; set; }

        public FormCheckIn(FacebookOperation i_FacebookOp)
        {
            InitializeComponent();
            FacebookOp = i_FacebookOp;
        }


    }
}
