//Type is in global namespace

public class CutsceneActionWaterEffectActivate : CutsceneBaseAction
{
	[SerializeField]
	private float _intensity; //Field offset: 0x40
	[SerializeField]
	private float _speed; //Field offset: 0x44

	public CutsceneActionWaterEffectActivate() { }

	public virtual void Deinit() { }

	public virtual void Init() { }

}

