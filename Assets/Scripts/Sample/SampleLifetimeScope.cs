using Sample;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace VContainerSandbox
{
    public class SampleLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<IBar, Bar>(Lifetime.Scoped);
            builder.RegisterEntryPoint<EntryPoint>(Lifetime.Scoped);
            Debug.Log("sample Life time");
        }
    }
}