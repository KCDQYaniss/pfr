namespace EFT.Rendering.Clouds;

[IsReadOnly]
public struct CloudRemapRecord
{
	public readonly bool IsValid; //Field offset: 0x0
	public readonly float L1R; //Field offset: 0x4
	public readonly float L1G; //Field offset: 0x8
	public readonly float L1B; //Field offset: 0xC
	public readonly float L1A; //Field offset: 0x10

	public CloudRemapRecord(float l1R, float l1G, float l1B, float l1A) { }

}

