namespace EFT.HealthSystem;

public struct ValueStruct
{
	public float Current; //Field offset: 0x0
	public float Maximum; //Field offset: 0x4
	public float Minimum; //Field offset: 0x8
	public float OverDamageReceivedMultiplier; //Field offset: 0xC
	public float EnvironmentDamageMultiplier; //Field offset: 0x10

	public bool AtMaximum
	{
		 get { } //Length: 112
	}

	public bool AtMinimum
	{
		 get { } //Length: 112
	}

	public float Normalized
	{
		 get { } //Length: 10
	}

	public bool get_AtMaximum() { }

	public bool get_AtMinimum() { }

	public float get_Normalized() { }

}

