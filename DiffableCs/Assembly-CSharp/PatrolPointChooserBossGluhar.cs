//Type is in global namespace

public class PatrolPointChooserBossGluhar : PatrolPointChooserBasic
{
	private readonly string _nameAlt; //Field offset: 0x28
	private readonly string _name; //Field offset: 0x30
	private readonly IGetProfileData _data; //Field offset: 0x38
	private bool _alternativeMode; //Field offset: 0x40

	public PatrolPointChooserBossGluhar(BotOwner owner, IGetProfileData data, string name, string nameAlt) { }

	[CompilerGenerated]
	private bool <TryToFindWay>b__8_0(PatrolWay x) { }

	private void DebugEditorPatrolsState() { }

	public virtual void Dispose() { }

	public virtual PatrolPointContainer FindNextPoint(bool withSetting, bool withoutNext, int minSubTargets = -1, bool canCut = true, PatrolPointFilterDelegate pointFilter = null) { }

	public virtual bool IsWaySuitableByNameId(string nameTest) { }

	private void OnTrainCome(ETravelState obj) { }

	protected virtual bool TryToFindWay(out PatrolWay way, out float delta) { }

}

