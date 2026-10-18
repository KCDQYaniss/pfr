//Type is in global namespace

public class CutsceneActionDisableLightEquipmentEffects : CutsceneBaseAction
{
	private List _changedTacticalLights; //Field offset: 0x40
	private List _tempTacticalLights; //Field offset: 0x48

	public CutsceneActionDisableLightEquipmentEffects() { }

	public virtual void Deinit() { }

	public virtual void Init() { }

}

