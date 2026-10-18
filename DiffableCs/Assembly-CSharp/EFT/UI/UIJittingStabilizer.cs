namespace EFT.UI;

public class UIJittingStabilizer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public Transform thisTransform; //Field offset: 0x10
		public Func <>9__0; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal bool <Start>b__0(RectTransform t) { }

	}

	[CompilerGenerated]
	private sealed class <AntiJitter>d__13 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UIJittingStabilizer <>4__this; //Field offset: 0x20

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
		public <AntiJitter>d__13(int <>1__state) { }

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

	internal class JittedUiElement
	{
		public GameObject GameObjectCached; //Field offset: 0x10
		public RectTransform RectTransformCached; //Field offset: 0x18
		public Vector2 LastFramePosition; //Field offset: 0x20
		public bool Stabilize; //Field offset: 0x28
		public bool IsJitted; //Field offset: 0x29

		public JittedUiElement(RectTransform rectTransform) { }

		public void UpdatePosition() { }

	}

	public static float MinDeltaDistance; //Field offset: 0x0
	public ScrollRect ScrollRectCached; //Field offset: 0x20
	public List ControlledElements; //Field offset: 0x28
	private MovementType _movementTypeCached; //Field offset: 0x30
	private bool _somethingJitted; //Field offset: 0x34
	private float _nextValidationTime; //Field offset: 0x38

	private static UIJittingStabilizer() { }

	public UIJittingStabilizer() { }

	[IteratorStateMachine(typeof(<AntiJitter>d__13))]
	private IEnumerator AntiJitter() { }

	private bool CanChangeMovementType() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnScrollValueChanged(Vector2 arg0) { }

	private bool ScrollsInRange() { }

	private void SetNextValidationTime() { }

	private void Start() { }

}

