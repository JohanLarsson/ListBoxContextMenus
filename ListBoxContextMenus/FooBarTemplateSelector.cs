namespace ListBoxContextMenus
{
    using System.Windows;
    using System.Windows.Controls;

    public class FooBarTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FooTemplate { get; set; }
        public DataTemplate BarTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is Foo)
            {
                return this.FooTemplate;
            }
            else if (item is Bar)
            {
                return this.BarTemplate;
            }

            return base.SelectTemplate(item, container);
        }
    }
}