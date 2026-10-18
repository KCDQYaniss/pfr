namespace CommonAssets.Scripts.Cutscenes;

public class CutsceneActionUndressEquipInScene : CutsceneBaseAction
{
	private List _results; //Field offset: 0x40
	private readonly IEnumerable _slotsToUndress; //Field offset: 0x48

	public CutsceneActionUndressEquipInScene() { }

	public virtual void Deinit() { }

	public virtual void Init() { }

}

