namespace EFT.UI.Settings;

[Flags]
public enum EUsageProperty
{
	None = 0,
	Cpu = 1,
	Gpu = 2,
	Ram = 4,
	CpuGpu = 3,
	CpuRam = 5,
	GpuRam = 6,
	CpuGpuRam = 7,
}

