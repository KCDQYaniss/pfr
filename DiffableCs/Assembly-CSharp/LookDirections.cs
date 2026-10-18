//Type is in global namespace

public class LookDirections : MonoBehaviour
{
	public bool UseLookSide; //Field offset: 0x20
	public Vector3 dir; //Field offset: 0x24

	public bool HaveLookSide
	{
		 get { } //Length: 5
	}

	public int LookIndexes
	{
		 get { } //Length: 9
	}

	public Vector3 Position
	{
		 get { } //Length: 204
	}

	public LookDirections() { }

	public bool get_HaveLookSide() { }

	public int get_LookIndexes() { }

	public Vector3 get_Position() { }

	public int GetOwnerId() { }

	public void NormalizeLookSide() { }

	public void OnDrawGizmosSelected() { }

	public void SetOwner(BotOwner owner) { }

}

