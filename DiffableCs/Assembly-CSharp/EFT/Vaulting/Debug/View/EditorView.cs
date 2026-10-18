namespace EFT.Vaulting.Debug.View;

public class EditorView : MonoBehaviour
{
	private EditorGridView _editorGridView; //Field offset: 0x20
	private EditorApproximationView _editorApproximationView; //Field offset: 0x28

	public EditorApproximationView EditorApproximationView
	{
		 get { } //Length: 5
	}

	public EditorGridView EditorGridView
	{
		 get { } //Length: 5
	}

	public EditorView() { }

	public EditorApproximationView get_EditorApproximationView() { }

	public EditorGridView get_EditorGridView() { }

	private void OnDisable() { }

	private void OnEnable() { }

}

