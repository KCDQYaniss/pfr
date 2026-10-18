namespace System.Text.Encodings.Web;

[Nullable(0)]
[NullableContext(1)]
public class TextEncoderSettings
{
	[CompilerGenerated]
	private sealed class <GetAllowedCodePoints>d__14 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private int <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public TextEncoderSettings <>4__this; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <GetAllowedCodePoints>d__14(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[DebuggerHidden]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private AllowedBmpCodePointsBitmap _allowedCodePointsBitmap; //Field offset: 0x10

	public TextEncoderSettings(UnicodeRange[] allowedRanges) { }

	public override void AllowRange(UnicodeRange range) { }

	public override void AllowRanges(UnicodeRange[] ranges) { }

	[IteratorStateMachine(typeof(<GetAllowedCodePoints>d__14))]
	public override IEnumerable GetAllowedCodePoints() { }

	internal AllowedBmpCodePointsBitmap GetAllowedCodePointsBitmap() { }

}

