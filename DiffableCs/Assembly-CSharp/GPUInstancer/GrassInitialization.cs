namespace GPUInstancer;

public sealed class GrassInitialization : MonoBehaviour
{
	private const string INDEX_BUFFER_NAME = "_ArrayIndexBuffer"; //Field offset: 0x0
	[SerializeField]
	private Transform GrassParent; //Field offset: 0x20
	[SerializeField]
	private GPUInstancerPrefab prefab; //Field offset: 0x28
	[SerializeField]
	private List PrefabList; //Field offset: 0x30
	[SerializeField]
	private List DryColor; //Field offset: 0x38
	[SerializeField]
	private List HealthyColor; //Field offset: 0x40
	[SerializeField]
	private List WinterColors; //Field offset: 0x48
	[SerializeField]
	private List SeasonsColors; //Field offset: 0x50
	[SerializeField]
	private string FileName; //Field offset: 0x58

	private string FilePath
	{
		private get { } //Length: 178
	}

	private static string FolderPath
	{
		private get { } //Length: 157
	}

	public GrassInitialization() { }

	private void Awake() { }

	private string get_FilePath() { }

	private static string get_FolderPath() { }

	internal void SetSeasonsMaterials(ESeason season) { }

}

