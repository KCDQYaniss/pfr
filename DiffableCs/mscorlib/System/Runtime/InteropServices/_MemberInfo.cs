namespace System.Runtime.InteropServices;

[CLSCompliant(False)]
[ComVisible(True)]
[Guid("f7102fa9-cabb-3a74-a6da-b4567ef1b079")]
[InterfaceType(ComInterfaceType::InterfaceIsIUnknown (1))]
public interface _MemberInfo
{

	public void GetIDsOfNames(in Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId) { }

	public Type GetType() { }

	public void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo) { }

	public void GetTypeInfoCount(out uint pcTInfo) { }

	public void Invoke(uint dispIdMember, in Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr) { }

}

