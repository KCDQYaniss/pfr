//Type is in global namespace

[AddComponentMenu("Destruction/Box Fracture")]
[RequireComponent(typeof(Trigger))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class BoxFracture : BaseFracture
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public Vector3[] points; //Field offset: 0x10
		public int i; //Field offset: 0x18
		public Comparison <>9__0; //Field offset: 0x20

		public <>c__DisplayClass1_0() { }

		internal int <ImmediateFracture>b__0(Vector3 p1, Vector3 p2) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Vector3 point; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal int <SpreadFracture>b__0(Vector3 p1, Vector3 p2) { }

	}

	[CompilerGenerated]
	private sealed class <SpreadFracture>d__2 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BoxFracture <>4__this; //Field offset: 0x20
		public Vector3[] points; //Field offset: 0x28
		private int <currentShard>5__2; //Field offset: 0x30
		private int <remainingShards>5__3; //Field offset: 0x34

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SpreadFracture>d__2(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private List sortedVoronoiPoints; //Field offset: 0x90

	public BoxFracture() { }

	private void CalculateVerts(Vector3 point) { }

	private void CreateInitialPlanes(Vector3 point) { }

	private float GetMaxDistance() { }

	protected virtual void ImmediateFracture(Vector3[] points) { }

	private void ReorderPlanes() { }

	[IteratorStateMachine(typeof(<SpreadFracture>d__2))]
	protected virtual IEnumerator SpreadFracture(Vector3[] points) { }

}

