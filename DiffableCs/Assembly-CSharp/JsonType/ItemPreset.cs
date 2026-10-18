namespace JsonType;

public sealed class ItemPreset
{
	private const string DEFAULT_LABEL = "Stock build"; //Field offset: 0x0
	public string Id; //Field offset: 0x10
	public string Parent; //Field offset: 0x18
	public Item Item; //Field offset: 0x20
	public MongoID[] Children; //Field offset: 0x28
	public string Name; //Field offset: 0x30
	public bool ChangeWeaponName; //Field offset: 0x38
	public NodeType Type; //Field offset: 0x3C
	public string Encyclopedia; //Field offset: 0x40

	public string BuildName
	{
		 get { } //Length: 153
	}

	public bool SaveAsPreset
	{
		 get { } //Length: 21
	}

	public ItemPreset() { }

	public static ItemPreset FromItem(Item item) { }

	public string get_BuildName() { }

	public bool get_SaveAsPreset() { }

	public virtual string ToString() { }

}

