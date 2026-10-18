//Type is in global namespace

public class RangedInt
{
	[SerializeField]
	private int min; //Field offset: 0x10
	[SerializeField]
	private int max; //Field offset: 0x14

	public int Max
	{
		 get { } //Length: 4
	}

	public int Min
	{
		 get { } //Length: 164
	}

	public RangedInt(int min, int max) { }

	public int Clamp(int input) { }

	public int get_Max() { }

	public int get_Min() { }

	public int Random() { }

}

