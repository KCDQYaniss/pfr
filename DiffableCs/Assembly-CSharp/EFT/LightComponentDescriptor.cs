namespace EFT;

public sealed class LightComponentDescriptor : ItemComponentDescriptor
{
	public bool IsActive; //Field offset: 0x10
	public int SelectedMode; //Field offset: 0x14

	public LightComponentDescriptor() { }

}

