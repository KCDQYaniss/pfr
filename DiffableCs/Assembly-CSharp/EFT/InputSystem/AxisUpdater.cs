namespace EFT.InputSystem;

public class AxisUpdater : IInputUpdater
{
	private static readonly Dictionary _pool; //Field offset: 0x0
	private readonly string _axisName; //Field offset: 0x10
	private float _currentValue; //Field offset: 0x18

	private static AxisUpdater() { }

	private AxisUpdater(string axisName) { }

	public static AxisUpdater GetUpdater(string axisName) { }

	public override float GetValue() { }

	public override void Update() { }

}

