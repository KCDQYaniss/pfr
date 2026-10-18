namespace WebSocketSharp;

[Extension]
public static class Ext
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public int end; //Field offset: 0x10
		public string[] values; //Field offset: 0x18
		public int len; //Field offset: 0x20
		public Func seek; //Field offset: 0x28

		public <>c__DisplayClass17_0() { }

		internal bool <ContainsTwice>b__0(int idx) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Stream sourceStream; //Field offset: 0x10
		public Action completed; //Field offset: 0x18
		public Stream destinationStream; //Field offset: 0x20
		public byte[] buff; //Field offset: 0x28
		public int bufferLength; //Field offset: 0x30
		public AsyncCallback callback; //Field offset: 0x38
		public Action error; //Field offset: 0x40

		public <>c__DisplayClass21_0() { }

		internal void <CopyToAsync>b__0(IAsyncResult ar) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public Stream stream; //Field offset: 0x10
		public int retry; //Field offset: 0x18
		public byte[] ret; //Field offset: 0x20
		public int offset; //Field offset: 0x28
		public int length; //Field offset: 0x2C
		public AsyncCallback callback; //Field offset: 0x30
		public Action completed; //Field offset: 0x38
		public Action error; //Field offset: 0x40

		public <>c__DisplayClass54_0() { }

		internal void <ReadBytesAsync>b__0(IAsyncResult ar) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public int bufferLength; //Field offset: 0x10
		public Stream stream; //Field offset: 0x18
		public byte[] buff; //Field offset: 0x20
		public int retry; //Field offset: 0x28
		public Action read; //Field offset: 0x30
		public Action completed; //Field offset: 0x38
		public MemoryStream dest; //Field offset: 0x40
		public Action error; //Field offset: 0x48

		public <>c__DisplayClass55_0() { }

		internal void <ReadBytesAsync>b__0(long len) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_1
	{
		public long len; //Field offset: 0x10
		public <>c__DisplayClass55_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass55_1() { }

		internal void <ReadBytesAsync>b__1(IAsyncResult ar) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass81_0
	{
		public Action completed; //Field offset: 0x10
		public MemoryStream src; //Field offset: 0x18
		public Action error; //Field offset: 0x20

		public <>c__DisplayClass81_0() { }

		internal void <WriteBytesAsync>b__0() { }

		internal void <WriteBytesAsync>b__1(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <SplitHeaderValue>d__57 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private string value; //Field offset: 0x28
		public string <>3__value; //Field offset: 0x30
		private char[] separators; //Field offset: 0x38
		public char[] <>3__separators; //Field offset: 0x40
		private int <len>5__1; //Field offset: 0x48
		private int <end>5__2; //Field offset: 0x4C
		private StringBuilder <buff>5__3; //Field offset: 0x50
		private bool <escaped>5__4; //Field offset: 0x58
		private bool <quoted>5__5; //Field offset: 0x59
		private int <i>5__6; //Field offset: 0x5C
		private char <c>5__7; //Field offset: 0x60

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SplitHeaderValue>d__57(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <TrimEach>d__68 : IEnumerable, IEnumerable, IEnumerator, IDisposable, IEnumerator
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerable source; //Field offset: 0x28
		public IEnumerable <>3__source; //Field offset: 0x30
		private IEnumerator <>s__1; //Field offset: 0x38
		private string <elm>5__2; //Field offset: 0x40

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <TrimEach>d__68(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly byte[] _last; //Field offset: 0x0
	private const string _tspecials = "()<>@,;:\"/[]?={} 	"; //Field offset: 0x0
	private static readonly int _maxRetry; //Field offset: 0x8

	private static Ext() { }

	[Extension]
	internal static byte[] Append(ushort code, string reason) { }

	[Extension]
	private static byte[] compress(byte[] data) { }

	[Extension]
	private static MemoryStream compress(Stream stream) { }

	[Extension]
	internal static byte[] Compress(byte[] data, CompressionMethod method) { }

	[Extension]
	internal static Stream Compress(Stream stream, CompressionMethod method) { }

	[Extension]
	private static byte[] compressToArray(Stream stream) { }

	[Extension]
	internal static bool Contains(string value, char[] anyOf) { }

	[Extension]
	internal static bool Contains(NameValueCollection collection, string name) { }

	[Extension]
	internal static bool Contains(NameValueCollection collection, string name, string value, StringComparison comparisonTypeForValue) { }

	[Extension]
	internal static bool Contains(IEnumerable source, Func condition) { }

	[Extension]
	internal static bool ContainsTwice(string[] values) { }

	[Extension]
	internal static T[] Copy(T[] sourceArray, long length) { }

	[Extension]
	internal static T[] Copy(T[] sourceArray, int length) { }

	[Extension]
	internal static void CopyTo(Stream sourceStream, Stream destinationStream, int bufferLength) { }

	[Extension]
	internal static void CopyToAsync(Stream sourceStream, Stream destinationStream, int bufferLength, Action completed, Action error) { }

	[Extension]
	private static byte[] decompress(byte[] data) { }

	[Extension]
	private static MemoryStream decompress(Stream stream) { }

	[Extension]
	internal static byte[] Decompress(byte[] data, CompressionMethod method) { }

	[Extension]
	internal static Stream Decompress(Stream stream, CompressionMethod method) { }

	[Extension]
	private static byte[] decompressToArray(Stream stream) { }

	[Extension]
	internal static byte[] DecompressToArray(Stream stream, CompressionMethod method) { }

	[Extension]
	internal static void Emit(EventHandler eventHandler, object sender, EventArgs e) { }

	[Extension]
	internal static void Emit(EventHandler eventHandler, object sender, TEventArgs e) { }

	[Extension]
	internal static string GetAbsolutePath(Uri uri) { }

	[Extension]
	internal static CookieCollection GetCookies(NameValueCollection headers, bool response) { }

	[Extension]
	public static string GetDescription(HttpStatusCode code) { }

	[Extension]
	internal static string GetDnsSafeHost(Uri uri, bool bracketIPv6) { }

	[Extension]
	internal static string GetMessage(CloseStatusCode code) { }

	[Extension]
	internal static string GetName(string nameAndValue, char separator) { }

	[Extension]
	public static string GetStatusDescription(int code) { }

	[Extension]
	internal static string GetUTF8DecodedString(byte[] bytes) { }

	[Extension]
	internal static byte[] GetUTF8EncodedBytes(string s) { }

	[Extension]
	internal static string GetValue(string nameAndValue, char separator) { }

	[Extension]
	internal static string GetValue(string nameAndValue, char separator, bool unquote) { }

	[Extension]
	public static bool IsCloseStatusCode(ushort value) { }

	[Extension]
	internal static bool IsCompressionExtension(string value, CompressionMethod method) { }

	[Extension]
	internal static bool IsControl(byte opcode) { }

	[Extension]
	internal static bool IsControl(Opcode opcode) { }

	[Extension]
	internal static bool IsData(byte opcode) { }

	[Extension]
	internal static bool IsData(Opcode opcode) { }

	[Extension]
	public static bool IsEnclosedIn(string value, char c) { }

	[Extension]
	internal static bool IsEqualTo(int value, char c, Action beforeComparing) { }

	[Extension]
	public static bool IsHostOrder(ByteOrder order) { }

	[Extension]
	internal static bool IsHttpMethod(string value) { }

	[Extension]
	public static bool IsLocal(IPAddress address) { }

	[Extension]
	public static bool IsNullOrEmpty(string value) { }

	[Extension]
	internal static bool IsPortNumber(int value) { }

	[Extension]
	private static bool isPredefinedScheme(string value) { }

	[Extension]
	internal static bool IsReserved(CloseStatusCode code) { }

	[Extension]
	internal static bool IsReserved(ushort code) { }

	[Extension]
	internal static bool IsSupported(byte opcode) { }

	[Extension]
	internal static bool IsText(string value) { }

	[Extension]
	internal static bool IsToken(string value) { }

	[Extension]
	internal static bool KeepsAlive(NameValueCollection headers, Version version) { }

	[Extension]
	internal static bool MaybeUri(string value) { }

	[Extension]
	internal static string Quote(string value) { }

	[Extension]
	internal static byte[] ReadBytes(Stream stream, int length) { }

	[Extension]
	internal static byte[] ReadBytes(Stream stream, long length, int bufferLength) { }

	[Extension]
	internal static void ReadBytesAsync(Stream stream, int length, Action completed, Action error) { }

	[Extension]
	internal static void ReadBytesAsync(Stream stream, long length, int bufferLength, Action completed, Action error) { }

	[Extension]
	internal static T[] Reverse(T[] array) { }

	[Extension]
	internal static IEnumerable SplitHeaderValue(string value, char[] separators) { }

	[Extension]
	public static T[] SubArray(T[] array, long startIndex, long length) { }

	[Extension]
	public static T[] SubArray(T[] array, int startIndex, int length) { }

	[Extension]
	public static void Times(long n, Action action) { }

	[Extension]
	public static void Times(int n, Action action) { }

	[Extension]
	internal static byte[] ToByteArray(Stream stream) { }

	[Extension]
	internal static byte[] ToByteArray(ushort value, ByteOrder order) { }

	[Extension]
	internal static byte[] ToByteArray(ulong value, ByteOrder order) { }

	[Extension]
	internal static CompressionMethod ToCompressionMethod(string value) { }

	[Extension]
	internal static string ToExtensionString(CompressionMethod method, string[] parameters) { }

	[Extension]
	public static byte[] ToHostOrder(byte[] source, ByteOrder sourceOrder) { }

	[Extension]
	internal static IPAddress ToIPAddress(string value) { }

	[Extension]
	internal static List ToList(IEnumerable source) { }

	[Extension]
	public static string ToString(T[] array, string separator) { }

	[Extension]
	internal static string ToString(IPAddress address, bool bracketIPv6) { }

	[Extension]
	internal static ushort ToUInt16(byte[] source, ByteOrder sourceOrder) { }

	[Extension]
	internal static ulong ToUInt64(byte[] source, ByteOrder sourceOrder) { }

	[Extension]
	public static Uri ToUri(string value) { }

	[Extension]
	internal static IEnumerable TrimEach(IEnumerable source) { }

	[Extension]
	internal static string TrimSlashFromEnd(string value) { }

	[Extension]
	internal static string TrimSlashOrBackslashFromEnd(string value) { }

	[Extension]
	internal static bool TryCreateVersion(string versionString, out Version result) { }

	[Extension]
	internal static bool TryCreateWebSocketUri(string uriString, out Uri result, out string message) { }

	[Extension]
	internal static bool TryGetUTF8DecodedString(byte[] bytes, out string s) { }

	[Extension]
	internal static bool TryGetUTF8EncodedBytes(string s, out byte[] bytes) { }

	[Extension]
	internal static bool TryOpenRead(FileInfo fileInfo, out FileStream fileStream) { }

	[Extension]
	internal static string Unquote(string value) { }

	[Extension]
	internal static bool Upgrades(NameValueCollection headers, string protocol) { }

	[Extension]
	internal static string UrlDecode(string value, Encoding encoding) { }

	[Extension]
	internal static string UrlEncode(string value, Encoding encoding) { }

	[Extension]
	internal static void WriteBytes(Stream stream, byte[] bytes, int bufferLength) { }

	[Extension]
	internal static void WriteBytesAsync(Stream stream, byte[] bytes, int bufferLength, Action completed, Action error) { }

}

