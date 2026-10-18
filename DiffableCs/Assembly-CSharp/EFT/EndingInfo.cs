namespace EFT;

[GenerateBinarySerialization]
public sealed class EndingInfo
{
	[GenerateBinarySerialization]
	internal sealed class AvailableEndings
	{
		[JsonProperty("regular")]
		public MongoID[] Regular; //Field offset: 0x10
		[JsonProperty("pve")]
		public MongoID[] Pve; //Field offset: 0x18

		public AvailableEndings() { }

	}

	[JsonProperty("current")]
	public Nullable Current; //Field offset: 0x10
	[JsonProperty("achieved")]
	public MongoID[] Achieved; //Field offset: 0x30
	[JsonProperty("available")]
	public AvailableEndings Available; //Field offset: 0x38
	[JsonProperty("display")]
	public Nullable Display; //Field offset: 0x40

	public EndingInfo() { }

}

