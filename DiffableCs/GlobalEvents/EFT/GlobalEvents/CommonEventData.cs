namespace EFT.GlobalEvents;

[Obfuscation(Exclude = True)]
public class CommonEventData : ISyncDataContainer, IDataContainer, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public Type type; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal IEvent <Add>b__0() { }

	}

	private const int POOL_SIZE = 20; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsUpdated>k__BackingField; //Field offset: 0x10
	private readonly Dictionary _events; //Field offset: 0x18
	[JsonIgnore]
	private readonly Dictionary _eventsToApply; //Field offset: 0x20
	[JsonIgnore]
	private readonly Dictionary _pools; //Field offset: 0x28
	[JsonIgnore]
	private readonly Dictionary _serializeSentEventMap; //Field offset: 0x30
	[JsonIgnore]
	private readonly Dictionary _deserializeSentEventMap; //Field offset: 0x38
	[JsonIgnore]
	private readonly Dictionary _nameEventMap; //Field offset: 0x40
	private int _nextEventID; //Field offset: 0x48

	private Type Incoming
	{
		private get { } //Length: 175
	}

	public override bool IsUpdated
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private Type Outgoing
	{
		private get { } //Length: 175
	}

	public CommonEventData() { }

	private void Add() { }

	private void Add(Type type) { }

	public void Apply() { }

	public void Clear() { }

	public T Create() { }

	private IEvent Create(Type type) { }

	public override void Deserialize(ref IBitReaderStream readerStream, int sourcePlayerRaideId) { }

	public void Dispatch(Dictionary eventData) { }

	public void Dispatch(Type type, IEvent eventObject) { }

	public void Dispatch(T eventObject) { }

	public override void Dispose() { }

	private Type get_Incoming() { }

	[CompilerGenerated]
	public override bool get_IsUpdated() { }

	private Type get_Outgoing() { }

	public override void Serialize(ref IBitWriterStream writerStream, bool isFullUpdate = false) { }

	[CompilerGenerated]
	public override void set_IsUpdated(bool value) { }

	public bool TryGet(out List eventList) { }

	public bool TryGet(string eventName, out List eventList) { }

	private bool TryGet(Type type, out List eventList) { }

}

