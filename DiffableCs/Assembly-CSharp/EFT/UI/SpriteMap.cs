namespace EFT.UI;

[DefaultMember("Item")]
public class SpriteMap
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Sprite <get_Item>b__3_1(Data item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string key; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <get_Item>b__0(Data item) { }

	}

	internal class Data
	{
		public string Id; //Field offset: 0x10
		public Sprite Sprite; //Field offset: 0x18

		public Data() { }

	}

	[SerializeField]
	private Data[] _sprites; //Field offset: 0x10

	[CanBeNull]
	public Sprite Item
	{
		 get { } //Length: 675
	}

	[CanBeNull]
	public Sprite Item
	{
		 get { } //Length: 63
	}

	public SpriteMap() { }

	public Sprite get_Item(Enum key) { }

	public Sprite get_Item(string key) { }

}

