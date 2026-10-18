namespace Comfort.Communication;

public sealed class CommunicatorFactory
{
	[CompilerGenerated]
	private sealed class `1
	{
		public InterfaceFactory ; //Field offset: 0x0

		public `1() { }

		internal object (Delegate[] ) { }

	}

	private readonly  ; //Field offset: 0x10

	public event Action OnError
	{
		 add { } //Length: 93
		 remove { } //Length: 93
	}

	public ITypesRegistry TypesRegistry
	{
		 get { } //Length: 75
	}

	private CommunicatorFactory( ) { }

	public void add_OnError(Action value) { }

	public static CommunicatorFactory Create(Action errorCallback = null) { }

	public static CommunicatorFactory Create(Action errorCallback = null) { }

	public static CommunicatorFactory Create(Action errorCallback = null) { }

	public static CommunicatorFactory Create(Type[] types) { }

	public static CommunicatorFactory Create(ITypesRegistry registry, Action errorCallback = null) { }

	public ICommunicator CreateCommunicator(Action errorHandler = null) { }

	public ITypesRegistry get_TypesRegistry() { }

	public void RegisterProxyFactory(Type type, ProxyFactory factory) { }

	public void RegisterProxyFactory(ProxyFactory factory) { }

	public void RegisterProxyFactory(InterfaceFactory interfaceFactory) { }

	public void remove_OnError(Action value) { }

}

