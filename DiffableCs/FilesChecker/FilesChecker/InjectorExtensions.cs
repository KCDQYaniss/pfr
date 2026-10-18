namespace FilesChecker;

[Extension]
public static class InjectorExtensions
{

	[Extension]
	public static void ReadExactly(FileStream fs, byte[] buffer, int count) { }

	[Extension]
	public static bool SequenceEqual(byte[] a, byte[] b, int count) { }

}

