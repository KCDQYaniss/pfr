namespace EFT.UI.Map;

[Obfuscation(Exclude = True)]
public sealed class PocketMap : SimplePocketMap
{
	[CompilerGenerated]
	private sealed class <AnimateScale>d__15 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float time; //Field offset: 0x20
		public PocketMap <>4__this; //Field offset: 0x28
		public float from; //Field offset: 0x30
		public float to; //Field offset: 0x34
		private float <timePass>5__2; //Field offset: 0x38
		private float <progress>5__3; //Field offset: 0x3C

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
		public <AnimateScale>d__15(int <>1__state) { }

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
	private Scrollbar _scrollbar; //Field offset: 0xD8
	[SerializeField]
	private Button _increaseScaleButton; //Field offset: 0xE0
	[SerializeField]
	private Button _decreaseScaleButton; //Field offset: 0xE8
	[Range(0, 1)]
	[SerializeField]
	private float _scaleStep; //Field offset: 0xF0
	[SerializeField]
	private float _inputScaleSensitivity; //Field offset: 0xF4
	[SerializeField]
	private float _animationSpeed; //Field offset: 0xF8
	private IEnumerator _scaleAnimation; //Field offset: 0x100

	private float MaxScale
	{
		private get { } //Length: 101
	}

	private float MinScale
	{
		private get { } //Length: 101
	}

	public PocketMap() { }

	[IteratorStateMachine(typeof(<AnimateScale>d__15))]
	private IEnumerator AnimateScale(float from, float to, float time) { }

	private void AnimateScaleStart(float from, float to, float time) { }

	private void AnimateScaleStop() { }

	protected virtual void Awake() { }

	private void DecreaseScale() { }

	private float get_MaxScale() { }

	private float get_MinScale() { }

	public Vector2 GetSize() { }

	public List GetTiles() { }

	private void IncreaseScale() { }

	private void SetScale(float scale) { }

	private void SetScaleFromBar(float value) { }

	public virtual void Show(MapComponent map) { }

	private void Update() { }

	private void UpdateScrollbar() { }

}

