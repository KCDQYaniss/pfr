namespace EFT;

[Extension]
public static class NestableExtension
{

	[Extension]
	private static T Add(T t, ref T nested) { }

	[Extension]
	private static void Add(INestable t, ref T nested) { }

	[Extension]
	private static T AttachOrUpdate(ref T root, ref T child) { }

	[Extension]
	public static void AttachTo(T nested, ref Nullable t) { }

	[Extension]
	public static void AttachToOrUpdate(ref T child, ref Nullable root) { }

	[Extension]
	public static Nullable GetNested(T t) { }

}

