namespace Dissonance.Networking;

internal interface IReadonlyClientIdCollection
{

	public Nullable GetId(string name) { }

	[CanBeNull]
	public string GetName(ushort id) { }

}

