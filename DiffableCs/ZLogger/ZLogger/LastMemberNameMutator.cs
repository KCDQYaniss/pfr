namespace ZLogger;

internal sealed class LastMemberNameMutator : IKeyNameMutator
{

	public override bool IsSupportSlice
	{
		 get { } //Length: 3
	}

	public LastMemberNameMutator() { }

	public override bool get_IsSupportSlice() { }

	public override ReadOnlySpan Slice(ReadOnlySpan source) { }

	public override bool TryMutate(ReadOnlySpan source, Span destination, out int written) { }

}

