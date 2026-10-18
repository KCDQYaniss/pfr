namespace EFT;

public struct TacticalComboStatus
{
	public string Id; //Field offset: 0x0
	public bool IsActive; //Field offset: 0x8
	public int SelectedMode; //Field offset: 0xC
	public int ScopeCalibrationIndex; //Field offset: 0x10

	public static void Serialize(IBitStream stream, ref TacticalComboStatus tacticalComboStatus) { }

	public virtual string ToString() { }

}

