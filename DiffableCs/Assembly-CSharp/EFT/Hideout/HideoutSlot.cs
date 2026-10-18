namespace EFT.Hideout;

public sealed class HideoutSlot
{
	[JsonProperty("item")]
	private FlatItem[] _flatItems; //Field offset: 0x10
	[JsonIgnore]
	public Item Item; //Field offset: 0x18

	public HideoutSlot() { }

	[OnDeserialized]
	private void OnJSONDeserialize(StreamingContext context) { }

}

