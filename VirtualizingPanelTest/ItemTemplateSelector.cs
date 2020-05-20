using System.Windows;
using System.Windows.Controls;

namespace VirtualizingPanelTest
{
	public class ItemTemplateSelector : DataTemplateSelector
	{
		public DataTemplate LargeItemTemplate { get; set; }

		public DataTemplate SmallItemTemplate { get; set; }

		public override DataTemplate SelectTemplate(object item, DependencyObject container)
		{
			if (item is LargeItemModel)
				return LargeItemTemplate;
			else
				return SmallItemTemplate;
		}
	}
}