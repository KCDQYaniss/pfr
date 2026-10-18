namespace EFT.HealthSystem;

public class RelativeHealthValue : HealthValue
{
	private float _immutableValue; //Field offset: 0x30
	private float _valueModifier; //Field offset: 0x34

	public virtual float Current
	{
		 get { } //Length: 6
		 set { } //Length: 65
	}

	public RelativeHealthValue(float cur, float max, float min = 0) { }

	public RelativeHealthValue(ValueInfo valueInfo) { }

	public virtual float get_Current() { }

	public virtual void set_Current(float value) { }

}

