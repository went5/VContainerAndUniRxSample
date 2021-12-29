using VContainer;
using VContainer.Unity;
using VContainerSandbox;

namespace VContainerSandbox
{
    public class TestLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            // interfaceを実体化
            builder.Register<IHealthPoint, HealthPoint>(Lifetime.Scoped).WithParameter<int>(100);
            builder.RegisterComponentInHierarchy<HealthPointView>();
            // どこからも生成されないので、エントリーポイントとする
            builder.RegisterEntryPoint<HPPresenter>(Lifetime.Scoped);
        }
    }
}