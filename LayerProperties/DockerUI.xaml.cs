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
        }

        // Functionality for the Refresh button
        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lbLayernames.Items.Clear();
                foreach (Layer l in cdrApplication.ActivePage.Layers)
                {
                    lbLayernames.Items.Add(l.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled exception: " + ex.Message);
            }
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbReverse_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void lbLayernames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void VisibilityOn(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Layer l in lbLayernames.Items)
                {
                    l.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled exception: " + ex.Message);
            }
        }

        private void VisibilityOff(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Layer l in lbLayernames.Items)
                {
                    l.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled exception: " + ex.Message);
            }
        }

        private void PrintingOn(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Layer l in lbLayernames.Items)
                {
                    l.Printable = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled exception: " + ex.Message);
            }
        }

        private void PrintingOff(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Layer l in lbLayernames.Items)
                {
                    l.Printable = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled exception: " + ex.Message);
            }
        }

        private void btnEditingOn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Layer l in lbLayernames.Items)
                {
                    l.Editable = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled exception: " + ex.Message);
            }
        }

        private void btnEditingOff_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Layer l in lbLayernames.Items)
                {
                    l.Editable = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled exception: " + ex.Message);
            }
        }

        private void AllOn(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Layer l in cdrApplication.ActivePage.Layers)
                {
                    l.Editable = true;
                    l.Printable = true;
                    l.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled exception: " + ex.Message);
            }
        }

        private void AllOff(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Layer l in cdrApplication.ActivePage.Layers)
                {
                    l.Editable = false;
                    l.Printable = false;
                    l.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled exception: " + ex.Message);
            }
        }

        private void GetActiveLayerName(object sender, RoutedEventArgs e)
        {

        }

    }
}