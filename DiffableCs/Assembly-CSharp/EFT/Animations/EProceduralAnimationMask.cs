namespace EFT.Animations;

[Flags]
public enum EProceduralAnimationMask
{
	Breathing = 1,
	Walking = 2,
	MotionReaction = 4,
	ForceReaction = 8,
	Shooting = 16,
	DrawDown = 32,
	Aiming = 64,
	HandShake = 128,
}

