namespace Dissonance.Networking.Client;

internal interface ISession
{

	public Nullable LocalId
	{
		 get { } //Length: 0
	}

	[NotNull]
	public string LocalName
	{
		 get { } //Length: 0
	}

	public uint SessionId
	{
		 get { } //Length: 0
	}

	public Nullable get_LocalId() { }

	public string get_LocalName() { }

	public uint get_SessionId() { }

}

