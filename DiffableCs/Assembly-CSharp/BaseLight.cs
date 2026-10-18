//Type is in global namespace

public abstract class BaseLight : MonoBehaviour
{
	[FormerlySerializedAs("m_Intensity")]
	[MinValue(0)]
	[SerializeField]
	protected float _intensity; //Field offset: 0x20
	protected float PrevIntensity; //Field offset: 0x24

	public abstract float m_Intensity
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected bool NeedToTurnOff
	{
		 get { } //Length: 91
	}

	protected bool NeedToTurnOn
	{
		 get { } //Length: 91
	}

	protected BaseLight() { }

	public abstract float get_m_Intensity() { }

	protected bool get_NeedToTurnOff() { }

	protected bool get_NeedToTurnOn() { }

	public abstract void set_m_Intensity(float value) { }

	protected void UpdatePrevIntensity() { }

}

