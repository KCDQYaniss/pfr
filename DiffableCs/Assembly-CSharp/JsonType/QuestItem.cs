namespace JsonType;

public class QuestItem
{
	public string _id; //Field offset: 0x10
	public string _tpl; //Field offset: 0x18
	[DefaultValue(null)]
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public string parentId; //Field offset: 0x20

	public QuestItem() { }

}

