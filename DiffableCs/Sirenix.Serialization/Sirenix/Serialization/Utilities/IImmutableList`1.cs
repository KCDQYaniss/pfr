namespace Sirenix.Serialization.Utilities;

[DefaultMember("Item")]
internal interface IImmutableList`1 : IImmutableList, IList, ICollection, IEnumerable, IList, ICollection, IEnumerable
{

	public T Item
	{
		 get { } //Length: 0
	}

	public T get_Item(int index) { }

}

