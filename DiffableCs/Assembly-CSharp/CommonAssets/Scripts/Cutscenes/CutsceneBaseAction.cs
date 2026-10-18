namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneBaseAction : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <RegisterCoroutine>d__5 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CutsceneBaseAction <>4__this; //Field offset: 0x20
		private GameWorld <gameWorld>5__2; //Field offset: 0x28

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
		public <RegisterCoroutine>d__5(int <>1__state) { }

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

	public string id; //Field offset: 0x20
	[HideInInspector]
	public string cutsceneId; //Field offset: 0x28
	public List objects; //Field offset: 0x30
	[HideInInspector]
	public List playersId; //Field offset: 0x38

	public CutsceneBaseAction() { }

	public override void Deinit() { }

	public override void Init() { }

	public override void OnStart() { }

	[IteratorStateMachine(typeof(<RegisterCoroutine>d__5))]
	private IEnumerator RegisterCoroutine() { }

	private void Start() { }

}

