namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionToggleLocationSceneObject : CutsceneBaseAction
{
	public string overrideCutsceneId; //Field offset: 0x40
	private CutsceneObjects _cutsceneObjects; //Field offset: 0x48

	public CutsceneActionToggleLocationSceneObject() { }

	public virtual void Deinit() { }

	private CutsceneObjects FindCutsceneObjects() { }

	public virtual void Init() { }

}

