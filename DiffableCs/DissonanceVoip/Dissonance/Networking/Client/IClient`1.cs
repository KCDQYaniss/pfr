namespace Dissonance.Networking.Client;

internal interface IClient`1
{

	public void SendReliable(ArraySegment arraySegment) { }

	public void SendReliableP2P(List destinations, ArraySegment packet) { }

	public void SendUnreliable(ArraySegment arraySegment) { }

	public void SendUnreliableP2P(List destinations, ArraySegment packet) { }

}

