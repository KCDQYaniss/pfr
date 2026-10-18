namespace EFT;

[GenerateBinarySerialization]
public sealed class CounterCollectionDescriptor
{
	[JsonProperty("Items", NullValueHandling = NullValueHandling::Ignore (1))]
	public List Items; //Field offset: 0x10

	public CounterCollectionDescriptor() { }

	public CounterCollectionDescriptor(CountersCollection countersCollection) { }

}

