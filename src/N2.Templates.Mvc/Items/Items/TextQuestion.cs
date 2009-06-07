using System;
using MvcContrib.UI;
using N2.Details;

namespace N2.Templates.Mvc.Items.Items
{
	[PartDefinition("Text question (textbox)")]
	public class TextQuestion : Question
	{
		[EditableTextBox("Rows", 110)]
		public virtual int Rows
		{
			get { return (int) (GetDetail("Rows") ?? 1); }
			set { SetDetail("Rows", value, 1); }
		}

		[EditableTextBox("Columns", 120)]
		public virtual int? Columns
		{
			get { return (int?) GetDetail("Columns"); }
			set { SetDetail("Columns", value); }
		}

		public override string ElementID
		{
			get { return "txt_" + ID; }
		}

		public override string GetAnswerText(string value)
		{
			return value;
		}

		public override IElement CreateHtmlElement()
		{
			return new MvcContrib.UI.Tags.TextArea {Id = ElementID, Name = ElementID};
		}
	}
}