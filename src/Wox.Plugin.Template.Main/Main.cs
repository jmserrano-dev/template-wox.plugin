using System.Collections.Generic;
using Wox.Plugin;

namespace Wox.Plugin.Template
{
    class Main : IPlugin
    {
        public List<Result> Query(Query query)
        {
            var result = new Result
            {
                Title = "Hello World from CSharp",
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
