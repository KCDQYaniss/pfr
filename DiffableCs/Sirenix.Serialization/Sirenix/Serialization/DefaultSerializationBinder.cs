namespace Sirenix.Serialization;

public class DefaultSerializationBinder : TwoWaySerializationBinder
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__10_0(object sender, AssemblyLoadEventArgs args) { }

	}

	private static readonly object ASSEMBLY_LOOKUP_LOCK; //Field offset: 0x0
	private static readonly Dictionary assemblyNameLookUp; //Field offset: 0x8
	private static readonly Dictionary customTypeNameToTypeBindings; //Field offset: 0x10
	private static readonly object TYPETONAME_LOCK; //Field offset: 0x18
	private static readonly Dictionary nameMap; //Field offset: 0x20
	private static readonly object NAMETOTYPE_LOCK; //Field offset: 0x28
	private static readonly Dictionary typeMap; //Field offset: 0x30
	private static readonly object ASSEMBLY_REGISTER_QUEUE_LOCK; //Field offset: 0x38
	private static readonly List assembliesQueuedForRegister; //Field offset: 0x40
	private static readonly List assemblyLoadEventsQueuedForRegister; //Field offset: 0x48

	private static DefaultSerializationBinder() { }

	public DefaultSerializationBinder() { }

	public virtual string BindToName(Type type, DebugContext debugContext = null) { }

	public virtual Type BindToType(string typeName, DebugContext debugContext = null) { }

	public virtual bool ContainsType(string typeName) { }

	private Type ParseGenericAndOrArrayType(string typeName, DebugContext debugContext) { }

	private static void ParseName(string fullName, out string typeName, out string assemblyName) { }

	private Type ParseTypeName(string typeName, DebugContext debugContext) { }

	private static char Peek(string str, int i, int ahead) { }

	private static bool ReadGenericArg(string typeName, ref int i, out string argName) { }

	private static void RegisterAllQueuedAssembliesRepeating() { }

	private static void RegisterAssembly(Assembly assembly) { }

	private static bool RegisterQueuedAssemblies() { }

	private static bool RegisterQueuedAssemblyLoadEvents() { }

	private static bool TryParseGenericAndOrArrayTypeName(string typeName, out string actualTypeName, out bool isGeneric, out List genericArgNames, out bool isArray, out int arrayRank) { }

}

