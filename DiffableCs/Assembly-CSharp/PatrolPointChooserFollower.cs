//Type is in global namespace

public class PatrolPointChooserFollower : PatrolPointChooserBasic
{

	public PatrolPointChooserFollower(BotOwner owner) { }

	public virtual PatrolPointContainer FindNextPoint(bool withSetting, bool withoutNext, int minSubTargets = -1, bool canCut = true, PatrolPointFilterDelegate pointFilter = null) { }

	protected virtual bool TryToFindWay(out PatrolWay way, out float delta) { }

}

