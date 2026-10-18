//Type is in global namespace

[RequireComponent(typeof(NavMeshObstacle))]
public class NavMeshObstacleWrap : MonoBehaviour
{
	public ENavMeshObstacleType Type; //Field offset: 0x20
	public NavMeshObstacle NavMeshObstacle; //Field offset: 0x28

	public bool Carving
	{
		 get { } //Length: 203
		 set { } //Length: 106
	}

	public NavMeshObstacleWrap() { }

	public bool get_Carving() { }

	public void set_Carving(bool value) { }

}

