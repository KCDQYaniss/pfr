namespace ZLogger;

internal sealed class CombineMutator : IKeyNameMutator
{
	[CompilerGenerated]
	[Nullable(1)]
	private IKeyNameMutator <sliceSupported>P; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(1)]
	private IKeyNameMutator <tryMutateSupported>P; //Field offset: 0x18

	public override bool IsSupportSlice
	{
		 get { } //Length: 3
	}

	[NullableContext(1)]
	public CombineMutator(IKeyNameMutator sliceSupported, IKeyNameMutator tryMutateSupported) { }

	public override bool get_IsSupportSlice() { }

	public override ReadOnlySpan Slice(ReadOnlySpan source) { }

	public override bool TryMutate(ReadOnlySpan source, Span destination, out int written) { }

}

