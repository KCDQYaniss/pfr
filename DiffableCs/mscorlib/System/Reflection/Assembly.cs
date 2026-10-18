namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(True)]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly
{
	public class ResolveEventHolder
	{

		public ResolveEventHolder() { }

	}


	public override string CodeBase
	{
		 get { } //Length: 62
	}

	public override MethodInfo EntryPoint
	{
		 get { } //Length: 62
	}

	internal override bool FromByteArray
	{
		internal set { } //Length: 62
	}

	public override string FullName
	{
		 get { } //Length: 62
	}

	[MonoTODO]
	public bool IsFullyTrusted
	{
		 get { } //Length: 3
	}

	public override string Location
	{
		 get { } //Length: 62
	}

	internal override IntPtr MonoAssembly
	{
		internal get { } //Length: 62
	}

	[ComVisible(False)]
	public override bool ReflectionOnly
	{
		 get { } //Length: 62
	}

	public Assembly() { }

	private static Exception CreateNIE() { }

	public virtual bool Equals(object o) { }

	public override string get_CodeBase() { }

	public override MethodInfo get_EntryPoint() { }

	public override string get_FullName() { }

	public bool get_IsFullyTrusted() { }

	public override string get_Location() { }

	internal override IntPtr get_MonoAssembly() { }

	public override bool get_ReflectionOnly() { }

	public static Assembly GetAssembly(Type type) { }

	public static Assembly GetCallingAssembly() { }

	public override object[] GetCustomAttributes(bool inherit) { }

	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public static Assembly GetEntryAssembly() { }

	public static Assembly GetExecutingAssembly() { }

	public override Type[] GetExportedTypes() { }

	private AssemblyNameFlags GetFlags() { }

	public virtual int GetHashCode() { }

	public override ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	public override string[] GetManifestResourceNames() { }

	internal Stream GetManifestResourceStream(string name, ref StackCrawlMark stackMark, bool skipSecurityCheck) { }

	internal Stream GetManifestResourceStream(Type type, string name, bool skipSecurityCheck, ref StackCrawlMark stackMark) { }

	public override Stream GetManifestResourceStream(string name) { }

	public override Module GetModule(string name) { }

	public override Module[] GetModules(bool getResourceModules) { }

	internal override Module[] GetModulesInternal() { }

	public override AssemblyName GetName() { }

	public override AssemblyName GetName(bool copiedName) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal byte[] GetPublicKey() { }

	internal string GetSimpleName() { }

	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	public override Type GetType(string name) { }

	public override Type GetType(string name, bool throwOnError) { }

	public override Type[] GetTypes() { }

	internal override Type[] GetTypes(bool exportedOnly) { }

	internal Version GetVersion() { }

	internal RuntimeAssembly InternalGetSatelliteAssembly(string name, CultureInfo culture, Version version, bool throwOnFileNotFound, ref StackCrawlMark stackMark) { }

	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	public override bool IsDefined(Type attributeType, bool inherit) { }

	[Obsolete]
	public static Assembly Load(AssemblyName assemblyRef, Evidence assemblySecurity) { }

	public static Assembly Load(AssemblyName assemblyRef) { }

	[Obsolete]
	public static Assembly Load(string assemblyString, Evidence assemblySecurity) { }

	public static Assembly Load(string assemblyString) { }

	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[Obsolete]
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence) { }

	[MonoTODO("This overload is not currently implemented")]
	[Obsolete]
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm) { }

	private static Assembly LoadFrom(string assemblyFile, bool refOnly, ref StackCrawlMark stackMark) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static Assembly LoadWithPartialName(string partialName) { }

	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	public static bool op_Equality(Assembly left, Assembly right) { }

	public static bool op_Inequality(Assembly left, Assembly right) { }

	public static Assembly ReflectionOnlyLoad(string assemblyString) { }

	internal override void set_FromByteArray(bool value) { }

	public virtual string ToString() { }

}

