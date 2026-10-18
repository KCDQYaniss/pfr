namespace System.Linq;

internal class GroupedEnumerable`3 : IEnumerable, IEnumerable
{
	private IEnumerable source; //Field offset: 0x0
	private Func keySelector; //Field offset: 0x0
	private Func elementSelector; //Field offset: 0x0
	private IEqualityComparer comparer; //Field offset: 0x0

	public GroupedEnumerable`3(IEnumerable source, Func keySelector, Func elementSelector, IEqualityComparer comparer) { }

	public override IEnumerator GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

