namespace EFT;

public class ScenesPreset : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <GetTotalSceneCount>b__16_0(ScenesPreset x) { }

	}

	internal class Guid : ISceneResource
	{
		public string guid; //Field offset: 0x10
		[SerializeField]
		private bool _onlyOffline; //Field offset: 0x18

		public override bool onlyOffline
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public Guid(string guid, bool onlyOffline) { }

		public override bool get_onlyOffline() { }

		public void set_onlyOffline(bool value) { }

	}

	public Guid ActiveSceneGuid; //Field offset: 0x18
	public string ServerName; //Field offset: 0x20
	public List ScenesGuids; //Field offset: 0x28
	private bool _disableServerScenes; //Field offset: 0x30
	public ScenesPreset[] ChildPresets; //Field offset: 0x38
	[FormerlySerializedAs("ActiveSceneName")]
	[SerializeField]
	private string _activeSceneName; //Field offset: 0x40
	[FormerlySerializedAs("ScenesResourceKeys")]
	[SerializeField]
	private List _scenesResourceKeys; //Field offset: 0x48

	public string ActiveSceneName
	{
		 get { } //Length: 5
	}

	public string PresetName
	{
		 get { } //Length: 119
	}

	public SceneResourceKey[] ScenesResourceKeys
	{
		 get { } //Length: 297
	}

	public ScenesPreset() { }

	public void DisableServerScenes(bool val) { }

	public string get_ActiveSceneName() { }

	public string get_PresetName() { }

	public SceneResourceKey[] get_ScenesResourceKeys() { }

	public int GetTotalSceneCount() { }

	private bool ShouldLoadScene(ISceneResource scene) { }

}

