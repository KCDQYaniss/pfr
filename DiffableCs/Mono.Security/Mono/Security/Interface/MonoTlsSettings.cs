namespace Mono.Security.Interface;

public sealed class MonoTlsSettings
{
	private static MonoTlsSettings defaultSettings; //Field offset: 0x0
	[CompilerGenerated]
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Nullable <CertificateValidationTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private X509CertificateCollection <TrustAnchors>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private object <UserSettings>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string[] <CertificateSearchPaths>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private bool <SendCloseNotify>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private string[] <ClientCertificateIssuers>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Nullable <EnabledProtocols>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; //Field offset: 0x68
	private bool cloned; //Field offset: 0x70
	private bool checkCertName; //Field offset: 0x71
	private bool checkCertRevocationStatus; //Field offset: 0x72
	private Nullable useServicePointManagerCallback; //Field offset: 0x73
	private bool skipSystemValidators; //Field offset: 0x75
	private bool callbackNeedsChain; //Field offset: 0x76
	private ICertificateValidator certificateValidator; //Field offset: 0x78

	public bool CallbackNeedsCertificateChain
	{
		 get { } //Length: 5
	}

	internal string[] CertificateSearchPaths
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	public Nullable CertificateValidationTime
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[Obsolete("Do not use outside System.dll!")]
	public ICertificateValidator CertificateValidator
	{
		 get { } //Length: 5
	}

	public string[] ClientCertificateIssuers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public static MonoTlsSettings DefaultSettings
	{
		 get { } //Length: 183
	}

	public bool DisallowUnauthenticatedCertificateRequest
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[CLSCompliant(False)]
	public CipherSuiteCode[] EnabledCiphers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Nullable EnabledProtocols
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	internal bool SendCloseNotify
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public X509CertificateCollection TrustAnchors
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public object UserSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public Nullable UseServicePointManagerCallback
	{
		 get { } //Length: 5
		 set { } //Length: 5
	}

	private MonoTlsSettings(MonoTlsSettings other) { }

	public MonoTlsSettings() { }

	public MonoTlsSettings Clone() { }

	[Obsolete("Do not use outside System.dll!")]
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	public static MonoTlsSettings CopyDefaultSettings() { }

	public bool get_CallbackNeedsCertificateChain() { }

	[CompilerGenerated]
	internal string[] get_CertificateSearchPaths() { }

	[CompilerGenerated]
	public Nullable get_CertificateValidationTime() { }

	public ICertificateValidator get_CertificateValidator() { }

	[CompilerGenerated]
	public string[] get_ClientCertificateIssuers() { }

	[CompilerGenerated]
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	public static MonoTlsSettings get_DefaultSettings() { }

	[CompilerGenerated]
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	[CompilerGenerated]
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[CompilerGenerated]
	public Nullable get_EnabledProtocols() { }

	[CompilerGenerated]
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[CompilerGenerated]
	internal bool get_SendCloseNotify() { }

	[CompilerGenerated]
	public X509CertificateCollection get_TrustAnchors() { }

	[CompilerGenerated]
	public object get_UserSettings() { }

	public Nullable get_UseServicePointManagerCallback() { }

	[CompilerGenerated]
	internal void set_CertificateSearchPaths(string[] value) { }

	[CompilerGenerated]
	public void set_CertificateValidationTime(Nullable value) { }

	[CompilerGenerated]
	public void set_ClientCertificateIssuers(string[] value) { }

	[CompilerGenerated]
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	[CompilerGenerated]
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	[CompilerGenerated]
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	[CompilerGenerated]
	public void set_EnabledProtocols(Nullable value) { }

	[CompilerGenerated]
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	internal void set_SendCloseNotify(bool value) { }

	[CompilerGenerated]
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[CompilerGenerated]
	public void set_UserSettings(object value) { }

	public void set_UseServicePointManagerCallback(Nullable value) { }

}

