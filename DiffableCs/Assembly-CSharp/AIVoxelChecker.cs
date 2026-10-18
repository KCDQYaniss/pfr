//Type is in global namespace

public class AIVoxelChecker : IVoxelChecker
{
	private NavGraphVoxelSimple _prevVoxel; //Field offset: 0x10
	private AICoversData _data; //Field offset: 0x18
	private BotOwner _owner; //Field offset: 0x20

	public AIVoxelChecker(BotOwner bot) { }

	public override void Dispose() { }

	private void OnBotStateChange(EBotState obj) { }

	public override void SetPos(Vector3 pos, bool withLogs = false) { }

	public override void TryDrawAffectionGizmos() { }

}

