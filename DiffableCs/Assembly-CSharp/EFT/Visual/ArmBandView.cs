namespace EFT.Visual;

public sealed class ArmBandView : Dress
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__4_0; //Field offset: 0x8
		public static Func <>9__4_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Init>b__4_0(MeshCustomizationIdPair p) { }

		internal Mesh[] <Init>b__4_1(MeshCustomizationIdPair p) { }

	}

	[CompilerGenerated]
	private sealed class <GetRenderers>d__8 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Renderer <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ArmBandView <>4__this; //Field offset: 0x28
		private Skin[] <>7__wrap1; //Field offset: 0x30
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
		public <GetRenderers>d__8(int <>1__state) { }

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

	private sealed class MeshCustomizationIdPair
	{
		public string CustomizationId; //Field offset: 0x10
		public Mesh[] Meshes; //Field offset: 0x18

		public MeshCustomizationIdPair() { }

	}

	[SerializeField]
	private MeshCustomizationIdPair[] _customizationIdPair; //Field offset: 0x40
	private Dictionary _dict; //Field offset: 0x48
	[SerializeField]
	private Skin[] _main; //Field offset: 0x50

	public ArmBandView() { }

	[IteratorStateMachine(typeof(<GetRenderers>d__8))]
	protected virtual IEnumerable GetRenderers() { }

	public virtual void Init(PlayerBody playerBody) { }

	protected virtual void OnSkin(Transform playerTransform, Transform meshTransform) { }

	public void SetBodyHandler(string bodyCustomizationId) { }

	public virtual void Unskin() { }

}

