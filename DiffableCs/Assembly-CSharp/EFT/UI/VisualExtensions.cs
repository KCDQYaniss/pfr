namespace EFT.UI;

[Extension]
public static class VisualExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public CanvasGroup group; //Field offset: 0x10
		public bool status; //Field offset: 0x18
		public Action callback; //Field offset: 0x20

		public <>c__DisplayClass2_0() { }

		internal void <SoftChange>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <Co_ChangeCanvasGroupAlpha>d__3 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public CanvasGroup group; //Field offset: 0x20
		public Action callback; //Field offset: 0x28
		public float startingAlpha; //Field offset: 0x30
		public float step; //Field offset: 0x34
		public float to; //Field offset: 0x38

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
		public <Co_ChangeCanvasGroupAlpha>d__3(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <Co_ChangeColorTemporary>d__5 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Graphic text; //Field offset: 0x20
		public Color from; //Field offset: 0x28
		public Color to; //Field offset: 0x38
		public float duration; //Field offset: 0x48
		public Action callback; //Field offset: 0x50
		private float <time>5__2; //Field offset: 0x58

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
		public <Co_ChangeColorTemporary>d__5(int <>1__state) { }

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

	private sealed class CanvasGroupBlocker : IDisposable
	{
		private CanvasGroup _canvasGroup; //Field offset: 0x10
		private readonly float _alpha; //Field offset: 0x18
		private readonly bool _blocksRaycasts; //Field offset: 0x1C
		private readonly bool _interactable; //Field offset: 0x1D

		public CanvasGroupBlocker(CanvasGroup canvasGroup, Nullable alpha = null) { }

		private override void System.IDisposable.Dispose() { }

	}


	[Extension]
	public static IDisposable Block(CanvasGroup canvasGroup, Nullable alpha = null) { }

	[Extension]
	public static void ChangeImageAlpha(Image image, float alpha) { }

	[Extension]
	[IteratorStateMachine(typeof(<Co_ChangeCanvasGroupAlpha>d__3))]
	private static IEnumerator Co_ChangeCanvasGroupAlpha(CanvasGroup group, float startingAlpha, float to, float step, Action callback = null) { }

	[Extension]
	[IteratorStateMachine(typeof(<Co_ChangeColorTemporary>d__5))]
	public static IEnumerator Co_ChangeColorTemporary(Graphic text, float duration, Color from, Color to, Action callback = null) { }

	[Extension]
	public static void SoftChange(CanvasGroup group, bool status, ref Coroutine coroutine, Action callback = null, float speed = 4) { }

}

