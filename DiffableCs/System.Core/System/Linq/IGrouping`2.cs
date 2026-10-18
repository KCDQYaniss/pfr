namespace System.Linq;

public interface IGrouping`2 : IEnumerable, IEnumerable
{

	public TKey Key
	{
		 get { } //Length: 0
	}

	public TKey get_Key() { }

}

