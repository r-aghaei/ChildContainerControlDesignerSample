

namespace ChildContainerControlDesignerSample
{
    using System.ComponentModel;
    using System.Windows.Forms;
    [Designer(typeof(MyUserControlDesigner))]
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
            TypeDescriptor.AddAttributes(this.contentsPanel,
                new DesignerAttribute(typeof(MyPanelDesigner)));
        }
        public string Title
        {
            get { return titleLabel.Text; }
            set { titleLabel.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentsPanel
        {
            get { return contentsPanel; }
        }
    }
}
