namespace EFT.Animals;

public class BirdsSpawner : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <SpawnBirds>d__7 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BirdsSpawner <>4__this; //Field offset: 0x20
		public int count; //Field offset: 0x28
		private int <currentCount>5__2; //Field offset: 0x2C

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
		public <SpawnBirds>d__7(int <>1__state) { }

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

	[SerializeField]
	private BezierSpline[] _paths; //Field offset: 0x20
	[SerializeField]
	private GameObject[] _birdsPrefabs; //Field offset: 0x28
	[SerializeField]
	private int _count; //Field offset: 0x30
	[SerializeField]
	private float _spawnDelay; //Field offset: 0x34

	public BirdsSpawner() { }

	private void Awake() { }

	public void Spawn() { }

	public void Spawn(int count) { }

	[IteratorStateMachine(typeof(<SpawnBirds>d__7))]
	private IEnumerator SpawnBirds(int count) { }

}

