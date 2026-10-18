namespace EFT.EnvironmentEffect;

public class EnvironmentManager : EnvironmentManagerBase
{
	private static readonly int _isPlayerInEnvironment; //Field offset: 0x0
	[Header("Outdoor")]
	[SerializeField]
	private float OutdoorFadeTime; //Field offset: 0x40
	[SerializeField]
	private float OutdoorExposureSpeed; //Field offset: 0x44
	[SerializeField]
	private float OutdoorExposureOffset; //Field offset: 0x48
	[Header("Long Shadow Reduising")]
	public bool EnableLongShadowsCorrection; //Field offset: 0x4C
	[MinMaxVec2(0, 24, -1)]
	[SerializeField]
	private Vector2 ShadowInterval1; //Field offset: 0x50
	[MinMaxVec2(0, 24, -1)]
	[SerializeField]
	private Vector2 ShadowInterval2; //Field offset: 0x58
	[SerializeField]
	private float ShadowDecreaseFactor; //Field offset: 0x60
	[SerializeField]
	private float ShadowMinDistance; //Field offset: 0x64
	[CompilerGenerated]
	private EnvironmentType <Environment>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private bool <InBunker>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private float <PrismExposureSpeed>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private float <PrismExposureOffset>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private Action OnPlayerEnvironmentChanged; //Field offset: 0x78
	private float _targetExposureSpeed; //Field offset: 0x80
	private float _targetExposureOffset; //Field offset: 0x84
	private Dictionary _playersCurrentEnvironmentTypes; //Field offset: 0x88
	private float _fadeTime; //Field offset: 0x90
	private float _prismExposureOffsetVelocity; //Field offset: 0x94
	private float _prismExposureSpeedVelocity; //Field offset: 0x98
	private ThermalVision _thermalVision; //Field offset: 0xA0
	private int _frameCount; //Field offset: 0xA8

	public event Action OnPlayerEnvironmentChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private EnvironmentType Environment
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool InBunker
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public static EnvironmentManager Instance
	{
		 get { } //Length: 143
	}

	private bool IsMainThermalVisionOn
	{
		private get { } //Length: 562
	}

	private float OutdoorShadowDistance
	{
		private get { } //Length: 394
	}

	public private float PrismExposureOffset
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float PrismExposureSpeed
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	private static EnvironmentManager() { }

	public EnvironmentManager() { }

	[CompilerGenerated]
	public void add_OnPlayerEnvironmentChanged(Action value) { }

	[CompilerGenerated]
	public EnvironmentType get_Environment() { }

	[CompilerGenerated]
	public bool get_InBunker() { }

	public static EnvironmentManager get_Instance() { }

	private bool get_IsMainThermalVisionOn() { }

	private float get_OutdoorShadowDistance() { }

	[CompilerGenerated]
	public float get_PrismExposureOffset() { }

	[CompilerGenerated]
	public float get_PrismExposureSpeed() { }

	public EnvironmentType GetEnvironmentByPos(Vector3 pos) { }

	private float GetLongShadowCorrectionFactor() { }

	public EnvironmentType GetPlayerCurrentEnvironmentType(int playerRaidId) { }

	protected virtual void Init() { }

	protected virtual void OnDestroy() { }

	[CompilerGenerated]
	public void remove_OnPlayerEnvironmentChanged(Action value) { }

	[CompilerGenerated]
	private void set_Environment(EnvironmentType value) { }

	[CompilerGenerated]
	private void set_InBunker(bool value) { }

	[CompilerGenerated]
	private void set_PrismExposureOffset(float value) { }

	[CompilerGenerated]
	private void set_PrismExposureSpeed(float value) { }

	protected virtual void SetTriggerForPlayer(IPlayer player, IndoorTrigger trigger) { }

	private void Update() { }

	public void UpdateEnvironmentForPlayer(IPlayer player) { }

}

