//Type is in global namespace

public class GameObjectsToggleByDistance : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <CheckForChangeObjectEnabling>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GameObjectsToggleByDistance <>4__this; //Field offset: 0x20

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
		public <CheckForChangeObjectEnabling>d__14(int <>1__state) { }

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
	[Tooltip("Default state of game objects enable or disable")]
	private bool defaultObjectsState; //Field offset: 0x20
	[SerializeField]
	private List objectsForToggle; //Field offset: 0x28
	[SerializeField]
	private Transform pointForCalculation; //Field offset: 0x30
	[SerializeField]
	private float distanceForToggle; //Field offset: 0x38
	[SerializeField]
	private bool autoStart; //Field offset: 0x3C
	private Coroutine _checkForChangeObjectEnablingCoroutine; //Field offset: 0x40
	private float _sqrDistanceForToggle; //Field offset: 0x48
	private List _objectsForToggleTransforms; //Field offset: 0x50
	private WaitForEndOfFrame waitForEndOfFrame; //Field offset: 0x58

	public GameObjectsToggleByDistance() { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<CheckForChangeObjectEnabling>d__14))]
	private IEnumerator CheckForChangeObjectEnabling() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	public void ToggleCheck(bool toggle) { }

	private void ToggleCheckCoroutine(bool toggle) { }

}

