namespace System.Reflection;

public abstract class MemberInfo : ICustomAttributeProvider, _MemberInfo
{

	public override IEnumerable CustomAttributes
	{
		 get { } //Length: 20
	}

	public abstract Type DeclaringType
	{
		 get { } //Length: 0
	}

	public abstract MemberTypes MemberType
	{
		 get { } //Length: 0
	}

	public override int MetadataToken
	{
		 get { } //Length: 62
	}

	public override Module Module
	{
		 get { } //Length: 197
	}

	public abstract string Name
	{
		 get { } //Length: 0
	}

	public abstract Type ReflectedType
	{
		 get { } //Length: 0
	}

	protected MemberInfo() { }

	internal override bool CacheEquals(object o) { }

	public virtual bool Equals(object obj) { }

	public override IEnumerable get_CustomAttributes() { }

	public abstract Type get_DeclaringType() { }

	public abstract MemberTypes get_MemberType() { }

	public override int get_MetadataToken() { }

	public override Module get_Module() { }

	public abstract string get_Name() { }

	public abstract Type get_ReflectedType() { }

	public abstract object[] GetCustomAttributes(bool inherit) { }

	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	public override IList GetCustomAttributesData() { }

	public virtual int GetHashCode() { }

	public override bool HasSameMetadataDefinitionAs(MemberInfo other) { }

	internal bool HasSameMetadataDefinitionAsCore(MemberInfo other) { }

	public abstract bool IsDefined(Type attributeType, bool inherit) { }

	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

	private override void System.Runtime.InteropServices._MemberInfo.GetIDsOfNames(in Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId) { }

	private override Type System.Runtime.InteropServices._MemberInfo.GetType() { }

	private override void System.Runtime.InteropServices._MemberInfo.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo) { }

	private override void System.Runtime.InteropServices._MemberInfo.GetTypeInfoCount(out uint pcTInfo) { }

	private override void System.Runtime.InteropServices._MemberInfo.Invoke(uint dispIdMember, in Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr) { }

}

