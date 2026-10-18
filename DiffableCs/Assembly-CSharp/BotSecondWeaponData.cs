//Type is in global namespace

public class BotSecondWeaponData : BotData
{
	private const float START_TIME_OFFSET = 90; //Field offset: 0x0
	private const float DELAY_BEFORE_ACTION = 1; //Field offset: 0x0
	private const float DELAY_ACTION_TIME = 2; //Field offset: 0x0
	private float _nextPossibleUseTime; //Field offset: 0x18
	private bool _shallStart; //Field offset: 0x1C
	private float _ammoActionTime; //Field offset: 0x20
	private float _returnToMainTime; //Field offset: 0x24
	private IPlayer _lookTo; //Field offset: 0x28
	private bool _canUse; //Field offset: 0x30

	public bool HaveSecondWeapon
	{
		 get { } //Length: 259
	}

	public BotSecondWeaponData(BotOwner owner) { }

	[CompilerGenerated]
	private void <Apply>b__17_0(Result x) { }

	public void Activate() { }

	public void Apply() { }

	public bool get_HaveSecondWeapon() { }

	public bool HaveActions() { }

	public void ManualUpdate() { }

	public void StartDo(BotsPairData closest) { }

	private void UpdatePeriod() { }

}

