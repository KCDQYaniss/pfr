namespace Microsoft.Extensions.DependencyInjection.ServiceLookup;

internal sealed class CallSiteChain
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__6_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <AppendResolutionPath>b__6_0(KeyValuePair a, KeyValuePair b) { }

	}

	[IsReadOnly]
	private struct ChainItemInfo
	{
		[CompilerGenerated]
		private readonly int <Order>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly Type <ImplementationType>k__BackingField; //Field offset: 0x8

		public Type ImplementationType
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public int Order
		{
			[CompilerGenerated]
			 get { } //Length: 3
		}

		public ChainItemInfo(int order, Type implementationType) { }

		[CompilerGenerated]
		public Type get_ImplementationType() { }

		[CompilerGenerated]
		public int get_Order() { }

	}

	private readonly Dictionary _callSiteChain; //Field offset: 0x10

	public CallSiteChain() { }

	[NullableContext(2)]
	public void Add(ServiceIdentifier serviceIdentifier, Type implementationType = null) { }

	private void AppendResolutionPath(StringBuilder builder, ServiceIdentifier currentlyResolving) { }

	public void CheckCircularDependency(ServiceIdentifier serviceIdentifier) { }

	private string CreateCircularDependencyExceptionMessage(ServiceIdentifier serviceIdentifier) { }

	public void Remove(ServiceIdentifier serviceIdentifier) { }

}

