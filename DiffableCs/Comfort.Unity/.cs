//Type is in global namespace

internal interface  : , , ICommunicationErrorHandler
{

	public event Action OnError
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public ITypesRegistry 
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnError(Action value) { }

	public ITypesRegistry get_() { }

	[CompilerGenerated]
	public void remove_OnError(Action value) { }

	public ProxyFactory (Type ) { }

	public  (Type ) { }

	public void (Type , ProxyFactory ) { }

	public void (Type , Func ) { }

}

