namespace MultiFlare;

[HelpURL("https://eodproject.atlassian.net/wiki/spaces/FRONT/pages/1254981646/Unity.#Flare")]
public class FlareSceneSettings : MonoBehaviour
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__OnOpticEnabled; //Field offset: 0x0
		public static Action <1>__OnOpticDisabled; //Field offset: 0x8

	}

	[CompilerGenerated]
	private sealed class <Start>d__6 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public FlareSceneSettings <>4__this; //Field offset: 0x20
		private WaitForSeconds <waiter>5__2; //Field offset: 0x28

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
		public <Start>d__6(int <>1__state) { }

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

	private FlareBlindnessController _blindnessController; //Field offset: 0x20
	[SerializeField]
	private FlareSettings _settings; //Field offset: 0x28
	[SerializeField]
	private float _waiter; //Field offset: 0x30

	public FlareSettings Settings
	{
		 get { } //Length: 5
	}

	public FlareSceneSettings() { }

	private void Awake() { }

	public FlareSettings get_Settings() { }

	private void OnBlindnessProtectionChanged(float blindnessProtection) { }

	private void OnDestroy() { }

	private static void OnOpticDisabled() { }

	private static void OnOpticEnabled() { }

	[IteratorStateMachine(typeof(<Start>d__6))]
	private IEnumerator Start() { }

	private void Update() { }

}

