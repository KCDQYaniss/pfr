namespace Mono.Security;

internal class Uri
{
	private struct UriScheme
	{
		public string scheme; //Field offset: 0x0
		public string delimiter; //Field offset: 0x8
		public int defaultPort; //Field offset: 0x10

		public UriScheme(string s, string d, int p) { }

	}

	private static readonly string hexUpperChars; //Field offset: 0x0
	public static readonly string SchemeDelimiter; //Field offset: 0x8
	public static readonly string UriSchemeFile; //Field offset: 0x10
	public static readonly string UriSchemeFtp; //Field offset: 0x18
	public static readonly string UriSchemeGopher; //Field offset: 0x20
	public static readonly string UriSchemeHttp; //Field offset: 0x28
	public static readonly string UriSchemeHttps; //Field offset: 0x30
	public static readonly string UriSchemeMailto; //Field offset: 0x38
	public static readonly string UriSchemeNews; //Field offset: 0x40
	public static readonly string UriSchemeNntp; //Field offset: 0x48
	private static UriScheme[] schemes; //Field offset: 0x50
	private bool isUnixFilePath; //Field offset: 0x10
	private string source; //Field offset: 0x18
	private string scheme; //Field offset: 0x20
	private string host; //Field offset: 0x28
	private int port; //Field offset: 0x30
	private string path; //Field offset: 0x38
	private string query; //Field offset: 0x40
	private string fragment; //Field offset: 0x48
	private string userinfo; //Field offset: 0x50
	private bool isUnc; //Field offset: 0x58
	private bool isOpaquePart; //Field offset: 0x59
	private bool userEscaped; //Field offset: 0x5A
	private string cachedToString; //Field offset: 0x60
	private string cachedLocalPath; //Field offset: 0x68
	private int cachedHashCode; //Field offset: 0x70
	private bool reduce; //Field offset: 0x74

	public string AbsolutePath
	{
		 get { } //Length: 5
	}

	public bool IsFile
	{
		 get { } //Length: 155
	}

	public bool IsUnc
	{
		 get { } //Length: 5
	}

	public string LocalPath
	{
		 get { } //Length: 908
	}

	private static Uri() { }

	public Uri(string uriString) { }

	public Uri(string uriString, bool dontEscape) { }

	public virtual bool Equals(object comparant) { }

	protected static string EscapeString(string str) { }

	internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets) { }

	public static int FromHex(char digit) { }

	public string get_AbsolutePath() { }

	public bool get_IsFile() { }

	public bool get_IsUnc() { }

	public string get_LocalPath() { }

	internal static int GetDefaultPort(string scheme) { }

	public virtual int GetHashCode() { }

	public string GetLeftPart(UriPartial part) { }

	private string GetOpaqueWiseSchemeDelimiter() { }

	internal static string GetSchemeDelimiter(string scheme) { }

	public static string HexEscape(char character) { }

	public static char HexUnescape(string pattern, ref int index) { }

	public static bool IsHexDigit(char digit) { }

	public static bool IsHexEncoding(string pattern, int index) { }

	private static bool IsPredefinedScheme(string scheme) { }

	private void Parse(string uriString) { }

	protected void Parse() { }

	private void ParseAsUnixAbsoluteFilePath(string uriString) { }

	private void ParseAsWindowsAbsoluteFilePath(string uriString) { }

	private void ParseAsWindowsUNC(string uriString) { }

	private static string Reduce(string path) { }

	public virtual string ToString() { }

	internal string Unescape(string str, bool excludeSharp) { }

	protected string Unescape(string str) { }

}

