using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvxAppWithUITests.Core.ViewModels.Home;

namespace MvxAppWithUITests.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
