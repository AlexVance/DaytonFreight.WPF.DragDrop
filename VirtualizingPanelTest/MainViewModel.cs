using System;
using System.Collections.ObjectModel;

namespace VirtualizingPanelTest
{
	public class MainViewModel
	{
		public MainViewModel()
		{
			var random = new Random();

			for (var i = 0; i < 100; i++)
			{
				if (random.Next(100) < 50)
					Items.Add(new SmallItemModel()
					{
						Id = i,
						Name = $"Item {i}"
					});
				else
					Items.Add(new LargeItemModel()
					{
						Id = i,
						Name = $"Item {i}",
						SomeOtherProperty = $"Some other property {i}"
					});
			}
		}

		private ObservableCollection<object> _items = new ObservableCollection<object>();

		public ObservableCollection<object> Items { get; set; } = new ObservableCollection<object>();
	}
}