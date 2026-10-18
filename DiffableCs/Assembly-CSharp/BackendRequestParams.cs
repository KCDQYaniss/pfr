//Type is in global namespace

internal class BackendRequestParams
{
	public static readonly Dictionary TransportPrefixes; //Field offset: 0x0
	public string BackendName; //Field offset: 0x10
	public string BackendMethod; //Field offset: 0x18
	public string Method; //Field offset: 0x20
	public string[] FallbackBackendNames; //Field offset: 0x28
	public bool ShouldUseCache; //Field offset: 0x30
	public string OverrideCacheId; //Field offset: 0x38
	public object DefaultObjectInCaseOfCache; //Field offset: 0x40
	public object Params; //Field offset: 0x48
	public Dictionary Headers; //Field offset: 0x50
	public Nullable Retries; //Field offset: 0x58
	public int TimeoutSeconds; //Field offset: 0x5C
	public ERequestHandlingMode HandlingMode; //Field offset: 0x60
	public bool RunInMainThread; //Field offset: 0x64
	public bool IgnoreResponseBody; //Field offset: 0x65
	private object m_CachedObject; //Field offset: 0x68
	private IBackendCache m_BackendCache; //Field offset: 0x70
	private byte[] m_Data; //Field offset: 0x78
	private string m_ParamsJsonText; //Field offset: 0x80
	private string m_QueryString; //Field offset: 0x88
	private byte m_SelectedURLIndex; //Field offset: 0x90
	private byte m_CurrentRetryCycle; //Field offset: 0x91
	private byte m_RetryIndex; //Field offset: 0x92
	[CompilerGenerated]
	private long <RequestId>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private ETransportProtocolType <ProtocolType>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private string <CachedETag>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private string <IncomingETag>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private string <CacheMatchedLogMarker>k__BackingField; //Field offset: 0xB8

	public private string CachedETag
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private string CacheID
	{
		private get { } //Length: 23
	}

	public string CacheMatchedLogMarker
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public bool CacheValidationConfigured
	{
		 get { } //Length: 9
	}

	public byte CurrentRetryCycle
	{
		 get { } //Length: 8
	}

	public string CurSelectedURLFull
	{
		 get { } //Length: 375
	}

	public string CurSelectedURLNamePath
	{
		 get { } //Length: 220
	}

	public byte[] Data
	{
		 get { } //Length: 5
	}

	public string IncomingETag
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public string MainURLFull
	{
		 get { } //Length: 176
	}

	public string MainURLNamePath
	{
		 get { } //Length: 16
	}

	public string ParamsJsonText
	{
		 get { } //Length: 8
	}

	public private ETransportProtocolType ProtocolType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private long RequestId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private static BackendRequestParams() { }

	public BackendRequestParams() { }

	private static string AppendQueryParameter(string path, string name, string value) { }

	private static string BuildQueryString(object paramsObj, string basePath) { }

	public static BackendRequestParams CreateFromLegacyParams(SendRequest legacyParams) { }

	[CompilerGenerated]
	public string get_CachedETag() { }

	private string get_CacheID() { }

	[CompilerGenerated]
	public string get_CacheMatchedLogMarker() { }

	public bool get_CacheValidationConfigured() { }

	public byte get_CurrentRetryCycle() { }

	public string get_CurSelectedURLFull() { }

	public string get_CurSelectedURLNamePath() { }

	public byte[] get_Data() { }

	[CompilerGenerated]
	public string get_IncomingETag() { }

	public string get_MainURLFull() { }

	public string get_MainURLNamePath() { }

	public string get_ParamsJsonText() { }

	[CompilerGenerated]
	public ETransportProtocolType get_ProtocolType() { }

	[CompilerGenerated]
	public long get_RequestId() { }

	private static bool HasQueryParameters(string path) { }

	public void IncreaseRetryIndex() { }

	public T ParseCachedData() { }

	public void SaveResponseToCache(T parsedData, string etag = null) { }

	[CompilerGenerated]
	private void set_CachedETag(string value) { }

	[CompilerGenerated]
	public void set_CacheMatchedLogMarker(string value) { }

	[CompilerGenerated]
	public void set_IncomingETag(string value) { }

	[CompilerGenerated]
	private void set_ProtocolType(ETransportProtocolType value) { }

	[CompilerGenerated]
	private void set_RequestId(long value) { }

	public void SetupCacheValidation(BackendCache cache) { }

	public void SetupDataBlock(bool zipped) { }

	public void SetupIdAndProtocol(long id, ETransportProtocolType protocol) { }

}

