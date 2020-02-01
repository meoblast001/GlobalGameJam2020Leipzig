using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class HealthDisplay : MonoBehaviour
{
    [Inject]
    private SignalBus signalBus;
    [Inject]
    private HealthStatus healthStatus;

    [SerializeField] private Text screenText;
    [SerializeField] private Text hipText;
    [SerializeField] private Text rightLegText;
    [SerializeField] private Text leftLegText;
    [SerializeField] private Text weaponText;
    [SerializeField] private Text shieldText;

    void Start()
    {
        this.signalBus.Subscribe<HealthStatus.UpdateHealthStatus>(this.UpdateHealthStatus);
    }

    void OnDestroy()
    {
        this.signalBus.Unsubscribe<HealthStatus.UpdateHealthStatus>(this.UpdateHealthStatus);
    }

    private void UpdateHealthStatus(HealthStatus.UpdateHealthStatus update)
    {
        switch (update.Part)
        {
            case HealthStatus.HealthPart.Screen:
                this.screenText.text = this.healthStatus.LeftLeg.ToString();
                break;
            case HealthStatus.HealthPart.Hip:
                this.hipText.text = this.healthStatus.Hip.ToString();
                break;
            case HealthStatus.HealthPart.RightLeg:
                this.rightLegText.text = this.healthStatus.RightLeg.ToString();
                break;
            case HealthStatus.HealthPart.LeftLeg:
                this.leftLegText.text = this.healthStatus.LeftLeg.ToString();
                break;
            case HealthStatus.HealthPart.Weapon:
                this.weaponText.text = this.healthStatus.Weapon.ToString();
                break;
            case HealthStatus.HealthPart.Shield:
                this.shieldText.text = this.healthStatus.Shield.ToString();
                break;
            default:
                Debug.LogError($"Unknown health status type '{update}'");
                break;
        }
    }
}
