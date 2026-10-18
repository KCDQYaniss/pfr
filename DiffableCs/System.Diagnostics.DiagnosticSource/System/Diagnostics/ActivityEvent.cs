namespace System.Diagnostics;

[IsReadOnly]
[Nullable(0)]
[NullableContext(1)]
public struct ActivityEvent
{
	private static readonly IEnumerable s_emptyTags; //Field offset: 0x0
	private readonly TagsLinkedList _tags; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly DateTimeOffset <Timestamp>k__BackingField; //Field offset: 0x10

	private static ActivityEvent() { }

}

