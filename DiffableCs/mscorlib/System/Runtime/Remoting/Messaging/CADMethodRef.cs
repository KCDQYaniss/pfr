namespace System.Runtime.Remoting.Messaging;

internal class CADMethodRef
{
	private bool ctor; //Field offset: 0x10
	private string typeName; //Field offset: 0x18
	private string methodName; //Field offset: 0x20
	private string[] param_names; //Field offset: 0x28
	private string[] generic_arg_names; //Field offset: 0x30

	public CADMethodRef(IMethodMessage msg) { }

	private Type[] GetTypes(string[] typeArray) { }

	public MethodBase Resolve() { }

}

