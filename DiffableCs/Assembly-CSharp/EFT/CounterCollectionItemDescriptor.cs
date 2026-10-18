namespace EFT;

[GenerateBinarySerialization]
public sealed class CounterCollectionItemDescriptor
{
	[JsonProperty("Key")]
	public List Key; //Field offset: 0x10
	[JsonProperty("Value")]
	public long Value; //Field offset: 0x18

	public CounterCollectionItemDescriptor() { }

}

