using Zenject;
using UnityEngine;

public class GameplayInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<HealthStatus>().AsSingle();
    }
}
