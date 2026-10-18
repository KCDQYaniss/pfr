//Type is in global namespace

public sealed class PartLineOfSightCheckResult : IDisposable
{
	public bool HasLineOfSight; //Field offset: 0x10
	public RaycastHit TargetToBotHit; //Field offset: 0x14
	public RaycastHit BotToTargetHit; //Field offset: 0x40
	public ELookObstacleType BotToTargetObstacleType; //Field offset: 0x6C
	public ELookObstacleType TargetToBotObstacleType; //Field offset: 0x70
	public bool IsGreen; //Field offset: 0x74
	public float GreenDistance; //Field offset: 0x78
	public float GreenK; //Field offset: 0x7C
	private bool _botToTargetLineOfSight; //Field offset: 0x80
	private bool _targetToBotLineOfSight; //Field offset: 0x81

	public bool BotToTargetLineOfSight
	{
		 get { } //Length: 8
		 set { } //Length: 37
	}

	public bool TargetToBotLineOfSight
	{
		 get { } //Length: 8
		 set { } //Length: 28
	}

	public PartLineOfSightCheckResult() { }

	public override void Dispose() { }

	public bool get_BotToTargetLineOfSight() { }

	public bool get_TargetToBotLineOfSight() { }

	public void set_BotToTargetLineOfSight(bool value) { }

	public void set_TargetToBotLineOfSight(bool value) { }

	public virtual string ToString() { }

}

