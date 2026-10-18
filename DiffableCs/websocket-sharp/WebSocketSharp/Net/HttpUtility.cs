namespace WebSocketSharp.Net;

internal static class HttpUtility
{
	private static Dictionary _entities; //Field offset: 0x0
	private static char[] _hexChars; //Field offset: 0x8
	private static object _sync; //Field offset: 0x10

	private static HttpUtility() { }

	internal static Uri CreateRequestUrl(string requestUri, string host, bool websocketRequest, bool secure) { }

	internal static IPrincipal CreateUser(string response, AuthenticationSchemes scheme, string realm, string method, Func credentialsFinder) { }

	internal static Encoding GetEncoding(string contentType) { }

	private static Dictionary getEntities() { }

	private static int getNumber(char c) { }

	private static int getNumber(byte[] bytes, int offset, int count) { }

	private static int getNumber(string s, int offset, int count) { }

	public static void HtmlAttributeEncode(string s, TextWriter output) { }

	public static string HtmlAttributeEncode(string s) { }

	private static string htmlDecode(string s) { }

	public static void HtmlDecode(string s, TextWriter output) { }

	public static string HtmlDecode(string s) { }

	private static string htmlEncode(string s, bool minimal) { }

	public static void HtmlEncode(string s, TextWriter output) { }

	public static string HtmlEncode(string s) { }

	private static void initEntities() { }

	private static bool isAlphabet(char c) { }

	private static bool isNumeric(char c) { }

	private static bool isUnreserved(char c) { }

	private static bool isUnreservedInRfc2396(char c) { }

	private static bool isUnreservedInRfc3986(char c) { }

	internal static bool TryGetEncoding(string contentType, out Encoding result) { }

	public static string UrlDecode(string s, Encoding encoding) { }

	public static string UrlDecode(string s) { }

	public static string UrlDecode(byte[] bytes, Encoding encoding) { }

	public static string UrlDecode(byte[] bytes, int offset, int count, Encoding encoding) { }

	private static byte[] urlDecodeToBytes(byte[] bytes, int offset, int count) { }

	public static byte[] UrlDecodeToBytes(byte[] bytes, int offset, int count) { }

	public static byte[] UrlDecodeToBytes(string s) { }

	public static byte[] UrlDecodeToBytes(byte[] bytes) { }

	private static void urlEncode(byte b, Stream output) { }

	public static string UrlEncode(byte[] bytes) { }

	public static string UrlEncode(string s) { }

	public static string UrlEncode(string s, Encoding encoding) { }

	public static string UrlEncode(byte[] bytes, int offset, int count) { }

	private static byte[] urlEncodeToBytes(byte[] bytes, int offset, int count) { }

	public static byte[] UrlEncodeToBytes(string s) { }

	public static byte[] UrlEncodeToBytes(string s, Encoding encoding) { }

	public static byte[] UrlEncodeToBytes(byte[] bytes) { }

	public static byte[] UrlEncodeToBytes(byte[] bytes, int offset, int count) { }

}

