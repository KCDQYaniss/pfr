namespace EFT.InputSystem;

public class RemoteAxisUpdater : IInputUpdater
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__CursorLockModeChangedHandler; //Field offset: 0x0

	}

	internal struct POINT
	{
		public int X; //Field offset: 0x0
		public int Y; //Field offset: 0x4

		public POINT(int x, int y) { }

	}

	private static readonly Dictionary _pool; //Field offset: 0x0
	private static CursorLockMode _currentLockMode; //Field offset: 0x8
	private static CursorLockMode _actualLockMode; //Field offset: 0xC
	private readonly int _axisIndex; //Field offset: 0x10
	private float _lastValue; //Field offset: 0x14
	private float _currentValue; //Field offset: 0x18

	private static RemoteAxisUpdater() { }

	private RemoteAxisUpdater(int axisIndex) { }

	private void CorrectCursorPosition(float deltaValue) { }

	private static void CursorLockModeChangedHandler() { }

	private static bool GetCursorPos(out POINT pos) { }

	public static RemoteAxisUpdater GetUpdater(int axisIndex) { }

	public override float GetValue() { }

	private static bool SetCursorPos(int X, int Y) { }

	public override void Update() { }

}

