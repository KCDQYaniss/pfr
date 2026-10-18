namespace EFT;

public sealed class SightComponentDescriptor : ItemComponentDescriptor
{
	public int SelectedSightScope; //Field offset: 0x10
	public int[] ScopesSelectedModes; //Field offset: 0x18
	public int[] ScopesSelectedCalibPoints; //Field offset: 0x20
	public float ScopeZoomValue; //Field offset: 0x28

	public SightComponentDescriptor() { }

}

