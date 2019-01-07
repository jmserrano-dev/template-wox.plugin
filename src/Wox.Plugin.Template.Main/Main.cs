using System.Collections.Generic;
using SimpleInjector;
using Wox.Plugin.Template.BusinessLogic;

namespace Wox.Plugin.Template
{
    class Main : IPlugin
    {
        private readonly Container container;

        public Main()
        {
            this.container = Injector
                .Create()
                .AddTransient<IHelloWorldService, HelloWorldService>()
                .Build();
        }

        public List<Result> Query(Query query)
        {
            var helloWorldService = this.container.GetInstance<IHelloWorldService>();

            var result = new Result
            {
                Title = $"{helloWorldService.GetMessage()} from CSharp v1.1",
                SubTitle = $"Query: {query.Search}",
                IcoPath = "app.png"
            };
            return new List<Result> {result};
        }

        public void Init(PluginInitContext context)
        {
            
        }
    }
}
