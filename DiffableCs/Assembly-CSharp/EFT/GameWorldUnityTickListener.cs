namespace EFT;

public sealed class GameWorldUnityTickListener : MonoBehaviour
{
	private GameWorld gameWorld; //Field offset: 0x20

	public GameWorldUnityTickListener() { }

	public static GameWorldUnityTickListener Create(GameObject gameObject, GameWorld gameWorld) { }

	public void FixedUpdate() { }

	public void LateUpdate() { }

	public void Update() { }

}

