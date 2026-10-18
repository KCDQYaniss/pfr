namespace EFT.Dialogs;

public interface ISaveStateStorage
{

	public int GetVariableValue(MongoID variableId) { }

	public void SetVariableValue(SaveStateData saveData) { }

}

