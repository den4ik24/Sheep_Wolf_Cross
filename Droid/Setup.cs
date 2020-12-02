using System;
using Android.App;
using Android.Runtime;
using Sheep_Wolf.Core;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.Platforms.Android.Core;

namespace Sheep_Wolf.Droid
{
    //public class Setup : MvxAppCompatSetup<App>
    //{
    //    //protected override IEnumerable<Assembly> AndroidViewAssemblies => new List<Assembly>(base.AndroidViewAssemblies)
    //    //{
    //    //    typeof(NavigationView).Assembly,
    //    //    typeof(CoordinatorLayout).Assembly,
    //    //    typeof(FloatingActionButton).Assembly,
    //    //    typeof(Toolbar).Assembly,
    //    //    typeof(DrawerLayout).Assembly,
    //    //    typeof(ViewPager).Assembly,
    //    //    typeof(MvxRecyclerView).Assembly,
    //    //    typeof(MvxSwipeRefreshLayout).Assembly,
    //    //};

    //    //protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
    //    //{
    //    //    MvxAppCompatSetupHelper.FillTargetFactories(registry);
    //    //    base.FillTargetFactories(registry);
    //    //    registry.RegisterFactory(new MvxCustomBindingFactory<SwipeRefreshLayout>("IsRefreshing", (swipeRefreshLayout) => new SwipeRefreshLayoutIsRefreshingTargetBinding(swipeRefreshLayout)));
    //    //}

    //    //protected override IMvxAndroidViewPresenter CreateViewPresenter()
    //    //{
    //    //    return new MvxAppCompatViewPresenter(AndroidViewAssemblies);
    //    //}
    //}

    
    [Application]
    public class MainApplication : MvxAndroidApplication<MvxAndroidSetup<App>, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}