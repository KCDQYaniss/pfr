namespace EFT.Trading;

public sealed class LightkeeperDialogReaction : TraderAnimationController
{
	private static readonly MongoID _disabledAfterZryachiyKilledDialogId; //Field offset: 0x0
	private static readonly MongoID _disabledAfterPlayerKilledDialogId; //Field offset: 0x18
	private static readonly MongoID _kickSoonDialogId; //Field offset: 0x30
	private static readonly MongoID _timeEndingWarningDialogId; //Field offset: 0x48

	private static LightkeeperDialogReaction() { }

	public LightkeeperDialogReaction(NPCObject npc, ClientDialogController dialogController) { }

	public void BufferZoneStateChanged(EZoneState state) { }

	private void StartKeeperGlobalEventDialog(MongoID dialogId) { }

}

