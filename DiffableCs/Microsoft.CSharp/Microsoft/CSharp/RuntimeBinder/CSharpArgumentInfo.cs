namespace Microsoft.CSharp.RuntimeBinder;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public sealed class CSharpArgumentInfo
{
	internal static readonly CSharpArgumentInfo None; //Field offset: 0x0
	[CompilerGenerated]
	private readonly CSharpArgumentInfoFlags <Flags>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x18

	private CSharpArgumentInfoFlags Flags
	{
		[CompilerGenerated]
		private get { } //Length: 164
	}

	internal bool IsByRefOrOut
	{
		internal get { } //Length: 8
	}

	internal bool IsOut
	{
		internal get { } //Length: 8
	}

	internal bool IsStaticType
	{
		internal get { } //Length: 8
	}

	internal bool LiteralConstant
	{
		internal get { } //Length: 8
	}

	internal string Name
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal bool NamedArgument
	{
		internal get { } //Length: 8
	}

	internal bool UseCompileTimeType
	{
		internal get { } //Length: 7
	}

	private static CSharpArgumentInfo() { }

	private CSharpArgumentInfo(CSharpArgumentInfoFlags flags, string name) { }

	public static CSharpArgumentInfo Create(CSharpArgumentInfoFlags flags, string name) { }

	[CompilerGenerated]
	private CSharpArgumentInfoFlags get_Flags() { }

	internal bool get_IsByRefOrOut() { }

	internal bool get_IsOut() { }

	internal bool get_IsStaticType() { }

	internal bool get_LiteralConstant() { }

	[CompilerGenerated]
	internal string get_Name() { }

	internal bool get_NamedArgument() { }

	internal bool get_UseCompileTimeType() { }

}

