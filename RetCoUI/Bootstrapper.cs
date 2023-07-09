using Caliburn.Micro;
using RetCoUI.ViewModels;
using RetCoUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RetCoUI
{
    public class Bootstrapper : BootstrapperBase
    {
        private SimpleContainer con = new SimpleContainer();
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            con.Instance(con);
            con.Singleton<IWindowManager,WindowManager>()
                .Singleton<IEventAggregator,EventAggregator>();

            con.PerRequest<ComputationBase, Computation>();

            GetType().Assembly.GetTypes().Where(type => type.IsClass)
                .Where(type => type.Name.EndsWith("ViewModel"))
                .ToList().ForEach(vmType => con.RegisterPerRequest(vmType,vmType.ToString(),vmType));
            {

            }

        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return con.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return con.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            con.BuildUp(instance);
        }
    }
}
