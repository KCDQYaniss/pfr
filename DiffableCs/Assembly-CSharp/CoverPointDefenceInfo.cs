//Type is in global namespace

public class CoverPointDefenceInfo
{
	[SerializeField]
	private float _defenceLevel; //Field offset: 0x10
	[SerializeField]
	private int distanceCheckSum; //Field offset: 0x14

	public int DangerCoeff
	{
		 get { } //Length: 4
	}

	public float DefenceLevel
	{
		 get { } //Length: 6
	}

	public CoverPointDefenceInfo(int defLevel) { }

	public CoverPointDefenceInfo(Vector3 position) { }

	public int get_DangerCoeff() { }

	public float get_DefenceLevel() { }

	public bool IsSafe() { }

	public void OverrideData(float defenceLevel, int dangerCoeff) { }

	public void SetDefenceLevel(float deffCoeff) { }

}

