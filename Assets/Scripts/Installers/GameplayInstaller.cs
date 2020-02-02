using UnityEngine;
using Zenject;

public class GameplayInstaller : MonoInstaller
{
    [SerializeField] GameObject rocketPrefab;
    [SerializeField] GameObject bigRocketPrefab;

    public override void InstallBindings()
    {
        SignalBusInstaller.Install(Container);
        Container.DeclareSignal<HealthStatus.UpdateHealthStatus>();
        Container.BindInterfacesAndSelfTo<HealthStatus>().AsSingle();
        Container.BindFactory<Rocket, Rocket.RocketFactory>().FromComponentInNewPrefab(this.rocketPrefab);
        Container.BindFactory<Rocket, Rocket.BigRocketFactory>().FromComponentInNewPrefab(this.bigRocketPrefab);
    }
}
