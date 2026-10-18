namespace Dissonance.Networking.Client;

internal interface ISendQueue`1
{

	public void EnqeueUnreliable(ArraySegment packet) { }

	public void EnqueueReliable(ArraySegment packet) { }

	public void EnqueueReliableP2P(ushort localId, IList destinations, ArraySegment packet) { }

	public void EnqueueUnreliableP2P(ushort localId, IList destinations, ArraySegment packet) { }

	public byte[] GetSendBuffer() { }

	public void RecycleSendBuffer(byte[] buffer) { }

}

