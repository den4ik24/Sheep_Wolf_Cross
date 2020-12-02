using MvvmCross;
using MvvmCross.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Sheep_Wolf.Core.Logic;

namespace Sheep_Wolf.Core
{
    public class App: MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            //Mvx.IoCProvider.RegisterSingleton(() => UserDialogs.Instance);

            //RegisterNavigationServiceAppStart<BusinessLogic>();
            RegisterAppStart<BusinessLogic>();
        }
    }
}
