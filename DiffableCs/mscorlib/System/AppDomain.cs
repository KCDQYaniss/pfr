namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComVisible(True)]
public sealed class AppDomain : MarshalByRefObject
{
	[ThreadStatic]
	private static Dictionary type_resolve_in_progress; //Field offset: 0x80000000
	[ThreadStatic]
	private static Dictionary assembly_resolve_in_progress; //Field offset: 0x80000008
	[ThreadStatic]
	private static Dictionary assembly_resolve_in_progress_refonly; //Field offset: 0x80000010
	[ThreadStatic]
	private static object _principal; //Field offset: 0x80000018
	private static string _process_guid; //Field offset: 0x0
	private static AppDomain default_domain; //Field offset: 0x8
	private IntPtr _mono_app_domain; //Field offset: 0x18
	private object _evidence; //Field offset: 0x20
	private object _granted; //Field offset: 0x28
	private int _principalPolicy; //Field offset: 0x30
	[CompilerGenerated]
	private AssemblyLoadEventHandler AssemblyLoad; //Field offset: 0x38
	[CompilerGenerated]
	private ResolveEventHandler AssemblyResolve; //Field offset: 0x40
	[CompilerGenerated]
	private EventHandler DomainUnload; //Field offset: 0x48
	[CompilerGenerated]
	private EventHandler ProcessExit; //Field offset: 0x50
	[CompilerGenerated]
	private ResolveEventHandler ResourceResolve; //Field offset: 0x58
	[CompilerGenerated]
	private ResolveEventHandler TypeResolve; //Field offset: 0x60
	[CompilerGenerated]
	private UnhandledExceptionEventHandler UnhandledException; //Field offset: 0x68
	[CompilerGenerated]
	private EventHandler FirstChanceException; //Field offset: 0x70
	private object _domain_manager; //Field offset: 0x78
	[CompilerGenerated]
	private ResolveEventHandler ReflectionOnlyAssemblyResolve; //Field offset: 0x80
	private object _activation; //Field offset: 0x88
	private object _applicationIdentity; //Field offset: 0x90
	private List compatibility_switch; //Field offset: 0x98

	public override event AssemblyLoadEventHandler AssemblyLoad
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event ResolveEventHandler AssemblyResolve
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event EventHandler DomainUnload
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event EventHandler FirstChanceException
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event EventHandler ProcessExit
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event ResolveEventHandler ReflectionOnlyAssemblyResolve
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public override event ResolveEventHandler ResourceResolve
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event ResolveEventHandler TypeResolve
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override event UnhandledExceptionEventHandler UnhandledException
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public ActivationContext ActivationContext
	{
		 get { } //Length: 86
	}

	public ApplicationIdentity ApplicationIdentity
	{
		 get { } //Length: 86
	}

	public ApplicationTrust ApplicationTrust
	{
		 get { } //Length: 44
	}

	public override string BaseDirectory
	{
		 get { } //Length: 37
	}

	public static AppDomain CurrentDomain
	{
		 get { } //Length: 50
	}

	internal static AppDomain DefaultDomain
	{
		internal get { } //Length: 518
	}

	public AppDomainManager DomainManager
	{
		 get { } //Length: 112
	}

	public override string DynamicDirectory
	{
		 get { } //Length: 148
	}

	public override Evidence Evidence
	{
		 get { } //Length: 516
	}

	public override string FriendlyName
	{
		 get { } //Length: 30
	}

	public int Id
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 17
	}

	[MonoTODO]
	public bool IsFullyTrusted
	{
		 get { } //Length: 3
	}

	[MonoTODO]
	public bool IsHomogenous
	{
		 get { } //Length: 3
	}

	[MonoTODO("Currently always returns false")]
	public static bool MonitoringIsEnabled
	{
		 get { } //Length: 3
		 set { } //Length: 62
	}

	[MonoTODO]
	public long MonitoringSurvivedMemorySize
	{
		 get { } //Length: 62
	}

	[MonoTODO]
	public static long MonitoringSurvivedProcessMemorySize
	{
		 get { } //Length: 62
	}

	[MonoTODO]
	public long MonitoringTotalAllocatedMemorySize
	{
		 get { } //Length: 62
	}

	[MonoTODO]
	public TimeSpan MonitoringTotalProcessorTime
	{
		 get { } //Length: 62
	}

	public PermissionSet PermissionSet
	{
		 get { } //Length: 302
	}

	public override string RelativeSearchPath
	{
		 get { } //Length: 31
	}

	public AppDomainSetup SetupInformation
	{
		 get { } //Length: 97
	}

	internal AppDomainSetup SetupInformationNoCopy
	{
		internal get { } //Length: 9
	}

	public override bool ShadowCopyFiles
	{
		 get { } //Length: 138
	}

	private AppDomain() { }

	[CompilerGenerated]
	public override void add_AssemblyLoad(AssemblyLoadEventHandler value) { }

	[CompilerGenerated]
	public override void add_AssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	public override void add_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	public void add_FirstChanceException(EventHandler value) { }

	[CompilerGenerated]
	public override void add_ProcessExit(EventHandler value) { }

	[CompilerGenerated]
	public void add_ReflectionOnlyAssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	public override void add_ResourceResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	public override void add_TypeResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	public override void add_UnhandledException(UnhandledExceptionEventHandler value) { }

	[Obsolete("AppDomain.AppendPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead.")]
	public override void AppendPrivatePath(string path) { }

	[ComVisible(False)]
	[MonoTODO("This routine only returns the parameter currently")]
	public string ApplyPolicy(string assemblyName) { }

	internal static void CheckLoadFromSupported() { }

	internal static void CheckReflectionOnlyLoadSupported() { }

	[Obsolete("AppDomain.ClearPrivatePath has been deprecated. Please investigate the use of AppDomainSetup.PrivateBinPath instead.")]
	public override void ClearPrivatePath() { }

	[Obsolete("Use AppDomainSetup.ShadowCopyDirectories")]
	public override void ClearShadowCopyPath() { }

	public ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName) { }

	public ObjectHandle CreateComInstanceFrom(string assemblyFile, string typeName, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm) { }

	private static AppDomain createDomain(string friendlyName, AppDomainSetup info) { }

	public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo) { }

	[MonoLimitation("Currently it does not allow the setup in the other domain")]
	public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info) { }

	public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles, AppDomainInitializer adInit, string[] adInitArgs) { }

	public static AppDomain CreateDomain(string friendlyName) { }

	public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles) { }

	public static AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup info, PermissionSet grantSet, StrongName[] fullTrustAssemblies) { }

	private static AppDomainSetup CreateDomainSetup(string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public override ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes) { }

	public override ObjectHandle CreateInstance(string assemblyName, string typeName) { }

	public override ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes) { }

	public ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes) { }

	public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes) { }

	public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes) { }

	public object CreateInstanceAndUnwrap(string assemblyName, string typeName) { }

	public override ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) { }

	public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes) { }

	public override ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public override ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, Evidence securityAttributes) { }

	public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes) { }

	public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName) { }

	public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes) { }

	[Obsolete("Declarative security for assembly level is no longer enforced")]
	public override AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions) { }

	public override AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access) { }

	[Obsolete("Declarative security for assembly level is no longer enforced")]
	public override AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence) { }

	public override AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir) { }

	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable assemblyAttributes, SecurityContextSource securityContextSource) { }

	[Obsolete("Declarative security for assembly level is no longer enforced")]
	public override AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence) { }

	[Obsolete("Declarative security for assembly level is no longer enforced")]
	public override AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions) { }

	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, bool isSynchronized, IEnumerable assemblyAttributes) { }

	[Obsolete("Declarative security for assembly level is no longer enforced")]
	public override AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions) { }

	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, IEnumerable assemblyAttributes) { }

	[Obsolete("Declarative security for assembly level is no longer enforced")]
	public override AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions) { }

	[Obsolete("Declarative security for assembly level is no longer enforced")]
	public AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized, IEnumerable assemblyAttributes) { }

	[Obsolete("Declarative security for assembly level is no longer enforced")]
	public override AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, string dir, Evidence evidence, PermissionSet requiredPermissions, PermissionSet optionalPermissions, PermissionSet refusedPermissions, bool isSynchronized) { }

	private void DoAssemblyLoad(Assembly assembly) { }

	private Assembly DoAssemblyResolve(string name, Assembly requestingAssembly, bool refonly) { }

	public override void DoCallBack(CrossAppDomainDelegate callBackDelegate) { }

	private void DoDomainUnload() { }

	internal Assembly DoResourceResolve(string name, Assembly requesting) { }

	internal Assembly DoTypeResolve(string name) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public override int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity, string[] args) { }

	public int ExecuteAssembly(string assemblyFile, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public override int ExecuteAssembly(string assemblyFile, Evidence assemblySecurity) { }

	private int ExecuteAssembly(Assembly a, string[] args) { }

	public override int ExecuteAssembly(string assemblyFile) { }

	public int ExecuteAssembly(string assemblyFile, string[] args) { }

	public int ExecuteAssemblyByName(AssemblyName assemblyName, string[] args) { }

	public int ExecuteAssemblyByName(string assemblyName, string[] args) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public int ExecuteAssemblyByName(AssemblyName assemblyName, Evidence assemblySecurity, string[] args) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity, string[] args) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public int ExecuteAssemblyByName(string assemblyName, Evidence assemblySecurity) { }

	public int ExecuteAssemblyByName(string assemblyName) { }

	private int ExecuteAssemblyInternal(Assembly a, string[] args) { }

	public ActivationContext get_ActivationContext() { }

	public ApplicationIdentity get_ApplicationIdentity() { }

	public ApplicationTrust get_ApplicationTrust() { }

	public override string get_BaseDirectory() { }

	public static AppDomain get_CurrentDomain() { }

	internal static AppDomain get_DefaultDomain() { }

	public AppDomainManager get_DomainManager() { }

	public override string get_DynamicDirectory() { }

	public override Evidence get_Evidence() { }

	public override string get_FriendlyName() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public int get_Id() { }

	public bool get_IsFullyTrusted() { }

	public bool get_IsHomogenous() { }

	public static bool get_MonitoringIsEnabled() { }

	public long get_MonitoringSurvivedMemorySize() { }

	public static long get_MonitoringSurvivedProcessMemorySize() { }

	public long get_MonitoringTotalAllocatedMemorySize() { }

	public TimeSpan get_MonitoringTotalProcessorTime() { }

	public PermissionSet get_PermissionSet() { }

	public override string get_RelativeSearchPath() { }

	public AppDomainSetup get_SetupInformation() { }

	internal AppDomainSetup get_SetupInformationNoCopy() { }

	public override bool get_ShadowCopyFiles() { }

	private Assembly[] GetAssemblies(bool refOnly) { }

	public override Assembly[] GetAssemblies() { }

	private static AppDomain getCurDomain() { }

	[Obsolete("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread.'")]
	public static int GetCurrentThreadId() { }

	public override object GetData(string name) { }

	private int getDomainID() { }

	private string getFriendlyName() { }

	internal byte[] GetMarshalledDomainObjRef() { }

	internal static string GetProcessGuid() { }

	private static AppDomain getRootDomain() { }

	private AppDomainSetup getSetup() { }

	public override Type GetType() { }

	public virtual object InitializeLifetimeService() { }

	internal static Context InternalGetContext() { }

	internal static Context InternalGetDefaultContext() { }

	internal static string InternalGetProcessGuid(string newguid) { }

	private static bool InternalIsFinalizingForUnload(int domain_id) { }

	internal static void InternalPopDomainRef() { }

	internal static void InternalPushDomainRef(AppDomain domain) { }

	internal static void InternalPushDomainRefByID(int domain_id) { }

	internal static Context InternalSetContext(Context context) { }

	private static AppDomain InternalSetDomain(AppDomain context) { }

	private static AppDomain InternalSetDomainByID(int domain_id) { }

	private static void InternalUnload(int domain_id) { }

	internal static object InvokeInDomain(AppDomain domain, MethodInfo method, object obj, object[] args) { }

	internal static object InvokeInDomainByID(int domain_id, MethodInfo method, object obj, object[] args) { }

	[Intrinsic]
	internal static bool IsAppXModel() { }

	public Nullable IsCompatibilitySwitchSet(string value) { }

	public bool IsDefaultAppDomain() { }

	public bool IsFinalizingForUnload() { }

	public override Assembly Load(string assemblyString) { }

	public override Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore) { }

	public override Assembly Load(byte[] rawAssembly) { }

	internal Assembly Load(string assemblyString, Evidence assemblySecurity, bool refonly, ref StackCrawlMark stackMark) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public override Assembly Load(string assemblyString, Evidence assemblySecurity) { }

	internal Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence, bool refonly) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public override Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence) { }

	[Obsolete("Use an overload that does not take an Evidence parameter")]
	public override Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity) { }

	public override Assembly Load(AssemblyName assemblyRef) { }

	internal Assembly LoadAssembly(string assemblyRef, Evidence securityEvidence, bool refOnly, ref StackCrawlMark stackMark) { }

	internal Assembly LoadAssemblyRaw(byte[] rawAssembly, byte[] rawSymbolStore, Evidence securityEvidence, bool refonly) { }

	internal Assembly LoadSatellite(AssemblyName assemblyRef, bool throwOnError, ref StackCrawlMark stackMark) { }

	internal void ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg, out byte[] arrResponse, out CADMethodReturnMessage cadMrm) { }

	public Assembly[] ReflectionOnlyGetAssemblies() { }

	[CompilerGenerated]
	public override void remove_AssemblyLoad(AssemblyLoadEventHandler value) { }

	[CompilerGenerated]
	public override void remove_AssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	public override void remove_DomainUnload(EventHandler value) { }

	[CompilerGenerated]
	public void remove_FirstChanceException(EventHandler value) { }

	[CompilerGenerated]
	public override void remove_ProcessExit(EventHandler value) { }

	[CompilerGenerated]
	public void remove_ReflectionOnlyAssemblyResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	public override void remove_ResourceResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	public override void remove_TypeResolve(ResolveEventHandler value) { }

	[CompilerGenerated]
	public override void remove_UnhandledException(UnhandledExceptionEventHandler value) { }

	public static void set_MonitoringIsEnabled(bool value) { }

	[Obsolete("AppDomain policy levels are obsolete")]
	public override void SetAppDomainPolicy(PolicyLevel domainPolicy) { }

	[Obsolete("Use AppDomainSetup.SetCachePath")]
	public override void SetCachePath(string path) { }

	[MonoLimitation("The permission field is ignored")]
	public void SetData(string name, object data, IPermission permission) { }

	public override void SetData(string name, object data) { }

	[Obsolete("Use AppDomainSetup.DynamicBase")]
	public void SetDynamicBase(string path) { }

	public override void SetPrincipalPolicy(PrincipalPolicy policy) { }

	[Obsolete("Use AppDomainSetup.ShadowCopyFiles")]
	public void SetShadowCopyFiles() { }

	[Obsolete("Use AppDomainSetup.ShadowCopyDirectories")]
	public override void SetShadowCopyPath(string path) { }

	public override void SetThreadPrincipal(IPrincipal principal) { }

	public virtual string ToString() { }

	[ReliabilityContract(Consistency::MayCorruptAppDomain (1), Cer::MayFail (1))]
	public static void Unload(AppDomain domain) { }

}

