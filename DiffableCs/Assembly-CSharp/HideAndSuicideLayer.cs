//Type is in global namespace

public class HideAndSuicideLayer : AbstractSectantLayerFight
{
	private const float DIST_TO_SUCIDE = 10; //Field offset: 0x0
	private bool _doGrenade; //Field offset: 0x90
	private float _suicidePeriod; //Field offset: 0x94
	private bool _isInside; //Field offset: 0x98

	public HideAndSuicideLayer(BotOwner bot, int priority) { }

	private void BeingHitAction(DamageInfo arg1, EBodyPart arg2, float arg3) { }

	private bool CanDoSuicide() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	protected virtual void OnActivate() { }

	public void SetInside(bool isInside) { }

	private bool ShallDoSuicide() { }

	public virtual bool ShallUseNow() { }

}

