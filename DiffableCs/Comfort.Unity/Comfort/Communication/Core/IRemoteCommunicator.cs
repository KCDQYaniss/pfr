namespace Comfort.Communication.Core;

[RemoteProcedure]
public interface IRemoteCommunicator
{

	public void Register(CommunicationId id, bool unreliable) { }

	public void Register(CommunicationId[] reliableIds, CommunicationId[] unreliableIds) { }

	public void Unregister(CommunicationId id) { }

	public void Unregister(CommunicationId[] ids) { }

	public void Validate(CommunicatorDefinition definition) { }

}

