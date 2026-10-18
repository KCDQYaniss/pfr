namespace EFT;

public struct SightModeStatus
{
	public string Id; //Field offset: 0x0
	public int SelectedMode; //Field offset: 0x8
	public int ScopeIndexInsideSight; //Field offset: 0xC
	public int ScopeCalibrationIndex; //Field offset: 0x10

	public static void Serialize(IBitStream stream, ref SightModeStatus tacticalComboStatus) { }

}

