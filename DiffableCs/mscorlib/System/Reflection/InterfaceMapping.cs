namespace System.Reflection;

public struct InterfaceMapping
{
	public Type TargetType; //Field offset: 0x0
	public Type InterfaceType; //Field offset: 0x8
	public MethodInfo[] TargetMethods; //Field offset: 0x10
	public MethodInfo[] InterfaceMethods; //Field offset: 0x18

}

