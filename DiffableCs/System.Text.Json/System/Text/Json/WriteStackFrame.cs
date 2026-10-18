namespace System.Text.Json;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
internal struct WriteStackFrame
{
	public IEnumerator CollectionEnumerator; //Field offset: 0x0
	public IAsyncDisposable AsyncDisposable; //Field offset: 0x8
	public bool AsyncEnumeratorIsPendingCompletion; //Field offset: 0x10
	public JsonPropertyInfo JsonPropertyInfo; //Field offset: 0x18
	public bool IsWritingExtensionDataProperty; //Field offset: 0x20
	public JsonTypeInfo JsonTypeInfo; //Field offset: 0x28
	public int OriginalDepth; //Field offset: 0x30
	public bool ProcessedStartToken; //Field offset: 0x34
	public bool ProcessedEndToken; //Field offset: 0x35
	public StackFramePropertyState PropertyState; //Field offset: 0x36
	public int EnumeratorIndex; //Field offset: 0x38
	public string JsonPropertyNameAsString; //Field offset: 0x40
	public MetadataPropertyName MetadataPropertyName; //Field offset: 0x48
	public PolymorphicSerializationState PolymorphicSerializationState; //Field offset: 0x49
	public JsonTypeInfo PolymorphicTypeInfo; //Field offset: 0x50
	public Nullable NumberHandling; //Field offset: 0x58
	public bool IsPushedReferenceForCycleDetection; //Field offset: 0x60

	public void EndCollectionElement() { }

	public void EndDictionaryEntry() { }

	public void EndProperty() { }

	public void ExitPolymorphicConverter(bool success) { }

	[IsReadOnly]
	public JsonTypeInfo GetNestedJsonTypeInfo() { }

	public JsonTypeInfo InitializePolymorphicReEntry(Type runtimeType, JsonSerializerOptions options) { }

	public JsonConverter InitializePolymorphicReEntry(JsonTypeInfo derivedJsonTypeInfo) { }

	public JsonConverter ResumePolymorphicReEntry() { }

}

