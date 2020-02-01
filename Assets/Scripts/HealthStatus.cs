using Zenject;

public class HealthStatus
{
    public const int MaxHealth = 100;

    public enum HealthPart
    {
        Screen,
        Hip,
        LeftLeg,
        RightLeg,
        Weapon,
        Shield
    }

    public class UpdateHealthStatus
    {
        public HealthPart Part { get; set; }
    }

    [Inject]
    private SignalBus signalBus;

    private int screen = MaxHealth;
    private int hip = MaxHealth;
    private int leftLeg = MaxHealth;
    private int rightLeg = MaxHealth;
    private int weapon = MaxHealth;
    private int shield = MaxHealth;

    public int Screen
    {
        get { return this.screen; }
        set
        {
            this.screen = value > 100 ? 100 : (value < 0 ? 0 : value);
            this.signalBus.Fire(new UpdateHealthStatus { Part = HealthPart.Screen });
        }
    }

    public int Hip
    {
        get { return this.hip; }
        set
        {
            this.hip = value > 100 ? 100 : (value < 0 ? 0 : value);
            this.signalBus.Fire(new UpdateHealthStatus { Part = HealthPart.Hip });
        }
    }

    public int LeftLeg
    {
        get { return this.leftLeg; }
        set
        {
            this.leftLeg = value > 100 ? 100 : (value < 0 ? 0 : value);
            this.signalBus.Fire(new UpdateHealthStatus { Part = HealthPart.LeftLeg });
        }
    }

    public int RightLeg
    {
        get { return this.rightLeg; }
        set
        {
            this.rightLeg = value > 100 ? 100 : (value < 0 ? 0 : value);
            this.signalBus.Fire(new UpdateHealthStatus { Part = HealthPart.RightLeg });
        }
    }

    public int Weapon
    {
        get { return this.weapon; }
        set
        {
            this.weapon = value > 100 ? 100 : (value < 0 ? 0 : value);
            this.signalBus.Fire(new UpdateHealthStatus { Part = HealthPart.Weapon });
        }
    }

    public int Shield
    {
        get { return this.shield; }
        set
        {
            this.shield = value > 100 ? 100 : (value < 0 ? 0 : value);
            this.signalBus.Fire(new UpdateHealthStatus { Part = HealthPart.Shield });
        }
    }
}
