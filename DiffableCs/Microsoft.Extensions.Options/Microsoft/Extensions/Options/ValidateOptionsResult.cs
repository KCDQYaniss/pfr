namespace Microsoft.Extensions.Options;

[Nullable(0)]
[NullableContext(1)]
public class ValidateOptionsResult
{
	public static readonly ValidateOptionsResult Skip; //Field offset: 0x0
	public static readonly ValidateOptionsResult Success; //Field offset: 0x8
	[CompilerGenerated]
	private bool <Succeeded>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <Skipped>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private bool <Failed>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	private IEnumerable <Failures>k__BackingField; //Field offset: 0x18

	[MemberNotNullWhen(True, "Failures")]
	[MemberNotNullWhen(True, "FailureMessage")]
	public bool Failed
	{
		[CompilerGenerated]
		[MemberNotNullWhen(True, "Failures")]
		[MemberNotNullWhen(True, "FailureMessage")]
		 get { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	public IEnumerable Failures
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected bool Skipped
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected bool Succeeded
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	private static ValidateOptionsResult() { }

	public ValidateOptionsResult() { }

	[CompilerGenerated]
	[MemberNotNullWhen(True, "Failures")]
	[MemberNotNullWhen(True, "FailureMessage")]
	public bool get_Failed() { }

	[CompilerGenerated]
	public IEnumerable get_Failures() { }

	[CompilerGenerated]
	protected void set_Skipped(bool value) { }

	[CompilerGenerated]
	protected void set_Succeeded(bool value) { }

}

