namespace EFT;

[ScriptOrder(-3000)]
public abstract class AbstractApplication : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static RemoteCertificateValidationCallback <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Awake>b__8_0(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__Register; //Field offset: 0x0
		public static Action <1>__Register; //Field offset: 0x8
		public static Action <2>__Register; //Field offset: 0x10
		public static Action <3>__Register; //Field offset: 0x18
		public static Action <4>__Register; //Field offset: 0x20
		public static Action <5>__Register; //Field offset: 0x28
		public static Action <6>__Register; //Field offset: 0x30

	}

	private static bool _isTechnicalSystemsCreated; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <Initialized>k__BackingField; //Field offset: 0x1
	public ApplicationLogger Logger; //Field offset: 0x20
	[CompilerGenerated]
	private bool <Destroyed>k__BackingField; //Field offset: 0x28

	public private bool Destroyed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected private static bool Initialized
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		private set { } //Length: 65
	}

	protected abstract EUpdateQueue PlayerUpdateQueue
	{
		 get { } //Length: 0
	}

	protected AbstractApplication() { }

	[CompilerGenerated]
	private void <Awake>b__8_1(string s) { }

	public override void Awake() { }

	private static void CreateFrameMeasurerSingleton() { }

	protected abstract LogConfiguration CreateLogConfiguration() { }

	public static void CreateTechnicalSystems() { }

	protected override void Destroy() { }

	protected override void FixedUpdate() { }

	[CompilerGenerated]
	public bool get_Destroyed() { }

	[CompilerGenerated]
	protected static bool get_Initialized() { }

	protected abstract EUpdateQueue get_PlayerUpdateQueue() { }

	public override void OnDestroy() { }

	[CompilerGenerated]
	private void set_Destroyed(bool value) { }

	[CompilerGenerated]
	private static void set_Initialized(bool value) { }

	protected override void Update() { }

}

