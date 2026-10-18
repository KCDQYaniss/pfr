namespace EFT;

public sealed class CommonPacket
{
	public Nullable SyncPositionPacket; //Field offset: 0x10
	public Nullable SwitchRenderersPacket; //Field offset: 0x28
	public Nullable ChangeSkillLevelPacket; //Field offset: 0x30
	public Nullable ChangeMasteringLevelPacket; //Field offset: 0x50

	public CommonPacket() { }

	public void AddChangeMasteringLevelPacket(string groupName, float value) { }

	public void AddChangeSkillLevelPacket(byte skillId, float value, float effectiveness, float pointsEarned) { }

	public void AddSwitchRenderersPacket(bool value) { }

	public void AddSyncPositionPacket(byte iteration, Vector3 position, SyncPositionReason reason) { }

	public static CommonPacket Deserialize(IBitReaderStream reader) { }

	public virtual string ToString() { }

}

