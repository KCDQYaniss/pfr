namespace EFT;

public struct ScopeState
{
	public string Id; //Field offset: 0x0
	public int ScopeMode; //Field offset: 0x8
	public int ScopeIndexInsideSight; //Field offset: 0xC
	public int ScopeCalibrationIndex; //Field offset: 0x10

	public static bool IsScopeStatesDifferent(ScopeState stateA, ScopeState stateB) { }

}

