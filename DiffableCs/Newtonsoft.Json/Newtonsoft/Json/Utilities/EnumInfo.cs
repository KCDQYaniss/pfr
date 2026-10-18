namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal class EnumInfo
{
	public readonly bool IsFlags; //Field offset: 0x10
	public readonly ulong[] Values; //Field offset: 0x18
	public readonly string[] Names; //Field offset: 0x20
	public readonly string[] ResolvedNames; //Field offset: 0x28

	public EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames) { }

}

