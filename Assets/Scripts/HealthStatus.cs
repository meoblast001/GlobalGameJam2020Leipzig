public class HealthStatus
{
    public const int MaxHealth = 100;

    private int leftLeg = MaxHealth;
    private int rightLeg = MaxHealth;

    public int LeftLeg
    {
        get { return this.leftLeg; }
        set { this.leftLeg = value > 100 ? 100 : (value < 0 ? 0 : value); }
    }

    public int RightLeg
    {
        get { return this.rightLeg; }
        set { this.rightLeg = value > 100 ? 100 : (value < 0 ? 0 : value); }
    }
}
