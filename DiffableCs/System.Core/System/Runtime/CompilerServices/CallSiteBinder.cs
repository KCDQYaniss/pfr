namespace System.Runtime.CompilerServices;

public abstract class CallSiteBinder
{
	private sealed class LambdaSignature`1
	{
		private static LambdaSignature s_instance; //Field offset: 0x0
		internal readonly ReadOnlyCollection Parameters; //Field offset: 0x0
		internal readonly LabelTarget ReturnLabel; //Field offset: 0x0

		internal static LambdaSignature Instance
		{
			internal get { } //Length: 450
		}

		private LambdaSignature`1() { }

		internal static LambdaSignature get_Instance() { }

	}

	[CompilerGenerated]
	private static readonly LabelTarget <UpdateLabel>k__BackingField; //Field offset: 0x0
	internal Dictionary Cache; //Field offset: 0x10

	public static LabelTarget UpdateLabel
	{
		[CompilerGenerated]
		 get { } //Length: 83
	}

	private static CallSiteBinder() { }

	protected CallSiteBinder() { }

	public abstract Expression Bind(object[] args, ReadOnlyCollection parameters, LabelTarget returnLabel) { }

	internal T BindCore(CallSite site, object[] args) { }

	public override T BindDelegate(CallSite site, object[] args) { }

	protected void CacheTarget(T target) { }

	[CompilerGenerated]
	public static LabelTarget get_UpdateLabel() { }

	internal RuleCache GetRuleCache() { }

	private static Expression Stitch(Expression binding, LambdaSignature signature) { }

}

