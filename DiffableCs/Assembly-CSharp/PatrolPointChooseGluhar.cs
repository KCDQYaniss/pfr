//Type is in global namespace

public class PatrolPointChooseGluhar : PatrolPointChooseByName
{
	private readonly string _nameAlt; //Field offset: 0x38
	private bool _alternativeMode; //Field offset: 0x40
	private readonly IBossToFollow _bossToFollow; //Field offset: 0x48

	public PatrolPointChooseGluhar(BotOwner owner, IGetProfileData data, string name, string nameAlt, IBossToFollow bossToFollow) { }

	[CompilerGenerated]
	private bool <TryToFindWay>b__6_0(PatrolWay x) { }

	private PatrolPointContainer ClosestAtCurrentWay() { }

	public virtual void Dispose() { }

	private PatrolPointContainer FindClosestToBoss() { }

	public virtual PatrolPointContainer FindNextPoint(bool withSetting, bool withoutNext, int minSubTargets = -1, bool canCut = true, PatrolPointFilterDelegate pointFilter = null) { }

	protected virtual string GetDebugName() { }

	public virtual bool IsWaySuitableByNameId(string nameId) { }

	private void OnTrainCome(ETravelState obj) { }

	protected virtual bool TryToFindWay(out PatrolWay way, out float delta) { }

}

