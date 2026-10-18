//Type is in global namespace

[CreateAssetMenu(fileName = "CutsceneTriggerStartInfoSO", menuName = "ScriptableObjects/CutsceneTriggerStartInfoSO")]
public class CutsceneTriggerStartInfoSO : ScriptableObject
{
	internal class CutsceneIDWithStartValues
	{
		public int cutsceneID; //Field offset: 0x10
		public StartPlayerValues startValues; //Field offset: 0x18

		public CutsceneIDWithStartValues() { }

	}

	internal class SceneCutscenesInfoRelation
	{
		public string sceneName; //Field offset: 0x10
		public List cutsceneTriggersStartInfo; //Field offset: 0x18

		public SceneCutscenesInfoRelation() { }

	}

	internal class StartPlayerValues
	{
		public Vector3 startPosition; //Field offset: 0x10
		public Vector3 startViewDirection; //Field offset: 0x1C
		public float startPlayerPosLevel; //Field offset: 0x28
		public bool needToProneAtStart; //Field offset: 0x2C
		public Vector3 cutsceneEndPlayerPos; //Field offset: 0x30

		public StartPlayerValues() { }

	}

	private static CutsceneTriggerStartInfoSO _instance; //Field offset: 0x0
	[SerializeField]
	private List infoByScenes; //Field offset: 0x18
	private Dictionary infoByScenesDictionary; //Field offset: 0x20
	private Dictionary infoByScenesDictionaryByHash; //Field offset: 0x28

	public static CutsceneTriggerStartInfoSO Instance
	{
		 get { } //Length: 426
	}

	public CutsceneTriggerStartInfoSO() { }

	public static CutsceneTriggerStartInfoSO get_Instance() { }

	public StartPlayerValues GetPlayerStartInfo(string sceneName, int cutsceneID) { }

	public StartPlayerValues GetPlayerStartInfo(int sceneNameHash, int cutsceneID) { }

	private void Initialize() { }

}

