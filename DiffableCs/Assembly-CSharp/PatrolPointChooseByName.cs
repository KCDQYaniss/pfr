//Type is in global namespace

public class PatrolPointChooseByName : PatrolPointChooserBasic
{
	protected IGetProfileData _data; //Field offset: 0x28
	protected string _nameId; //Field offset: 0x30

	public PatrolPointChooseByName(BotOwner owner, IGetProfileData data, string name) { }

	[CompilerGenerated]
	private bool <TryToFindWay>b__5_0(PatrolWay x) { }

	public virtual PatrolPointContainer FindNextPoint(bool withSetting, bool withoutNext, int minSubTargets = -1, bool canCut = true, PatrolPointFilterDelegate pointFilter = null) { }

	protected override string GetDebugName() { }

	public virtual bool IsWaySuitableByNameId(string nameId) { }

	protected virtual bool TryToFindWay(out PatrolWay way, out float delta) { }

}

