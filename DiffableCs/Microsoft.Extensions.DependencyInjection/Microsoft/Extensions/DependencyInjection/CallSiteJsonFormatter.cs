namespace Microsoft.Extensions.DependencyInjection;

[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
[NullableContext(1)]
internal sealed class CallSiteJsonFormatter : CallSiteVisitor
{
	[Nullable(0)]
	public struct CallSiteFormatterContext
	{
		private readonly HashSet _processedCallSites; //Field offset: 0x0
		private bool _firstItem; //Field offset: 0x8
		[CompilerGenerated]
		private readonly int <Offset>k__BackingField; //Field offset: 0xC
		[CompilerGenerated]
		private readonly StringBuilder <Builder>k__BackingField; //Field offset: 0x10

		public StringBuilder Builder
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 5
		}

		public int Offset
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
		}

		public CallSiteFormatterContext(StringBuilder builder, int offset, HashSet processedCallSites) { }

		public void EndArray() { }

		public void EndObject() { }

		[CompilerGenerated]
		[IsReadOnly]
		public StringBuilder get_Builder() { }

		[CompilerGenerated]
		[IsReadOnly]
		public int get_Offset() { }

		public CallSiteFormatterContext IncrementOffset() { }

		public bool ShouldFormat(ServiceCallSite serviceCallSite) { }

		public CallSiteFormatterContext StartArray() { }

		public void StartArrayItem() { }

		public CallSiteFormatterContext StartObject() { }

		public void StartProperty(string name) { }

		public void WriteProperty(string name, object value) { }

	}

	internal static readonly CallSiteJsonFormatter Instance; //Field offset: 0x0

	private static CallSiteJsonFormatter() { }

	private CallSiteJsonFormatter() { }

	public string Format(ServiceCallSite callSite) { }

	protected virtual object VisitCallSiteMain(ServiceCallSite callSite, CallSiteFormatterContext argument) { }

	protected virtual object VisitConstant(ConstantCallSite constantCallSite, CallSiteFormatterContext argument) { }

	protected virtual object VisitConstructor(ConstructorCallSite constructorCallSite, CallSiteFormatterContext argument) { }

	protected virtual object VisitFactory(FactoryCallSite factoryCallSite, CallSiteFormatterContext argument) { }

	protected virtual object VisitIEnumerable(IEnumerableCallSite enumerableCallSite, CallSiteFormatterContext argument) { }

	protected virtual object VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, CallSiteFormatterContext argument) { }

}

