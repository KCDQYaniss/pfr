namespace System.Collections.Generic;

[DefaultMember("Item")]
public interface IReadOnlyList`1 : IReadOnlyCollection, IEnumerable, IEnumerable
{

	public T Item
	{
		 get { } //Length: 0
	}

	public T get_Item(int index) { }

}

