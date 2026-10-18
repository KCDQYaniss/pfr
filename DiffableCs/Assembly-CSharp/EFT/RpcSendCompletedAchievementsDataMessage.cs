namespace EFT;

public sealed class RpcSendCompletedAchievementsDataMessage : ISerializableMessage
{
	[CompilerGenerated]
	private CompletedAchievementConditionsData <Data>k__BackingField; //Field offset: 0x10

	public CompletedAchievementConditionsData Data
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public RpcSendCompletedAchievementsDataMessage() { }

	public RpcSendCompletedAchievementsDataMessage(CompletedAchievementConditionsData data) { }

	public override void Deserialize(NetworkReader reader) { }

	[CompilerGenerated]
	public CompletedAchievementConditionsData get_Data() { }

	public override void Serialize(NetworkWriter writer) { }

	[CompilerGenerated]
	public void set_Data(CompletedAchievementConditionsData value) { }

}

