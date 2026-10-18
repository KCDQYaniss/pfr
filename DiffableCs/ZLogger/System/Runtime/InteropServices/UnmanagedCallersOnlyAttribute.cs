namespace System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets::Method (64), Inherited = False)]
[Conditional("MULTI_TARGETING_SUPPORT_ATTRIBUTES")]
[ExcludeFromCodeCoverage]
internal sealed class UnmanagedCallersOnlyAttribute : Attribute
{
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public Type[] CallConvs; //Field offset: 0x10
	[Nullable(2)]
	public string EntryPoint; //Field offset: 0x18

	public UnmanagedCallersOnlyAttribute() { }

}

