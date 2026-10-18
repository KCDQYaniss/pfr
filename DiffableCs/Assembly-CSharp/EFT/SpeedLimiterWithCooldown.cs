namespace EFT;

public class SpeedLimiterWithCooldown : SpeedLimiter
{
	private readonly float _cooldownTime; //Field offset: 0x28
	private float _timer; //Field offset: 0x2C
	[CompilerGenerated]
	private float <ScheduledSpeed>k__BackingField; //Field offset: 0x30

	public private float ScheduledSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public SpeedLimiterWithCooldown(Config config, int maxStrengthLevel, float cooldownTime) { }

	[CompilerGenerated]
	public float get_ScheduledSpeed() { }

	[CompilerGenerated]
	private void set_ScheduledSpeed(float value) { }

	private void SetSpeed(float speed) { }

	public virtual void Update(EPlayerState state, int strengthLevel, float walkSpeedLimit) { }

	public virtual void Update(float deltaTime) { }

}

