namespace System.IO;

public static class File
{

	public static StreamWriter AppendText(string path) { }

	public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }

	public static FileStream Create(string path) { }

	public static FileStream Create(string path, int bufferSize) { }

	public static StreamWriter CreateText(string path) { }

	public static void Delete(string path) { }

	public static bool Exists(string path) { }

	public static FileAttributes GetAttributes(string path) { }

	public static DateTime GetCreationTime(string path) { }

	public static DateTime GetLastWriteTime(string path) { }

	private static string[] InternalReadAllLines(string path, Encoding encoding) { }

	private static string InternalReadAllText(string path, Encoding encoding) { }

	private static void InternalWriteAllBytes(string path, byte[] bytes) { }

	private static void InternalWriteAllLines(TextWriter writer, IEnumerable contents) { }

	public static void Move(string sourceFileName, string destFileName) { }

	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) { }

	public static FileStream Open(string path, FileMode mode) { }

	public static FileStream OpenRead(string path) { }

	public static StreamReader OpenText(string path) { }

	public static FileStream OpenWrite(string path) { }

	public static byte[] ReadAllBytes(string path) { }

	private static byte[] ReadAllBytesUnknownLength(FileStream fs) { }

	public static string[] ReadAllLines(string path) { }

	public static string ReadAllText(string path) { }

	public static void WriteAllBytes(string path, byte[] bytes) { }

	public static void WriteAllLines(string path, string[] contents) { }

	public static void WriteAllLines(string path, IEnumerable contents) { }

	public static void WriteAllText(string path, string contents) { }

}

