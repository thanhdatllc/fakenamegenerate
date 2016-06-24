using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Fake_Name_Generator
{
    public sealed partial class ThanhDatButtonSuccess : Button
    {
        private static readonly Color ButtonBackColor = ColorTranslator.FromHtml("#4caf50");
        private static readonly Color ButtonHoverColor = ColorTranslator.FromHtml("#66bb6a");

        public ThanhDatButtonSuccess()
        {
            InitializeSetupControl();
            InitializeComponent();
        }

        public ThanhDatButtonSuccess(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        private void InitializeSetupControl()
        {
            BackColor = ButtonBackColor;
            ForeColor = Color.White;
            FlatAppearance.MouseDownBackColor = ButtonHoverColor;
            FlatAppearance.MouseOverBackColor = ButtonHoverColor;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            TextImageRelation = TextImageRelation.ImageBeforeText;
        }
    }
}