using System;
using System.IO;

namespace Yaffmi
{
	class Log
	{
		StreamWriter stream;
		Exception error;

		public string FilePath { get; private set; }

		public bool FileIsOpen { get { return stream != null; } }

		public Log()
		{
			stream = null;
			error = null;

			FilePath = null;
		}

		public Exception GetLastError(bool clear = true)
		{
			Exception e = error;
			if (clear)
				error = null;

			return e;
		}

		public void ThrowLastError()
		{
			throw GetLastError();
		}

		public void OpenFile(string filePath, bool overwrite = true)
		{
			CloseFile();

			FilePath = filePath;
			try { stream = new StreamWriter(filePath, !overwrite); }
			catch (Exception e) { error = e; }
		}

		public void CloseFile()
		{
			if (stream != null)
			{
				try { stream.Close(); }
				catch { }
			}

			stream = null;
		}

		public void Write(string str)
		{
			if (stream != null)
			{
				try
				{
					stream.Write(str);
					stream.Flush();
				}
				catch (Exception e) { error = e; }
			}
		}

		public void Write(string format, params object[] args)
		{
			if (stream != null)
			{
				try
				{
					stream.Write(format, args);
					stream.Flush();
				}
				catch (Exception e) { error = e; }
			}
		}

		public void WriteLine(string str = null)
		{
			if (stream != null)
			{
				try
				{
					stream.WriteLine(str);
					stream.Flush();
				}
				catch (Exception e) { error = e; }
			}
		}

		public void WriteLine(string format, params object[] args)
		{
			if (stream != null)
			{
				try
				{
					stream.WriteLine(format, args);
					stream.Flush();
				}
				catch (Exception e) { error = e; }
			}
		}
	}
}
