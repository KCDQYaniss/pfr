namespace ZLogger;

internal sealed class LowerFirstCharacterMutator : IKeyNameMutator
{

	public override bool IsSupportSlice
	{
		 get { } //Length: 3
	}

	public LowerFirstCharacterMutator() { }

	public override bool get_IsSupportSlice() { }

	public override ReadOnlySpan Slice(ReadOnlySpan source) { }

	public override bool TryMutate(ReadOnlySpan source, Span destination, out int written) { }

}

