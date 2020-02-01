using UnityEngine;
using Zenject;

public class GameplayInstaller : MonoInstaller
{
    [SerializeField] GameObject rocketPrefab;

    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);
        Container.DeclareSignal<HealthStatus.UpdateHealthStatus>();
        Container.BindInterfacesAndSelfTo<HealthStatus>().AsSingle();
        Container.BindFactory<Rocket, Rocket.Factory>().FromComponentInNewPrefab(this.rocketPrefab);
    }
}
