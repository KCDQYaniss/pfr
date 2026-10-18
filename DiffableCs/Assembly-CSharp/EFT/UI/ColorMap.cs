namespace EFT.UI;

[DefaultMember("Item")]
public class ColorMap
{
	internal class Data
	{
		public string Id; //Field offset: 0x10
		public Color Item; //Field offset: 0x18

		public Data(string id, Color color) { }

	}

	[SerializeField]
	private Data[] _items; //Field offset: 0x10

	public Color Item
	{
		 get { } //Length: 213
	}

	public Color Item
	{
		 get { } //Length: 246
	}

	public ColorMap(Data[] items) { }

	public Color get_Item(Enum key) { }

	public Color get_Item(string key) { }

}

