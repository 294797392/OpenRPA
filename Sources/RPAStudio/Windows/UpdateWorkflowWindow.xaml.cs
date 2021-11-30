using RPAStudio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RPAStudio.Windows
{
    /// <summary>
    /// UpdateWorkflowWindow.xaml 的交互逻辑
    /// </summary>
    public partial class UpdateWorkflowWindow : Window
    {
        public UpdateWorkflowWindow(WorkflowVM vm)
        {
            InitializeComponent();

            this.InitializeWindow(vm);
        }

        private void InitializeWindow(WorkflowVM vm)
        {
            this.DataContext = vm;
        }
    }

    internal class OptionDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate DataTemplateText { get; set; }

        public DataTemplate DataTemplateSwitch { get; set; }

        public DataTemplate DataTemplateSelector { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            OptionVM ovm = item as OptionVM;
            if (ovm == null)
            {
                return base.SelectTemplate(item, container);
            }
            else
            {
                switch (ovm.Type)
                {
                    case RPABase.DataModels.OptionTypes.Text: return this.DataTemplateText;
                    case RPABase.DataModels.OptionTypes.Switches: return this.DataTemplateSwitch;
                    case RPABase.DataModels.OptionTypes.Selector: return this.DataTemplateSelector;
                    default:
                        return base.SelectTemplate(item, container);
                }
            }
        }
    }
}
