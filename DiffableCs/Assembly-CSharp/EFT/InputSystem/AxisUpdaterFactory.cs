namespace EFT.InputSystem;

public static class AxisUpdaterFactory
{
	private static string[] _appropriateAxes; //Field offset: 0x0
	private static MouseAxisUpdateType _updateType; //Field offset: 0x8

	private static AxisUpdaterFactory() { }

	public static IInputUpdater GetAxisUpdater(string axisName) { }

	public static void UpdateMouseAxisUpdateType(int type) { }

}

