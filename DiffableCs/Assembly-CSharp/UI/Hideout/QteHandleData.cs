namespace UI.Hideout;

public class QteHandleData : QteData
{
	internal enum EPropsTarget
	{
		LeftPalm = 0,
		RightPalm = 1,
	}

	internal class PropsData
	{
		public EPropsTarget Target; //Field offset: 0x10
		public GameObject Prefab; //Field offset: 0x18
		public Vector3 Position; //Field offset: 0x20
		public Vector3 Rotation; //Field offset: 0x2C

		public PropsData() { }

	}

	internal class PropsVariantData : PropsData
	{
		public int Trigger; //Field offset: 0x38

		public PropsVariantData() { }

	}

	[SerializeField]
	public Vector3 PlayerPosition; //Field offset: 0x40
	[SerializeField]
	public Vector3 PlayerRotation; //Field offset: 0x4C
	[SerializeField]
	[Space(10)]
	public List Props; //Field offset: 0x58
	[SerializeField]
	[Space(10)]
	public RuntimeAnimatorController HideoutAnimatorController; //Field offset: 0x60
	[Space(10)]
	public Dictionary Sounds; //Field offset: 0x68

	public QteHandleData(QteData backendData) { }

}

