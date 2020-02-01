using Zenject;

public class GameplayInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);
        Container.DeclareSignal<HealthStatus.UpdateHealthStatus>();
        Container.BindInterfacesAndSelfTo<HealthStatus>().AsSingle();
    }
}
