namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(True)]
internal class RuntimeAssembly : Assembly
{
	public class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
	{
		private Module module; //Field offset: 0x68

		public UnmanagedMemoryStreamForModule(byte* pointer, long length, Module module) { }

		protected virtual void Dispose(bool disposing) { }

	}

	internal IntPtr _mono_assembly; //Field offset: 0x10
	private object _evidence; //Field offset: 0x18
	internal ResolveEventHolder resolve_event_holder; //Field offset: 0x20
	private object _minimum; //Field offset: 0x28
	private object _optional; //Field offset: 0x30
	private object _refuse; //Field offset: 0x38
	private object _granted; //Field offset: 0x40
	private object _denied; //Field offset: 0x48
	internal bool fromByteArray; //Field offset: 0x50
	internal string assemblyName; //Field offset: 0x58

	public virtual string CodeBase
	{
		 get { } //Length: 282
	}

	public virtual MethodInfo EntryPoint
	{
		 get { } //Length: 60
	}

	internal virtual bool FromByteArray
	{
		internal set { } //Length: 4
	}

	public virtual string FullName
	{
		 get { } //Length: 159
	}

	public virtual string Location
	{
		 get { } //Length: 214
	}

	internal virtual IntPtr MonoAssembly
	{
		internal get { } //Length: 5
	}

	[ComVisible(False)]
	public virtual bool ReflectionOnly
	{
		 get { } //Length: 3
	}

	protected RuntimeAssembly() { }

	internal static AssemblyName CreateAssemblyName(string assemblyString, bool forIntrospection, out RuntimeAssembly assemblyFromResolveEvent) { }

	public virtual bool Equals(object o) { }

	private static string get_code_base(Assembly a, bool escaped) { }

	public virtual string get_CodeBase() { }

	public virtual MethodInfo get_EntryPoint() { }

	internal static string get_fullname(Assembly a) { }

	public virtual string get_FullName() { }

	private string get_location() { }

	public virtual string get_Location() { }

	internal virtual IntPtr get_MonoAssembly() { }

	public virtual bool get_ReflectionOnly() { }

	internal static byte[] GetAotId() { }

	internal static bool GetAotIdInternal(byte[] aotid) { }

	internal static string GetCodeBase(Assembly a, bool escaped) { }

	public virtual object[] GetCustomAttributes(bool inherit) { }

	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	internal static RuntimeAssembly GetExecutingAssembly(ref StackCrawlMark stackMark) { }

	public virtual Type[] GetExportedTypes() { }

	public virtual int GetHashCode() { }

	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) { }

	private bool GetManifestResourceInfoInternal(string name, ManifestResourceInfo info) { }

	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	public virtual string[] GetManifestResourceNames() { }

	public virtual Stream GetManifestResourceStream(string name) { }

	public virtual Module GetModule(string name) { }

	public virtual Module[] GetModules(bool getResourceModules) { }

	internal virtual Module[] GetModulesInternal() { }

	public virtual AssemblyName GetName(bool copiedName) { }

	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	internal static RuntimeAssembly InternalLoadAssemblyName(AssemblyName assemblyRef, Evidence assemblySecurity, RuntimeAssembly reqAssembly, ref StackCrawlMark stackMark, bool throwOnFileNotFound, bool forIntrospection, bool suppressSecurityChecks) { }

	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	internal virtual void set_FromByteArray(bool value) { }

	public virtual string ToString() { }

}

