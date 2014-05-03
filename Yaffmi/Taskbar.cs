using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Yaffmi
{
	enum TaskbarProgressMode
	{
		NoProgress = 0x0,
		Indeterminate = 0x1,
		Normal = 0x2,
		Error = 0x4,
		Paused = 0x8,
	}

	static class Taskbar
	{
		enum TBPFLAG : uint
		{
			TBPF_NOPROGRESS = 0x00000000,
			TBPF_INDETERMINATE = 0x00000001,
			TBPF_NORMAL = 0x00000002,
			TBPF_ERROR = 0x00000004,
			TBPF_PAUSED = 0x00000008,
		}

		[ComImport]
		[Guid("C43DC798-95D1-4BEA-9030-BB99E2983A1A")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		interface ITaskbarList4
		{
			// If anyone knows of a way to directly specify a v-table offset, we could get rid of these stubs
			void Stub1();
			void Stub2();
			void Stub3();
			void Stub4();
			void Stub5();
			void Stub6();

			[PreserveSig]
			int SetProgressValue(IntPtr hwnd, ulong ullCompleted, ulong ullTotal);

			[PreserveSig]
			int SetProgressState(IntPtr hwnd, TBPFLAG tbpFlags);
		}

		[ComImport]
		[Guid("56FDF344-FD6D-11D0-958A-006097C9A090")]
		[ClassInterface(ClassInterfaceType.None)]
		class CTaskbarList { }

		static readonly ITaskbarList4 Instance;

		static Taskbar()
		{
			try { Instance = (ITaskbarList4)new CTaskbarList(); }
			// This will fail if the OS doesn't support taskbar progress (that's okay)
			catch { }
		}

		public static void SetTaskbarProgressMode(this IWin32Window window, TaskbarProgressMode mode)
		{
			if (Instance != null)
				Marshal.ThrowExceptionForHR(
					Instance.SetProgressState(window.Handle, (TBPFLAG)mode));
		}

		public static void SetTaskbarProgress(this IWin32Window window, int maxValue, int value)
		{
			if (Instance != null)
				Marshal.ThrowExceptionForHR(
					Instance.SetProgressValue(window.Handle, (ulong)value, (ulong)maxValue));
		}
	}
}
