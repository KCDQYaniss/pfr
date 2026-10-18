namespace Comfort.Common;

public interface IOperation`1 : IOperation, IEnumerator
{

	public T Result
	{
		 get { } //Length: 0
	}

	public T get_Result() { }

}

