namespace Sirenix.Utilities;

[DefaultMember("Item")]
public interface IImmutableList`1 : IImmutableList, IList, ICollection, IEnumerable, IList, ICollection, IEnumerable
{

	public T Item
	{
		 get { } //Length: 0
	}

	public T get_Item(int index) { }

}

