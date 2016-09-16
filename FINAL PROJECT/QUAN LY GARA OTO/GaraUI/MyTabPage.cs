using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaraUI
{
	public class MyFormPage:Form
    {
        public Panel pnl;
    }
    public class MyTabPage: TabPage
    {
        private Form frm;
        public MyTabPage(MyFormPage frm_contensido)
        {
            this.frm = frm_contensido;
            this.Controls.Add(frm_contensido.pnl);
            this.Text = frm_contensido.Text;
        }
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                frm.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
