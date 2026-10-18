namespace EFT.Ballistics;

public sealed class BallisticCalculatorPrewarmer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ShotDelegate <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SimulateShot>b__3_0(Shot x) { }

	}

	private const float SIMULATION_STEP = 1; //Field offset: 0x0
	private const float SIMULATION_TIME = 1; //Field offset: 0x0
	private BallisticsCalculator _calculator; //Field offset: 0x20

	public BallisticCalculatorPrewarmer() { }

	private void OnDestroy() { }

	public Shot SimulateShot() { }

}

