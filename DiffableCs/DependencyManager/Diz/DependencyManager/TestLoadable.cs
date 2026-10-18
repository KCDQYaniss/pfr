namespace Diz.DependencyManager;

public class TestLoadable : MonoBehaviour, ILoadable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <get_DependencyKeys>b__11_0(TestLoadable x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public TestLoadable <>4__this; //Field offset: 0x10
		public Button tokenButton; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal void <AddToken>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <Loading>d__23 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public TestLoadable <>4__this; //Field offset: 0x20

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
		public <Loading>d__23(int <>1__state) { }

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
	private Button _loadButton; //Field offset: 0x20
	[SerializeField]
	private Image _mainImage; //Field offset: 0x28
	[SerializeField]
	private Text _refCountLabel; //Field offset: 0x30
	[SerializeField]
	private Transform _tokensContainer; //Field offset: 0x38
	[SerializeField]
	private Button _tokenTemplate; //Field offset: 0x40
	private BindableState _loadState; //Field offset: 0x48
	public TestLoadable[] Dependencies; //Field offset: 0x50
	public Action OnClicked; //Field offset: 0x58
	public Action OnRightClicked; //Field offset: 0x60
	private readonly Dictionary _tokens; //Field offset: 0x68

	public override IEnumerable DependencyKeys
	{
		 get { } //Length: 354
	}

	public override string Key
	{
		 get { } //Length: 7
	}

	public override BindableState LoadState
	{
		 get { } //Length: 5
	}

	public override float Progress
	{
		 get { } //Length: 4
	}

	public TestLoadable() { }

	[CompilerGenerated]
	private void <Awake>b__18_0() { }

	public void AddToken(Token token) { }

	private void Awake() { }

	public override IEnumerable get_DependencyKeys() { }

	public override string get_Key() { }

	public override BindableState get_LoadState() { }

	public override float get_Progress() { }

	public override void Load() { }

	public IEnumerator Load(IProgress progress, CancellationToken ct) { }

	[IteratorStateMachine(typeof(<Loading>d__23))]
	public IEnumerator Loading() { }

	private void SetColor() { }

	public void SetRefCount(int rc) { }

	public override void Unload() { }

}

