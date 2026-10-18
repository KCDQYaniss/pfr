namespace EFT.Visual;

public sealed class SkinDress : Dress
{
	[CompilerGenerated]
	private sealed class <GetRenderers>d__4 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Renderer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public SkinDress <>4__this; //Field offset: 0x28
		private AbstractSkin[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38

		private override Renderer System.Collections.Generic.IEnumerator<UnityEngine.Renderer>.Current
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
		public <GetRenderers>d__4(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<UnityEngine.Renderer>.GetEnumerator() { }

		[DebuggerHidden]
		private override Renderer System.Collections.Generic.IEnumerator<UnityEngine.Renderer>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[SerializeField]
	private AbstractSkin[] _lods; //Field offset: 0x40

	public SkinDress() { }

	[IteratorStateMachine(typeof(<GetRenderers>d__4))]
	protected virtual IEnumerable GetRenderers() { }

	public virtual void Init(PlayerBody playerBody) { }

	protected virtual void OnSkin(Transform playerTransform, Transform meshTransform) { }

	public virtual void Unskin() { }

}

