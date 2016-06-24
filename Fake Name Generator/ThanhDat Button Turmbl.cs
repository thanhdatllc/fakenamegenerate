using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Fake_Name_Generator
{
    public partial class ThanhDatButtonTurmbl : Button
    {
        private static readonly Color ButtonBackColor = ColorTranslator.FromHtml("#35465c");
        private static readonly Color ButtonHoverColor = ColorTranslator.FromHtml("#485f7c");

        public ThanhDatButtonTurmbl()
        {
            InitializeComponent();
            InitializeSetupControl();
        }

        public ThanhDatButtonTurmbl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public sealed override Color BackColor
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