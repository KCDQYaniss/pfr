namespace EFT;

public class Thermobaric
{
	internal struct Cell : IEquatable
	{
		private const int BIG_ENOUGH_INT = 16384; //Field offset: 0x0
		private const double BIG_ENOUGH_FLOOR = 16384; //Field offset: 0x0
		public bool NoWay; //Field offset: 0x0
		public Vector3 Position; //Field offset: 0x4
		public float CellSize; //Field offset: 0x10
		public int StepsTo; //Field offset: 0x14

		public Cell(Vector3 position, float cellSize, int stepsTo) { }

		public override bool Equals(Cell other) { }

		public virtual bool Equals(object obj) { }

		private static int FastFloor(float f) { }

		public virtual int GetHashCode() { }

	}

	private struct ThermobaricData
	{
		[CompilerGenerated]
		private sealed class <GetNeighbours>d__4 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private Cell <>2__current; //Field offset: 0x14
			private int <>l__initialThreadId; //Field offset: 0x2C
			private Cell cell; //Field offset: 0x30
			public Cell <>3__cell; //Field offset: 0x48
			public ThermobaricData <>4__this; //Field offset: 0x60
			public ThermobaricData <>3__<>4__this; //Field offset: 0x78
			private Vector3 <position>5__2; //Field offset: 0x90
			private float <cellSize>5__3; //Field offset: 0x9C
			private int <stepsTo>5__4; //Field offset: 0xA0

			private override Cell System.Collections.Generic.IEnumerator<EFT.Thermobaric.Cell>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 21
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 85
			}

			[DebuggerHidden]
			public <GetNeighbours>d__4(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.Generic.IEnumerable<EFT.Thermobaric.Cell>.GetEnumerator() { }

			[DebuggerHidden]
			private override Cell System.Collections.Generic.IEnumerator<EFT.Thermobaric.Cell>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		public HashSet Frontier; //Field offset: 0x0
		public HashSet Checked; //Field offset: 0x8
		public HashSet Buffer; //Field offset: 0x10

		private bool CanStep(Cell from, Cell to) { }

		[IteratorStateMachine(typeof(<GetNeighbours>d__4))]
		private IEnumerable GetNeighbours(Cell cell) { }

		public void Proceed() { }

		private void ProceedStep(Cell origin, Cell target) { }

	}

	public static Thermobaric Instance; //Field offset: 0x0
	private const float CELL_SIZE_CALCULATE = 0.5; //Field offset: 0x0
	private const float CELL_SIZE_RENDER = 1; //Field offset: 0x0
	public static int Iterations; //Field offset: 0x8
	public static int CellsLimit; //Field offset: 0xC
	private readonly HashSet _buffer; //Field offset: 0x10

	private static Thermobaric() { }

	public Thermobaric() { }

	public void CalculateFrom(Vector3 origin, Vector3 forward) { }

}

