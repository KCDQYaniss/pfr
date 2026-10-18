//Type is in global namespace

public class AIPlaceInfoLogicGoToTarget : AIPlaceInfo
{
	public List GoTo; //Field offset: 0x88
	private bool _isEntered; //Field offset: 0x90
	[SerializeField]
	private Vector3 _center; //Field offset: 0x94

	public Vector3 GetCenter
	{
		 get { } //Length: 25
	}

	public AIPlaceInfoLogicGoToTarget() { }

	public virtual void EditorCheck() { }

	public Vector3 get_GetCenter() { }

	public Nullable GetGoToPosition() { }

	private void OnDrawGizmosSelected() { }

	protected virtual void OnEnterPlace(Player player) { }

}

