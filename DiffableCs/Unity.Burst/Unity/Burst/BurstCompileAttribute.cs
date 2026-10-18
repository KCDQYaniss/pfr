namespace Unity.Burst;

[AttributeUsage(77)]
public class BurstCompileAttribute : Attribute
{
	[CompilerGenerated]
	private FloatMode <FloatMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private FloatPrecision <FloatPrecision>k__BackingField; //Field offset: 0x14
	internal Nullable _compileSynchronously; //Field offset: 0x18
	internal Nullable _debug; //Field offset: 0x1A
	internal Nullable _disableSafetyChecks; //Field offset: 0x1C
	internal Nullable _disableDirectCall; //Field offset: 0x1E
	[CompilerGenerated]
	private OptimizeFor <OptimizeFor>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string[] <Options>k__BackingField; //Field offset: 0x28

	public bool CompileSynchronously
	{
		 get { } //Length: 83
		 set { } //Length: 78
	}

	public bool Debug
	{
		 get { } //Length: 83
		 set { } //Length: 78
	}

	public bool DisableDirectCall
	{
		 get { } //Length: 83
		 set { } //Length: 78
	}

	public bool DisableSafetyChecks
	{
		 get { } //Length: 83
		 set { } //Length: 78
	}

	public FloatMode FloatMode
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public FloatPrecision FloatPrecision
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public OptimizeFor OptimizeFor
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	internal string[] Options
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 82
	}

	internal BurstCompileAttribute(string[] options) { }

	public BurstCompileAttribute() { }

	public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode) { }

	public bool get_CompileSynchronously() { }

	public bool get_Debug() { }

	public bool get_DisableDirectCall() { }

	public bool get_DisableSafetyChecks() { }

	[CompilerGenerated]
	public FloatMode get_FloatMode() { }

	[CompilerGenerated]
	public FloatPrecision get_FloatPrecision() { }

	[CompilerGenerated]
	public OptimizeFor get_OptimizeFor() { }

	[CompilerGenerated]
	internal string[] get_Options() { }

	public void set_CompileSynchronously(bool value) { }

	public void set_Debug(bool value) { }

	public void set_DisableDirectCall(bool value) { }

	public void set_DisableSafetyChecks(bool value) { }

	[CompilerGenerated]
	public void set_FloatMode(FloatMode value) { }

	[CompilerGenerated]
	public void set_FloatPrecision(FloatPrecision value) { }

	[CompilerGenerated]
	public void set_OptimizeFor(OptimizeFor value) { }

	[CompilerGenerated]
	internal void set_Options(string[] value) { }

}

