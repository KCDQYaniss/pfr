//Type is in global namespace

[CreateAssetMenu]
public sealed class EFTBackendSettings : ScriptableObject
{
	internal struct BackendUrl : IComparable
	{
		public string Url; //Field offset: 0x0
		public EBackendLabel Label; //Field offset: 0x8

		public BackendUrl(string url, EBackendLabel label) { }

		public override int CompareTo(BackendUrl other) { }

		public bool Equals(BackendUrl other) { }

		public virtual bool Equals(object obj) { }

		public virtual int GetHashCode() { }

		public virtual string ToString() { }

	}

	internal enum EBackendLabel
	{
		Production = 0,
		Stage = 1,
		Development = 2,
		Custom = 3,
		Unknown = 4,
	}

	private const string EFT_BACKEND_URLS_ASSET_NAME = "EFTBackendURLs"; //Field offset: 0x0
	private const string SELECTED_BACKEND_URL = "EscapeFromTarkov/selectedBackendUrl"; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly EFTBackendSettings <Instance>k__BackingField; //Field offset: 0x0
	[SerializeField]
	public BackendUrl[] AvailableUrls; //Field offset: 0x18
	[CompilerGenerated]
	private string <SelectedBackendUrl>k__BackingField; //Field offset: 0x20

	public static EFTBackendSettings Instance
	{
		[CompilerGenerated]
		 get { } //Length: 59
	}

	private string SelectedBackendLabelEditorPrefsPath
	{
		private get { } //Length: 157
	}

	public string SelectedBackendUrl
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private string SelectedBackendUrlEditorPrefsPath
	{
		private get { } //Length: 157
	}

	public EFTBackendSettings() { }

	[CompilerGenerated]
	public static EFTBackendSettings get_Instance() { }

	private string get_SelectedBackendLabelEditorPrefsPath() { }

	[CompilerGenerated]
	public string get_SelectedBackendUrl() { }

	private string get_SelectedBackendUrlEditorPrefsPath() { }

	public void Reset() { }

	[CompilerGenerated]
	public void set_SelectedBackendUrl(string value) { }

}

