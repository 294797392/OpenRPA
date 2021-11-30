using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFToolkit.MVVM;

namespace RPAStudio.ViewModels
{
    public class ProjectVM : ItemViewModel
    {
        #region 实例变量

        private DateTime lastUpdateTime;
        private string uri;
        private string creator;
        private DateTime creationTime;

        #endregion

        #region 属性

        /// <summary>
        /// 最后一次更新时间
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this.lastUpdateTime; }
            set
            {
                this.lastUpdateTime = value;
                this.NotifyPropertyChanged("LastUpdateTime");
            }
        }

        /// <summary>
        /// 项目文件的地址
        /// </summary>
        public string URI
        {
            get { return this.uri; }
            set
            {
                this.uri = value;
                this.NotifyPropertyChanged("URI");
            }
        }

        public string Creator
        {
            get { return this.creator; }
            set
            {
                this.creator = value;
                this.NotifyPropertyChanged("Creator");
            }
        }

        public DateTime CreationTime
        {
            get { return this.creationTime; }
            set
            {
                this.creationTime = value;
                this.NotifyPropertyChanged("CreationTime");
            }
        }

        #endregion

        #region 构造方法

        public ProjectVM()
        {
        }

        #endregion
    }
}




