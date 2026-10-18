//Type is in global namespace

public class BoarAvoidDangerLayer : AvoidDangerLayer
{
	private List _possiblePoints; //Field offset: 0x98
	private bool _tryUseCache; //Field offset: 0xA0
	private float _nextResuffle; //Field offset: 0xA4

	public BoarAvoidDangerLayer(BotOwner bot, int priority) { }

	[CompilerGenerated]
	private bool <PreCacheCovers>b__4_0(GroupPoint x) { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	public virtual string Name() { }

	private void PreCacheCovers() { }

}

