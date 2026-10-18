namespace EFT.Vehicle;

[ExecuteInEditMode]
public class MapPathConfig : MonoBehaviour
{
	public BTRMapPath PathsConfiguration; //Field offset: 0x20
	public List PathSplines; //Field offset: 0x70
	public List PathDestinations; //Field offset: 0x78
	public Vector3 DepotPosition; //Field offset: 0x80

	public MapPathConfig() { }

	public PathSpline AddNewPartSpline() { }

	public PathDestination AddNewPathDestination() { }

	public PathSpline CreateNewPathSpline() { }

	public void DeletePartSpline(PathSpline pathSpline) { }

	public void DeletePathDestination(PathDestination pathDestination) { }

	public PathPartBase GetPartPathByID(string id) { }

	public Dictionary GetPathParts(List partsID) { }

	public PathSpline GetPathSplineByPoints(string currentDestinationPointID, string targetDestinationPointID) { }

	public string MakePathSplineIDByPoints(string p1ID, string p2ID) { }

	public void SetMapPathConfigsFromServerData(BTRMapPath pathConfig) { }

}

