namespace System.Runtime.InteropServices;

[IsReadOnly]
public struct OSPlatform : IEquatable
{
	[CompilerGenerated]
	private static readonly OSPlatform <Linux>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly OSPlatform <OSX>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static readonly OSPlatform <Windows>k__BackingField; //Field offset: 0x10
	private readonly string _osPlatform; //Field offset: 0x0

	public static OSPlatform Linux
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	public static OSPlatform OSX
	{
		[CompilerGenerated]
		 get { } //Length: 84
	}

	public static OSPlatform Windows
	{
		[CompilerGenerated]
		 get { } //Length: 84
	}

	private static OSPlatform() { }

	private OSPlatform(string osPlatform) { }

	public static OSPlatform Create(string osPlatform) { }

	public override bool Equals(OSPlatform other) { }

	internal bool Equals(string other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public static OSPlatform get_Linux() { }

	[CompilerGenerated]
	public static OSPlatform get_OSX() { }

	[CompilerGenerated]
	public static OSPlatform get_Windows() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(OSPlatform left, OSPlatform right) { }

	public virtual string ToString() { }

}

