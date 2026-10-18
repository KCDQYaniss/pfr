//Type is in global namespace

public abstract class LightOverride : MonoBehaviour
{
	internal enum Type
	{
		None = 0,
		Point = 1,
		Tube = 2,
		Area = 3,
		Directional = 4,
	}

	[Header("Overrides")]
	public float m_IntensityMult; //Field offset: 0x20
	[MinValue(0)]
	public float m_RangeMult; //Field offset: 0x24
	private Type m_Type; //Field offset: 0x28
	private bool m_Initialized; //Field offset: 0x2C
	private Light m_Light; //Field offset: 0x30
	private TubeLight m_TubeLight; //Field offset: 0x38
	private AreaLight m_AreaLight; //Field offset: 0x40

	public private AreaLight areaLight
	{
		 get { } //Length: 26
		private set { } //Length: 3
	}

	public private bool isOn
	{
		 get { } //Length: 191
		private set { } //Length: 3
	}

	public private Light light
	{
		 get { } //Length: 26
		private set { } //Length: 3
	}

	public private TubeLight tubeLight
	{
		 get { } //Length: 26
		private set { } //Length: 3
	}

	public private Type type
	{
		 get { } //Length: 25
		private set { } //Length: 3
	}

	protected LightOverride() { }

	public AreaLight get_areaLight() { }

	public bool get_isOn() { }

	public Light get_light() { }

	public TubeLight get_tubeLight() { }

	public Type get_type() { }

	public abstract bool GetForceOn() { }

	private void Init() { }

	private void set_areaLight(AreaLight value) { }

	private void set_isOn(bool value) { }

	private void set_light(Light value) { }

	private void set_tubeLight(TubeLight value) { }

	private void set_type(Type value) { }

	private void Update() { }

}

