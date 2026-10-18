namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionGameplayFadeIn : CutsceneBaseAction
{
	public float speed; //Field offset: 0x40
	public bool instant; //Field offset: 0x44

	public CutsceneActionGameplayFadeIn() { }

	public virtual void Init() { }

}

