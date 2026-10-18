namespace System.Collections.Generic;

public interface IReadOnlyCollection`1 : IEnumerable, IEnumerable
{

	public int Count
	{
		 get { } //Length: 0
	}

	public int get_Count() { }

}

