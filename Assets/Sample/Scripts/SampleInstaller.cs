using Zenject;

namespace Sample.Scripts
{
    public class SampleInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<SampleA>().AsSingle();
            Container.Bind<SampleB>().AsSingle();
            // Container.Bind<SampleA>().AsSingle().WithArguments(false);
            // Container.Bind<SampleB>().AsSingle().WithArguments(0.5f);
        }
    }
}