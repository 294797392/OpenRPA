using RPAStudio.ViewModels;
using RPAStudio.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace RPAStudio.UserControls
{
    /// <summary>
    /// WorkflowListUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class WorkflowListUserControl : UserControl
    {
        public WorkflowListUserControl()
        {
            InitializeComponent();
        }   

        private void ListBoxWorkflows_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            WorkflowVM selectedVM = ListBoxWorkflows.SelectedItem as WorkflowVM;
            if (selectedVM == null)
            {
                return;
            }

            UpdateWorkflowWindow window = new UpdateWorkflowWindow(selectedVM);
            window.Owner = Application.Current.MainWindow;
            if ((bool)window.ShowDialog())
            {
            }
        }
    }
}



