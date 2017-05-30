using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SpotOsu
{
    public partial class FormLinkable : Form
    {

        public FormLinkable(IEnumerable<IEnumerable<string>> labels)
        {
            InitializeComponent();
            foreach (var each in labels)
            {
                AddLabel(each.ToArray()[0], each.ToArray()[1]);
            }
            
        }
        private void FormLinkable_Load()
        {
        }

        public void AddLabel(string line, string link)
        {
            LinkLabel label = new LinkLabel( );
            label.Text = line;

            LinkLabel.Link _link = new LinkLabel.Link();
            _link.LinkData = link;
            label.Links.Add(_link);

            label.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel_LinkClicked);
            pnLabels.Controls.Add(label);
            label.Visible = true;
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start( e.Link.LinkData.ToString() );
        }


    }
}
