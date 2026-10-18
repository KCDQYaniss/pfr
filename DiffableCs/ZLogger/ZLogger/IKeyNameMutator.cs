namespace ZLogger;

public interface IKeyNameMutator
{

	public bool IsSupportSlice
	{
		 get { } //Length: 0
	}

	public bool get_IsSupportSlice() { }

	public ReadOnlySpan Slice(ReadOnlySpan source) { }

	public bool TryMutate(ReadOnlySpan source, Span destination, out int written) { }

}

