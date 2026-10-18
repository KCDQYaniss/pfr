//Type is in global namespace

public interface IDisablerCullingObjectEditor
{

	public void EditorSetComponentsToTurnOff(Component[] components) { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public Component[] GetComponentsInChildren(Type t, bool includeInactive) { }

	public void ResetComponentsToDefaults() { }

	public void SortComponentsToTurnOff() { }

}

