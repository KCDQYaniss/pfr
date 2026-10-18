//Type is in global namespace

public struct SendRequest
{
	[CompilerGenerated]
	private static readonly int <DefaultTimeoutSeconds>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static int <FirstCycleDelaySeconds>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static int <SecondCycleDelaySeconds>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static int <NextCycleDelaySeconds>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private static int <AdditionalRandomDelaySeconds>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static byte <DefaultRetries>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private static byte <MaximumRetries>k__BackingField; //Field offset: 0x15
	public string Url; //Field offset: 0x0
	public bool UseCache; //Field offset: 0x8
	public object DefaultObjectInCaseOfCache; //Field offset: 0x10
	public string CacheId; //Field offset: 0x18
	public bool RunInMainThread; //Field offset: 0x20
	public bool ParseInBackground; //Field offset: 0x21
	public int TimeoutSeconds; //Field offset: 0x24
	public Nullable Retries; //Field offset: 0x28
	public ERequestHandlingMode HandlingMode; //Field offset: 0x2C
	public string Method; //Field offset: 0x30
	public bool RequireResponse; //Field offset: 0x38
	public bool IgnoreResponseBody; //Field offset: 0x39
	public Dictionary Headers; //Field offset: 0x40
	[CompilerGenerated]
	private object <Params>k__BackingField; //Field offset: 0x48

	public static int AdditionalRandomDelaySeconds
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		 set { } //Length: 88
	}

	public static byte DefaultRetries
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 89
	}

	public static int DefaultTimeoutSeconds
	{
		[CompilerGenerated]
		 get { } //Length: 82
	}

	public static int FirstCycleDelaySeconds
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		 set { } //Length: 88
	}

	public static byte MaximumRetries
	{
		[CompilerGenerated]
		 get { } //Length: 84
		[CompilerGenerated]
		 set { } //Length: 89
	}

	public static int NextCycleDelaySeconds
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		 set { } //Length: 88
	}

	public static Nullable NoRetries
	{
		 get { } //Length: 3
	}

	public object Params
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public static int SecondCycleDelaySeconds
	{
		[CompilerGenerated]
		 get { } //Length: 83
		[CompilerGenerated]
		 set { } //Length: 88
	}

	private static SendRequest() { }

	[CompilerGenerated]
	public static int get_AdditionalRandomDelaySeconds() { }

	[CompilerGenerated]
	public static byte get_DefaultRetries() { }

	[CompilerGenerated]
	public static int get_DefaultTimeoutSeconds() { }

	[CompilerGenerated]
	public static int get_FirstCycleDelaySeconds() { }

	[CompilerGenerated]
	public static byte get_MaximumRetries() { }

	[CompilerGenerated]
	public static int get_NextCycleDelaySeconds() { }

	public static Nullable get_NoRetries() { }

	[CompilerGenerated]
	[IsReadOnly]
	public object get_Params() { }

	[CompilerGenerated]
	public static int get_SecondCycleDelaySeconds() { }

	[CompilerGenerated]
	public static void set_AdditionalRandomDelaySeconds(int value) { }

	[CompilerGenerated]
	public static void set_DefaultRetries(byte value) { }

	[CompilerGenerated]
	public static void set_FirstCycleDelaySeconds(int value) { }

	[CompilerGenerated]
	public static void set_MaximumRetries(byte value) { }

	[CompilerGenerated]
	public static void set_NextCycleDelaySeconds(int value) { }

	[CompilerGenerated]
	public void set_Params(object value) { }

	[CompilerGenerated]
	public static void set_SecondCycleDelaySeconds(int value) { }

}

