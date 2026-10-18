//Type is in global namespace

[Extension]
public static class NativeArrayExtensions
{

	public static NativeArray Create2D(int l0, int l1, Allocator allocator, NativeArrayOptions options = 1) { }

	public static T[] Create2DArray(int l0, int l1) { }

	[Extension]
	public static bool DisposeIfCreated(NativeArray self) { }

	[Extension]
	public static T Get2D(NativeArray self, int l0, int index0, int index1) { }

	[Extension]
	public static T Get2D(T[] self, int l0, int index0, int index1) { }

	[Extension]
	public static void Set2D(NativeArray self, int l0, int index0, int index1, T value) { }

	[Extension]
	public static void Set2D(T[] self, int l0, int index0, int index1, T value) { }

}

