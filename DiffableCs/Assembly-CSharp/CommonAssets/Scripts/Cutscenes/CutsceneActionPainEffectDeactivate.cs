namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionPainEffectDeactivate : CutsceneBaseAction
{
	private Coroutine _coroutine; //Field offset: 0x40
	[SerializeField]
	private float _residueTime; //Field offset: 0x48

	public CutsceneActionPainEffectDeactivate() { }

	public virtual void Init() { }

}

