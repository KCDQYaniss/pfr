namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionDamageEffect : CutsceneBaseAction
{
	[SerializeField]
	private float _value; //Field offset: 0x40

	public CutsceneActionDamageEffect() { }

	public virtual void Deinit() { }

	public virtual void Init() { }

}

