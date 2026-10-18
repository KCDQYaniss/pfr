namespace Koenigz.PerfectCulling;

[DefaultMember("Item")]
public class FastArray`1
{
	public static readonly FastArray Empty; //Field offset: 0x0
	public int Count; //Field offset: 0x0
	public T[] Buffer; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 43
		 set { } //Length: 43
	}

	private static FastArray`1() { }

	public FastArray`1(int cap) { }

	public void Add(T val) { }

	public void Clear() { }

	public T[] Clone() { }

	public T Dequeue() { }

	public T get_Item(int idx) { }

	public void set_Item(int idx, T value) { }

}

