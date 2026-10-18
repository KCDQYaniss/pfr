//Type is in global namespace

public class PatrolPointChooserByData : PatrolPointChooserBasic
{
	private readonly IGetProfileData _data; //Field offset: 0x28

	public PatrolPointChooserByData(BotOwner owner, IGetProfileData data) { }

	[CompilerGenerated]
	private bool <TryToFindWay>b__3_0(PatrolWay x) { }

	public virtual PatrolPointContainer FindNextPoint(bool withSetting, bool withoutNext, int minSubTargets = -1, bool canCut = true, PatrolPointFilterDelegate pointFilter = null) { }

	protected virtual bool TryToFindWay(out PatrolWay way, out float delta) { }

}

