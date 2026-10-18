namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionPainEffectActivate : CutsceneBaseAction
{
	private Coroutine _coroutine; //Field offset: 0x40
	[SerializeField]
	private float _residueTime; //Field offset: 0x48
	[SerializeField]
	private float _strength; //Field offset: 0x4C
	[SerializeField]
	private Vector2 _strengthRange; //Field offset: 0x50

	public CutsceneActionPainEffectActivate() { }

	public virtual void Deinit() { }

	public virtual void Init() { }

}

