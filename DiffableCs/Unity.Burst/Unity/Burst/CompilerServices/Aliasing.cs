namespace Unity.Burst.CompilerServices;

public static class Aliasing
{

	public static void ExpectAliased(void* a, void* b) { }

	public static void ExpectAliased(in A a, in B b) { }

	public static void ExpectAliased(void* a, in B b) { }

	public static void ExpectAliased(in A a, void* b) { }

	public static void ExpectNotAliased(void* a, void* b) { }

	public static void ExpectNotAliased(in A a, in B b) { }

	public static void ExpectNotAliased(void* a, in B b) { }

	public static void ExpectNotAliased(in A a, void* b) { }

}

