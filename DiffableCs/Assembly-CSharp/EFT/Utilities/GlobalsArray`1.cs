namespace EFT.Utilities;

[DefaultMember("Item")]
[JsonConverter(typeof(GlobalsArrayConverter))]
public sealed class GlobalsArray`1 : IGlobalsArray, IReadOnlyList, IEnumerable, IEnumerable, IReadOnlyCollection
{
	private readonly List _values; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 26
	}

	public override T Item
	{
		 get { } //Length: 63
	}

	public int Length
	{
		 get { } //Length: 26
	}

	public GlobalsArray`1() { }

	private override void EFT.Utilities.IGlobalsArray.Deserialize(JArray jArray) { }

	public override int get_Count() { }

	public override T get_Item(int index) { }

	public int get_Length() { }

	public override IEnumerator GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

