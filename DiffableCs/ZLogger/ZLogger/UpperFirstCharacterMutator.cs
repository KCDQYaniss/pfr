namespace ZLogger;

internal sealed class UpperFirstCharacterMutator : IKeyNameMutator
{

	public override bool IsSupportSlice
	{
		 get { } //Length: 3
	}

	public UpperFirstCharacterMutator() { }

	public override bool get_IsSupportSlice() { }

	public override ReadOnlySpan Slice(ReadOnlySpan source) { }

	public override bool TryMutate(ReadOnlySpan source, Span destination, out int written) { }

}

