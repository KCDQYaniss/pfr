namespace Interpolation;

[DefaultMember("Item")]
public class DynamicArray`1
{
	private T[] array; //Field offset: 0x0
	private readonly int extendSize; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 181
		 set { } //Length: 370
	}

	public int Length
	{
		 get { } //Length: 26
	}

	public DynamicArray`1(int size, int extendSize) { }

	private int CalculateNextSize(int size, int targetSize, int extendSize) { }

	private void CheckSize(int targetSize) { }

	public T get_Item(int i) { }

	public int get_Length() { }

	public void set_Item(int i, T value) { }

}

