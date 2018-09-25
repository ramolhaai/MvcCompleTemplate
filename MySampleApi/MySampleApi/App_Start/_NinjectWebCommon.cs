//using System;
//using System.Web;
//using System.Web.Http;
//using Microsoft.Web.Infrastructure.DynamicModuleHelper;
//using Ninject;
//using Ninject.Web.Common;
//using Ninject.Web.Common.WebHost;
//using MySampleApi.Business;
//using Ninject.Extensions.Conventions;
//using webApiSample.App_Start;
//using Ninject.WebApi.DependencyResolver;
////using DALNorthwind;


//[assembly: WebActivator.PreApplicationStartMethod(typeof(NinjectWebCommon), "Start")]
//[assembly: WebActivator.ApplicationShutdownMethodAttribute(typeof(NinjectWebCommon), "Stop")]

//namespace webApiSample.App_Start
//{
//    public static class NinjectWebCommon
//    {
//        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

//        /// <summary>
//        /// Starts the application
//        /// </summary>
//        public static void Start()
//        {
//            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
//            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
//            bootstrapper.Initialize(CreateKernel);
//        }

//        /// <summary>
//        /// Stops the application.
//        /// </summary>
//        public static void Stop()
//        {
//            bootstrapper.ShutDown();
//        }

//        /// <summary>
//        /// Creates the kernel that will manage your application.
//        /// </summary>
//        /// <returns>The created kernel.</returns>
//        private static IKernel CreateKernel()
//        {
//            var kernel = new StandardKernel();
//            try
//            {
//                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
//                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

//                RegisterServices(kernel);
//                GlobalConfiguration.Configuration.DependencyResolver = new NinjectDependencyResolver(kernel);

//                return kernel;
//            }
//            catch
//            {
//                kernel.Dispose();
//                throw;
//            }
//        }

//        /// <summary>
//        /// Load your modules or register your services here!
//        /// </summary>
//        /// <param name="kernel">The kernel.</param>
//        private static void RegisterServices(IKernel kernel)
//        {
//            kernel.Bind<ICaclulator>().To<Caclulator>();
//            //kernel.Bind(x => x
//            //   .FromAssembliesMatching("DALNorthwind.dll")
//            //   .SelectAllClasses()
//            //   .BindDefaultInterface());

//            // kernel.Bind<northwindEntities>().To<northwindEntities>().InScope(context => HttpContext.Current);
//        }
//    }
//}

