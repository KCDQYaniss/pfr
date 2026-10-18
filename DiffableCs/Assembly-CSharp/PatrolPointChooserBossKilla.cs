//Type is in global namespace

public class PatrolPointChooserBossKilla : PatrolPointChooserBasic
{
	private readonly string _nameAlt; //Field offset: 0x28
	private readonly IGetProfileData _data; //Field offset: 0x30
	private readonly BossKilla _bossKilla; //Field offset: 0x38

	public PatrolPointChooserBossKilla(BotOwner owner, IGetProfileData data, string nameAlt) { }

	[CompilerGenerated]
	private bool <TryToFindWay>b__5_0(PatrolWay x) { }

	private void DebugEditorPatrolsState() { }

	public virtual bool IsWaySuitableByNameId(string nameTest) { }

	private void OnAlarmChange(bool obj) { }

	protected virtual bool TryToFindWay(out PatrolWay way, out float delta) { }

}

