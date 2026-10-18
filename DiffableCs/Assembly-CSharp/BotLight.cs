//Type is in global namespace

public class BotLight : BotData
{
	private const float DELAY = 3; //Field offset: 0x0
	private bool _haveLight; //Field offset: 0x18
	private bool _canUseNow; //Field offset: 0x19
	private bool _isInDarkPlace; //Field offset: 0x1A
	private float _curLightDist; //Field offset: 0x1C
	private FirearmController _firearmController; //Field offset: 0x20
	private float _nextTimeUpdaDist; //Field offset: 0x28
	private LightComponent _lightMod; //Field offset: 0x30
	private float _nextCanToggleTime; //Field offset: 0x38
	private BotStroboscopeLight _stroboscope; //Field offset: 0x40

	public bool CanUseBySettings
	{
		 get { } //Length: 57
	}

	private FirearmController FirearmController
	{
		private get { } //Length: 421
	}

	public bool IsEnable
	{
		 get { } //Length: 23
	}

	public bool IsInDarkPlace
	{
		 set { } //Length: 24
	}

	public BotStroboscopeLight Stroboscope
	{
		 get { } //Length: 5
	}

	public BotLight(BotOwner owner) { }

	public void FindLight() { }

	public bool get_CanUseBySettings() { }

	private FirearmController get_FirearmController() { }

	public bool get_IsEnable() { }

	public BotStroboscopeLight get_Stroboscope() { }

	private void LeaveDarkPlace() { }

	public void set_IsInDarkPlace(bool value) { }

	public void TurnOff(bool dependceOnEnemy = true, bool anyTime = false) { }

	public void TurnOn(bool anyTime = false) { }

	public float UpdateLightEnable(float curLightDist) { }

	public void UpdateStrope() { }

	private float UpdateVision(float botVisibleDist) { }

}

