using Zenject;

public class SampleInstaller : Installer<SampleInstaller>
{
    public override void InstallBindings()
    {
        Container.Bind<IPort>().To<Sample>().AsCached();
    }
}