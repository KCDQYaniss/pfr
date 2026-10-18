namespace System.IO;

public static class Directory
{

	public static DirectoryInfo CreateDirectory(string path) { }

	public static void Delete(string path, bool recursive) { }

	public static IEnumerable EnumerateFileSystemEntries(string path, string searchPattern) { }

	public static IEnumerable EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	public static bool Exists(string path) { }

	public static string GetCurrentDirectory() { }

	public static string[] GetDirectories(string path) { }

	public static string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	public static string[] GetFiles(string path, string searchPattern) { }

	public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	public static string[] GetFileSystemEntries(string path, string searchPattern) { }

	public static string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	internal static string InsecureGetCurrentDirectory() { }

	internal static IEnumerable InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

	internal static string InternalGetDirectoryRoot(string path) { }

}

