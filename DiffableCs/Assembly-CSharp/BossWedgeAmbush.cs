//Type is in global namespace

public class BossWedgeAmbush : BaseWedgeLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public BossWedgeAmbush <>4__this; //Field offset: 0x10
		public Func standardFind; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal CustomNavigationPoint <FindPoint>b__0(CoverSearchData d) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__IsShootCoverPoint; //Field offset: 0x0

	}

	private bool _isGetHitted; //Field offset: 0xB0

	public BossWedgeAmbush(BotOwner bot, int priority) { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndAttackMoving() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromCover() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func standardFind, bool checkCurrent) { }

	public virtual AICoreActionResult GetDecision() { }

	private static bool IsShootCoverPoint(GroupPoint point) { }

	public virtual string Name() { }

	private void OnGetHit(DamageInfo arg1, EBodyPart arg2, float arg3) { }

	public virtual bool ShallUseNow() { }

}

