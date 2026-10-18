namespace EFT;

public struct LightsState
{
	public string Id; //Field offset: 0x0
	public bool IsActive; //Field offset: 0x8
	public int LightMode; //Field offset: 0xC

	public static void Serialize(IBitStream stream, ref LightsState tacticalComboStatus) { }

	public virtual string ToString() { }

}

