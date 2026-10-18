namespace System.Linq;

public interface IOrderedEnumerable`1 : IEnumerable, IEnumerable
{

	public IOrderedEnumerable CreateOrderedEnumerable(Func keySelector, IComparer comparer, bool descending) { }

}

