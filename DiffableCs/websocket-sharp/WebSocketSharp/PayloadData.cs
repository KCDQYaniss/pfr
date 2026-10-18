namespace WebSocketSharp;

internal class PayloadData : IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__25 : IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private byte <>2__current; //Field offset: 0x14
		public PayloadData <>4__this; //Field offset: 0x18
		private byte[] <>s__1; //Field offset: 0x20
		private int <>s__2; //Field offset: 0x28
		private byte <b>5__3; //Field offset: 0x2C

		private override byte System.Collections.Generic.IEnumerator<System.Byte>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 73
		}

		[DebuggerHidden]
		public <GetEnumerator>d__25(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override byte System.Collections.Generic.IEnumerator<System.Byte>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public static readonly PayloadData Empty; //Field offset: 0x0
	public static readonly ulong MaxLength; //Field offset: 0x8
	private byte[] _data; //Field offset: 0x10
	private long _extDataLength; //Field offset: 0x18
	private long _length; //Field offset: 0x20

	public byte[] ApplicationData
	{
		 get { } //Length: 172
	}

	internal ushort Code
	{
		internal get { } //Length: 520
	}

	public byte[] ExtensionData
	{
		 get { } //Length: 196
	}

	internal long ExtensionDataLength
	{
		internal get { } //Length: 7
		internal set { } //Length: 5
	}

	internal bool HasReservedCode
	{
		internal get { } //Length: 136
	}

	public ulong Length
	{
		 get { } //Length: 7
	}

	internal string Reason
	{
		internal get { } //Length: 209
	}

	private static PayloadData() { }

	internal PayloadData(byte[] data) { }

	internal PayloadData(byte[] data, long length) { }

	internal PayloadData(ushort code, string reason) { }

	public byte[] get_ApplicationData() { }

	internal ushort get_Code() { }

	public byte[] get_ExtensionData() { }

	internal long get_ExtensionDataLength() { }

	internal bool get_HasReservedCode() { }

	public ulong get_Length() { }

	internal string get_Reason() { }

	public override IEnumerator GetEnumerator() { }

	internal void Mask(byte[] key) { }

	internal void set_ExtensionDataLength(long value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public byte[] ToArray() { }

	public virtual string ToString() { }

}

