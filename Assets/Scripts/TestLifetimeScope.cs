using UnityEngine;
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
            // どこからも生成されないので、エントリーポイントとする
            builder.RegisterEntryPoint<HealthPointPresenter>(Lifetime.Scoped);
            builder.RegisterComponentInHierarchy<HealthPointView>();
            builder.Register<IHealthPoint, HealthPoint>(Lifetime.Scoped).WithParameter<int>(100);
        }
    }
}