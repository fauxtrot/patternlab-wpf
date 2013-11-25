using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using SimpleInjector;

namespace PatternLab_WPF.Shell
{
    public class AppBootStrapper : BootstrapperBase
    {
        public AppBootStrapper()
            :base(true)
        {
            
        }

        protected SimpleInjector.Container Container
        {
            get;
            set;
        }

        protected override void Configure()
        {
            this.Container = new Container();
        }

        protected override void OnExit(object sender, EventArgs e)
        {
            Container = null;
            base.OnExit(sender, e);
        }
    }
}
