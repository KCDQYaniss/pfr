namespace System.Buffers;

public abstract class ArrayPool`1
{
	[CompilerGenerated]
	private static readonly ArrayPool <Shared>k__BackingField; //Field offset: 0x0

	public static ArrayPool Shared
	{
		[CompilerGenerated]
		 get { } //Length: 153
	}

	private static ArrayPool`1() { }

	protected ArrayPool`1() { }

	[CompilerGenerated]
	public static ArrayPool get_Shared() { }

	public abstract T[] Rent(int minimumLength) { }

	public abstract void Return(T[] array, bool clearArray = false) { }

}

