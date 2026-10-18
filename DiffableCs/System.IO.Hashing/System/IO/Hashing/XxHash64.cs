namespace System.IO.Hashing;

public sealed class XxHash64 : NonCryptographicHashAlgorithm
{
	private struct State
	{
		private ulong _acc1; //Field offset: 0x0
		private ulong _acc2; //Field offset: 0x8
		private ulong _acc3; //Field offset: 0x10
		private ulong _acc4; //Field offset: 0x18
		private readonly ulong _smallAcc; //Field offset: 0x20
		private bool _hadFullStripe; //Field offset: 0x28

		internal State(ulong seed) { }

		private static ulong ApplyRound(ulong acc, ReadOnlySpan lane) { }

		private static ulong ApplyRound(ulong acc, ulong lane) { }

		internal void ProcessStripe(ReadOnlySpan source) { }

	}

	private readonly ulong _seed; //Field offset: 0x18
	private State _state; //Field offset: 0x20
	private byte[] _holdback; //Field offset: 0x50
	private long _length; //Field offset: 0x58

	public virtual void Append(ReadOnlySpan source) { }

	internal static ulong Avalanche(ulong hash) { }

	public virtual void Reset() { }

}

