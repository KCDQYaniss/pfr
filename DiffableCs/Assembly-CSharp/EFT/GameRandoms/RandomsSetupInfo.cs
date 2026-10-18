namespace EFT.GameRandoms;

public class RandomsSetupInfo
{
	public int Seed; //Field offset: 0x10
	public int Count; //Field offset: 0x14
	public int Index; //Field offset: 0x18

	public RandomsSetupInfo() { }

	public virtual string ToString() { }

}

