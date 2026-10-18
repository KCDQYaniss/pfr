namespace EFT.GameTriggers;

public class HandlerShoot : BaseTriggerHandler
{
	[SerializeField]
	private string _configurationId; //Field offset: 0x28
	[SerializeField]
	private bool _justOnce; //Field offset: 0x30
	[SerializeField]
	private string _ammoTemplateId; //Field offset: 0x38
	[SerializeField]
	private Transform _origin; //Field offset: 0x40
	[SerializeField]
	private SoundBank _shootSFX; //Field offset: 0x48
	[SerializeField]
	private EnvironmentType _shootSFXEnvironment; //Field offset: 0x50
	[SerializeField]
	private bool _enabledReverb; //Field offset: 0x54
	[SerializeField]
	private DamageData[] _damageData; //Field offset: 0x58
	[SerializeField]
	private FirearmsEffects _firearmsEffects; //Field offset: 0x60
	private bool _isDone; //Field offset: 0x68

	public string ConfigurationId
	{
		 get { } //Length: 5
	}

	public DamageData[] DamageData
	{
		 get { } //Length: 5
	}

	public HandlerShoot() { }

	private void DealDamage(int playerRaidId) { }

	public string get_ConfigurationId() { }

	public DamageData[] get_DamageData() { }

	private bool HasAuthority() { }

	private void OnShootEvent(TriggerEvent triggerEvent) { }

	private void OnShootEventClient() { }

	private void Start() { }

}

