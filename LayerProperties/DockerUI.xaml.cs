using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Corel.Interop.VGCore;

namespace LayerProperties
{

    public partial class DockerUI : UserControl
    {
        // Type definitions
        private Corel.Interop.VGCore.Application cdrApplication;

        private bool reverseSearch = false;

        public DockerUI(Corel.Interop.VGCore.Application application)
        {
            this.cdrApplication = application;
            InitializeComponent();

            foreach (Layer l in this.cdrApplication.ActivePage.Layers )
            {
                lbLayernames.Items.Add(l.Name);
            }
        }

    }
}
