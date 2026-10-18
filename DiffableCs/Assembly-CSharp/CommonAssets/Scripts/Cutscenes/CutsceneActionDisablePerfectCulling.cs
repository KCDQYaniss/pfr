namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionDisablePerfectCulling : CutsceneBaseAction
{
	private bool _previousDisableWorkThread; //Field offset: 0x40
	private bool _hasPreviousState; //Field offset: 0x41

	public CutsceneActionDisablePerfectCulling() { }

	public virtual void Deinit() { }

	public virtual void Init() { }

}

