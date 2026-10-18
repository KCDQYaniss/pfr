namespace EFT;

public class BeltDetachablePart : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <DestroyBelt>d__9 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BeltDetachablePart <>4__this; //Field offset: 0x20
		private float <timeForDisableRigidbody>5__2; //Field offset: 0x28

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
		public <DestroyBelt>d__9(int <>1__state) { }

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
	private Rigidbody _rigidbody; //Field offset: 0x20
	[SerializeField]
	private EAmmoBeltSpawnDirection _spawnDirection; //Field offset: 0x28
	[SerializeField]
	private float _beltLifetime; //Field offset: 0x2C
	[SerializeField]
	private float _forceInSpawn; //Field offset: 0x30
	private IEnumerator _destroyBeltCoroutine; //Field offset: 0x38
	private bool _collided; //Field offset: 0x40

	public BeltDetachablePart() { }

	[IteratorStateMachine(typeof(<DestroyBelt>d__9))]
	private IEnumerator DestroyBelt() { }

	private Vector3 GetDirection(EAmmoBeltSpawnDirection spawnDirection) { }

	public void OnCollisionEnter(Collision other) { }

	private void OnDestroy() { }

	public void Spawn() { }

}

