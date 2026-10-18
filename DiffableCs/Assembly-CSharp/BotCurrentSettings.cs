//Type is in global namespace

public class BotCurrentSettings
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public BotCurrentSettings <>4__this; //Field offset: 0x10
		public BotSettingsInGameModif modif; //Field offset: 0x18

		public <>c__DisplayClass59_0() { }

		internal void <Apply>b__0() { }

	}

	public float _precicingSpeedCoef; //Field offset: 0x10
	public float _accuratySpeedCoef; //Field offset: 0x14
	public float _layChanceDangerCoef; //Field offset: 0x18
	public float _visibleDistCoef; //Field offset: 0x1C
	public float _runtimeVisionEffectK; //Field offset: 0x20
	public float _scatteringCoef; //Field offset: 0x24
	public float _priorityScatteringCoef; //Field offset: 0x28
	public float _hearingDistCoef; //Field offset: 0x2C
	public float _waitInCoverCoef; //Field offset: 0x30
	public float _triggerDownDelay; //Field offset: 0x34
	private readonly BotCurrentScatteringSetting _scatteringSettingSettings; //Field offset: 0x38
	[CompilerGenerated]
	private readonly BotSettingsComponents <FileSettings>k__BackingField; //Field offset: 0x40

	public float CloseHearingSense
	{
		 get { } //Length: 42
	}

	public float CurrentAccuratySpeed
	{
		 get { } //Length: 42
	}

	public float CurrentHearingSense
	{
		 get { } //Length: 42
	}

	public float CurrentHoldDownAutoFire
	{
		 get { } //Length: 42
	}

	public float CurrentHoldDownSingleShot
	{
		 get { } //Length: 42
	}

	public float CurrentHoldDownStationaryBullet
	{
		 get { } //Length: 42
	}

	public float CurrentHoldDownStationaryGrenade
	{
		 get { } //Length: 42
	}

	public float CurrentLayChance
	{
		 get { } //Length: 45
	}

	public float CurrentMaxScatter
	{
		 get { } //Length: 42
	}

	public float CurrentMinScatter
	{
		 get { } //Length: 42
	}

	public float CurrentPrecicingSpeed
	{
		 get { } //Length: 42
	}

	public float CurrentScattering
	{
		 get { } //Length: 42
	}

	public float CurrentScatteringClose
	{
		 get { } //Length: 42
	}

	public float CurrentScatteringUp
	{
		 get { } //Length: 42
	}

	public float CurrentVisibleDistance
	{
		 get { } //Length: 42
	}

	public float CurrentWorkingScatter
	{
		 get { } //Length: 42
	}

	public float FarHearingSense
	{
		 get { } //Length: 42
	}

	private BotSettingsComponents FileSettings
	{
		[CompilerGenerated]
		private get { } //Length: 5
	}

	public float PriorityScatter100meter
	{
		 get { } //Length: 42
	}

	public float PriorityScatter10meter
	{
		 get { } //Length: 42
	}

	public float PriorityScatter1meter
	{
		 get { } //Length: 42
	}

	public float RuntimeVisionEffectsK
	{
		 get { } //Length: 42
	}

	public float WaitInCoverBetweenShotsSecCurrent
	{
		 get { } //Length: 42
	}

	public BotCurrentSettings(BotSettingsComponents mainSettings, BotCurrentScatteringSetting scatteringSettingSettings) { }

	public void Apply(BotSettingsInGameModif modif, float duractionSec = -1) { }

	public void Dismiss(BotSettingsInGameModif modif) { }

	public float get_CloseHearingSense() { }

	public float get_CurrentAccuratySpeed() { }

	public float get_CurrentHearingSense() { }

	public float get_CurrentHoldDownAutoFire() { }

	public float get_CurrentHoldDownSingleShot() { }

	public float get_CurrentHoldDownStationaryBullet() { }

	public float get_CurrentHoldDownStationaryGrenade() { }

	public float get_CurrentLayChance() { }

	public float get_CurrentMaxScatter() { }

	public float get_CurrentMinScatter() { }

	public float get_CurrentPrecicingSpeed() { }

	public float get_CurrentScattering() { }

	public float get_CurrentScatteringClose() { }

	public float get_CurrentScatteringUp() { }

	public float get_CurrentVisibleDistance() { }

	public float get_CurrentWorkingScatter() { }

	public float get_FarHearingSense() { }

	[CompilerGenerated]
	private BotSettingsComponents get_FileSettings() { }

	public float get_PriorityScatter100meter() { }

	public float get_PriorityScatter10meter() { }

	public float get_PriorityScatter1meter() { }

	public float get_RuntimeVisionEffectsK() { }

	public float get_WaitInCoverBetweenShotsSecCurrent() { }

	public bool IsParametersChanged() { }

}

