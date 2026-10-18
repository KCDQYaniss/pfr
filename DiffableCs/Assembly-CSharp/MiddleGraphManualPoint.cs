//Type is in global namespace

public class MiddleGraphManualPoint : MonoBehaviour, IMiddleGraphPointIncome, IAICorePointLink
{
	[SerializeField]
	private AICorePoint _corePoint; //Field offset: 0x20

	public override AICorePoint CorePointInGame
	{
		 get { } //Length: 5
	}

	public override Vector3 Position
	{
		 get { } //Length: 204
	}

	public MiddleGraphManualPoint() { }

	public override AICorePoint get_CorePointInGame() { }

	public override Vector3 get_Position() { }

	private void OnDrawGizmosSelected() { }

	public void SetCore(AICorePoint cp) { }

}

