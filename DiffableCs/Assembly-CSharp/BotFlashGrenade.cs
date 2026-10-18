//Type is in global namespace

public class BotFlashGrenade : BotData
{
	private float _flashEndTimne; //Field offset: 0x18
	private float _shootInFlashEndTime; //Field offset: 0x1C
	private bool _isFlashed; //Field offset: 0x20
	private bool _shallRun; //Field offset: 0x21
	private Nullable _lastTargetToShoot; //Field offset: 0x24
	private BotSettingsInGameModif _lastBlindEffectModif; //Field offset: 0x38
	private BotSettingsInGameModif _lastBlindEffectModif2; //Field offset: 0x40
	private BotSettingsInGameModif _lastSoundEffectModif; //Field offset: 0x48

	public bool IsFlashed
	{
		 get { } //Length: 131
	}

	public Nullable PlaceToShoot
	{
		 get { } //Length: 442
	}

	public BotFlashGrenade(BotOwner owner) { }

	public void Activate() { }

	public void AddBlindEffect(float time, Vector3 position) { }

	public void AddSoundEffect(float time, Vector3 position) { }

	private void DismissSettings() { }

	public void Dispose() { }

	public bool get_IsFlashed() { }

	public Nullable get_PlaceToShoot() { }

	private BotSettingsInGameModif NSettings() { }

	private void OnHealthEffectCreated(IHealthEffect obj) { }

	private void OnHealthEffectDestroyed(IHealthEffect obj) { }

	public bool ShallShoot() { }

}

