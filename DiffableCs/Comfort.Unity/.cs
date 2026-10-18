//Type is in global namespace

internal class  : ICommunicationErrorHandler
{
	private readonly List ; //Field offset: 0x10

	public override event Action OnError
	{
		 add { } //Length: 243
		 remove { } //Length: 250
	}

	protected (Action  = null) { }

	public override void add_OnError(Action value) { }

	public override void Error(string message) { }

	public override void Error(Exception e) { }

	public override void ErrorFormat(string format, object[] params) { }

	public override void remove_OnError(Action value) { }

	protected void (string ) { }

}

