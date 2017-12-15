namespace ListBoxContextMenus
{
    using System.Collections.ObjectModel;

    public class ViewModel
    {
        public ObservableCollection<object> Items { get; } = new ObservableCollection<object> {new Foo(), new Bar()};
    }
}