namespace UnityDiagnostics;

public class CPULagSimulator : MonoBehaviour
{
	internal enum ELoadType
	{
		Calculation = 0,
		ThreadSleep = 1,
	}

	internal class LagSimulator
	{
		public const int MIN_LAG = 0; //Field offset: 0x0
		public const int MAX_LAG = 5000; //Field offset: 0x0
		private readonly Stopwatch _stopwatch; //Field offset: 0x10
		public bool Enabled; //Field offset: 0x18
		public TimeMeasurer TimeMesurer; //Field offset: 0x20
		public KeyCode ToggleGameKey; //Field offset: 0x28
		[Range(0, 5000)]
		public int FramesBetweenSpikes; //Field offset: 0x2C
		[Range(0, 5000)]
		public int LagDispersion; //Field offset: 0x30
		[Range(0, 5000)]
		public int ConstantLagMS; //Field offset: 0x34
		[CompilerGenerated]
		private int <LastLag>k__BackingField; //Field offset: 0x38
		public ELoadType LoadType; //Field offset: 0x3C
		private int _lastLagFrame; //Field offset: 0x40

		public int LastLag
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public LagSimulator() { }

		public void CheckToggleInput() { }

		private void CPURealLoad(long ms) { }

		[CompilerGenerated]
		public int get_LastLag() { }

		private bool IsEnabled() { }

		public void MakeLag() { }

		[CompilerGenerated]
		public void set_LastLag(int value) { }

	}

	private GUIStyle _boldTextStyle; //Field offset: 0x20
	public LagSimulator FixedUpdateLagSimulator; //Field offset: 0x28
	public LagSimulator UpdateLagSimulator; //Field offset: 0x30

	public CPULagSimulator() { }

	public static CPULagSimulator Add() { }

	private void Awake() { }

	private void DrawLabel(string info, Color color, Rect rect) { }

	private void FixedUpdate() { }

	private bool HasEnabledLagSimulators() { }

	private void OnGUI() { }

	public static void Remove() { }

	private void Start() { }

	private void Update() { }

}

