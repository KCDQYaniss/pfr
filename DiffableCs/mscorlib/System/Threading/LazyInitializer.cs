namespace System.Threading;

public static class LazyInitializer
{

	public static T EnsureInitialized(ref T target) { }

	public static T EnsureInitialized(ref T target, Func valueFactory) { }

	public static T EnsureInitialized(ref T target, ref bool initialized, ref object syncLock, Func valueFactory) { }

	public static T EnsureInitialized(ref T target, ref object syncLock, Func valueFactory) { }

	private static T EnsureInitializedCore(ref T target) { }

	private static T EnsureInitializedCore(ref T target, Func valueFactory) { }

	private static T EnsureInitializedCore(ref T target, ref bool initialized, ref object syncLock, Func valueFactory) { }

	private static T EnsureInitializedCore(ref T target, ref object syncLock, Func valueFactory) { }

	private static object EnsureLockInitialized(ref object syncLock) { }

}

