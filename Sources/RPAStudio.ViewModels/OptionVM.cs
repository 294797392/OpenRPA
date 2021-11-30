using RPABase.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.MVVM;

namespace RPAStudio.ViewModels
{
    public class OptionVM : ViewModelBase
    {
        private object value;
        private OptionTypes type;
        private string key;

        /// <summary>
        /// 当前选项的值
        /// </summary>
        public object Value
        {
            get { return this.value; }
            set
            {
                this.value = value;
                this.NotifyPropertyChanged("Value");
            }
        }

        /// <summary>
        /// 当前选项的键
        /// </summary>
        public string Key 
        {
            get { return this.key; }
            set 
            {
                this.key = value;
                this.NotifyPropertyChanged("Key");
            }
        }

        /// <summary>
        /// 当前选项的类型
        /// </summary>
        public OptionTypes Type
        {
            get { return this.type; }
            set
            {
                this.type = value;
                this.NotifyPropertyChanged("Type");
            }
        }
    }
}
