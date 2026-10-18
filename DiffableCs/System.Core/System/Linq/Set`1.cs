namespace System.Linq;

internal class Set`1
{
	public struct Slot
	{
		internal int hashCode; //Field offset: 0x0
		internal TElement value; //Field offset: 0x0
		internal int next; //Field offset: 0x0

	}

	private int[] buckets; //Field offset: 0x0
	private Slot[] slots; //Field offset: 0x0
	private int count; //Field offset: 0x0
	private int freeList; //Field offset: 0x0
	private IEqualityComparer comparer; //Field offset: 0x0

	public Set`1(IEqualityComparer comparer) { }

	public bool Add(TElement value) { }

	private bool Find(TElement value, bool add) { }

	internal int InternalGetHashCode(TElement value) { }

	public bool Remove(TElement value) { }

	private void Resize() { }

}

