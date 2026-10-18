namespace RootMotion;

public static class BipedNaming
{
	internal enum BoneSide
	{
		Center = 0,
		Left = 1,
		Right = 2,
	}

	internal enum BoneType
	{
		Unassigned = 0,
		Spine = 1,
		Head = 2,
		Arm = 3,
		Leg = 4,
		Tail = 5,
		Eye = 6,
	}

	public static string[] typeLeft; //Field offset: 0x0
	public static string[] typeRight; //Field offset: 0x8
	public static string[] typeSpine; //Field offset: 0x10
	public static string[] typeHead; //Field offset: 0x18
	public static string[] typeArm; //Field offset: 0x20
	public static string[] typeLeg; //Field offset: 0x28
	public static string[] typeTail; //Field offset: 0x30
	public static string[] typeEye; //Field offset: 0x38
	public static string[] typeExclude; //Field offset: 0x40
	public static string[] typeExcludeSpine; //Field offset: 0x48
	public static string[] typeExcludeHead; //Field offset: 0x50
	public static string[] typeExcludeArm; //Field offset: 0x58
	public static string[] typeExcludeLeg; //Field offset: 0x60
	public static string[] typeExcludeTail; //Field offset: 0x68
	public static string[] typeExcludeEye; //Field offset: 0x70
	public static string[] pelvis; //Field offset: 0x78
	public static string[] hand; //Field offset: 0x80
	public static string[] foot; //Field offset: 0x88

	private static BipedNaming() { }

	private static bool excludesNaming(string boneName, string[] namingConvention) { }

	private static string firstLetter(string boneName) { }

	public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = 0, string[][] namings) { }

	public static BoneSide GetBoneSide(string boneName) { }

	public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones) { }

	public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones) { }

	public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones) { }

	public static BoneType GetBoneType(string boneName) { }

	public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones) { }

	public static Transform GetNamingMatch(Transform[] transforms, string[][] namings) { }

	private static bool isArm(string boneName) { }

	private static bool isEye(string boneName) { }

	private static bool isHead(string boneName) { }

	private static bool isLeft(string boneName) { }

	private static bool isLeg(string boneName) { }

	private static bool isRight(string boneName) { }

	private static bool isSpine(string boneName) { }

	private static bool isTail(string boneName) { }

	private static bool isTypeExclude(string boneName) { }

	private static string lastLetter(string boneName) { }

	private static bool LastLetterIs(string boneName, string letter) { }

	private static bool matchesLastLetter(string boneName, string[] namingConvention) { }

	private static bool matchesNaming(string boneName, string[] namingConvention) { }

}

