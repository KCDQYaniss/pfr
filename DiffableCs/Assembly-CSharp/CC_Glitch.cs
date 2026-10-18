//Type is in global namespace

[AddComponentMenu("Colorful/Glitch")]
[ExecuteInEditMode]
public class CC_Glitch : CC_Base
{
	internal class InterferenceSettings
	{
		public float speed; //Field offset: 0x10
		public float density; //Field offset: 0x14
		public float maxDisplacement; //Field offset: 0x18

		public InterferenceSettings() { }

	}

	internal enum Mode
	{
		Interferences = 0,
		Tearing = 1,
		Complete = 2,
	}

	internal class TearingSettings
	{
		public float speed; //Field offset: 0x10
		[Range(0, 1)]
		public float intensity; //Field offset: 0x14
		[Range(0, 0.5)]
		public float maxDisplacement; //Field offset: 0x18
		public bool allowFlipping; //Field offset: 0x1C
		public bool yuvColorBleeding; //Field offset: 0x1D
		[Range(-2, 2)]
		public float yuvOffset; //Field offset: 0x20

		public TearingSettings() { }

	}

	private static readonly int _params; //Field offset: 0x0
	public bool randomActivation; //Field offset: 0x38
	public Vector2 randomEvery; //Field offset: 0x3C
	public Vector2 randomDuration; //Field offset: 0x44
	public Mode mode; //Field offset: 0x4C
	public InterferenceSettings interferencesSettings; //Field offset: 0x50
	public TearingSettings tearingSettings; //Field offset: 0x58
	protected Camera m_Camera; //Field offset: 0x60
	protected bool m_Activated; //Field offset: 0x68
	protected float m_EveryTimer; //Field offset: 0x6C
	protected float m_EveryTimerEnd; //Field offset: 0x70
	protected float m_DurationTimer; //Field offset: 0x74
	protected float m_DurationTimerEnd; //Field offset: 0x78

	public bool IsActive
	{
		 get { } //Length: 5
	}

	private static CC_Glitch() { }

	public CC_Glitch() { }

	protected override void DoInterferences(RenderTexture source, RenderTexture destination, InterferenceSettings settings) { }

	protected override void DoTearing(RenderTexture source, RenderTexture destination, TearingSettings settings) { }

	public bool get_IsActive() { }

	protected override void OnEnable() { }

	protected override void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected virtual void Start() { }

	protected override void Update() { }

}

