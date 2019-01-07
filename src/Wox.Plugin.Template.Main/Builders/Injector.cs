namespace SimpleInjector
{
    class Injector
    {
        private static Container container = new Container();

        private Injector() { }

        public static Injector Create() => new Injector();

        public Injector AddTransient<TService, TImplementation>()
           where TService : class
           where TImplementation : class, TService
        {
            container.Register<TService, TImplementation>(Lifestyle.Transient);
            return this;
        }

        public Injector AddSingleton<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService
        {
            container.Register<TService, TImplementation>(Lifestyle.Singleton);
            return this;
        }

        public Injector AddScoped<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService
        {
            container.Register<TService, TImplementation>(Lifestyle.Scoped);
            return this;
        }

        public Container Build() {
            container.Verify();
            return container;
        }
    }
}
