using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Yaffmi
{
	static class Helpers
	{
		public static XmlElement AppendNewChildElement(this XmlNode node, string name)
		{
			XmlDocument document = node.OwnerDocument ?? (XmlDocument)node;
			XmlElement element = document.CreateElement(name);
			node.AppendChild(element);
			return element;
		}

		public static XmlElement AppendNewChildElement(this XmlNode node, string name, string text)
		{
			XmlElement element = node.AppendNewChildElement(name);
			element.InnerText = text;
			return element;
		}

		public static bool ContainsAny(this string str, params char[] value)
		{
			return str.IndexOfAny(value) != -1;
		}

		public static string GetChildText(this XmlNode node, string childName)
		{
			XmlNode child = node[childName];
			return
				(child != null) ?
				child.InnerText :
				null;
		}

		public static void RefreshItems(this ListBox control)
		{
			object[] items = control.Items
				.Cast<object>()
				.ToArray();
			control.BeginUpdate();
			foreach (object item in items)
				control.Items.Remove(item);
			control.Items.AddRange(items);
			control.EndUpdate();
		}

		public static void RefreshItems(this ComboBox control)
		{
			object[] items = control.Items
				.Cast<object>()
				.ToArray();
			control.BeginUpdate();
			foreach (object item in items)
				control.Items.Remove(item);
			control.Items.AddRange(items);
			control.EndUpdate();
		}

		public static bool ToBool(string str)
		{
			if (String.IsNullOrWhiteSpace(str))
				return false;
			str = str.Trim();
			if (String.Equals(str, "false", StringComparison.OrdinalIgnoreCase))
				return false;
			double val;
			if (Double.TryParse(str, out val) &&
				val == 0)
				return false;
			return true;
		}

		public static int ToInt(string str)
		{
			int i;
			Int32.TryParse(str, NumberStyles.Integer, CultureInfo.InvariantCulture, out i);
			return i;
		}

		public static T Clamp<T>(T value, T min, T max) where T : IComparable
		{
			if (value == null)
				return default(T);
			if (value.CompareTo(min) < 0)
				return min;
			if (value.CompareTo(max) > 0)
				return max;
			return value;
		}

		public static T ClampMin<T>(T value, T min) where T : IComparable
		{
			if (value == null)
				return default(T);
			if (value.CompareTo(min) < 0)
				return min;
			return value;
		}

		public static T ClampMax<T>(T value, T max) where T : IComparable
		{
			if (value == null)
				return default(T);
			if (value.CompareTo(max) > 0)
				return max;
			return value;
		}
	}

	class ControlValueException : Exception
	{
		const string MessageTemplate = "The {0} is not valid.";

		public Control Control { get; private set; }
		public string ControlDescription { get; private set; }

		public ControlValueException(Control control, string controlDescription)
			: base(String.Format(MessageTemplate, controlDescription))
		{
			Control = control;
			ControlDescription = controlDescription;
		}

		public void Focus()
		{
			if (Control != null)
			{
				if (Control.Parent is TabPage &&
					Control.Parent.Parent is TabControl)
					((TabControl)Control.Parent.Parent)
						.SelectedTab = (TabPage)Control.Parent;
				Control.Focus();
				if (Control is TextBoxBase)
					((TextBoxBase)Control).SelectAll();
			}
		}

		public void ShowMessage(IWin32Window window = null)
		{
			MessageBox.Show(window,
				Message, "Invalid Option",
				MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}
	}
}
