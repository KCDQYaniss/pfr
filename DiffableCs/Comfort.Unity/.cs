//Type is in global namespace

internal sealed class  : IRemoteCommunicator
{
	private CommunicationId ; //Field offset: 0x10
	private readonly IPipe ; //Field offset: 0x20

	private (ref CommunicationId , IPipe ) { }

	internal static  Create(ref CommunicationId id, IPipe pipe) { }

	public override void Register(CommunicationId id, bool unreliable) { }

	public override void Register(CommunicationId[] reliableIds, CommunicationId[] unreliableIds) { }

	public override void Unregister(CommunicationId id) { }

	public override void Unregister(CommunicationId[] ids) { }

	public override void Validate(CommunicatorDefinition definition) { }

	private static void (BinaryWriter , ICollection ) { }

	private void () { }

}

