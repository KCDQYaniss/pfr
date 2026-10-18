//Type is in global namespace

public class PreviewPivot : MonoBehaviour
{
	internal class IconSettings
	{
		public Vector3 position; //Field offset: 0x10
		public bool hasOffset; //Field offset: 0x1C
		public Quaternion rotation; //Field offset: 0x20
		public float boundsScale; //Field offset: 0x30
		public float perspective; //Field offset: 0x34
		public bool orthographic; //Field offset: 0x38
		public float orthographicSize; //Field offset: 0x3C
		public Sprite overrideIcon; //Field offset: 0x40

		public IconSettings() { }

		public void Apply(IconSettings newSettings) { }

	}

	public Vector3 pivotPosition; //Field offset: 0x20
	public Quaternion pivotRotation; //Field offset: 0x2C
	public Vector3 scale; //Field offset: 0x3C
	public Vector3 SpawnPosition; //Field offset: 0x48
	public IconSettings Icon; //Field offset: 0x58

	public PreviewPivot() { }

	public void AutoAdjustPivot() { }

}

