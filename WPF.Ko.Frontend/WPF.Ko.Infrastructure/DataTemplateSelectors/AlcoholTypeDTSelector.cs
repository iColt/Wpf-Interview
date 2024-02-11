using System;
using System.Windows;
using System.Windows.Controls;

public class AlcoholTypeDTSelector : DataTemplateSelector
{
    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        FrameworkElement element = container as FrameworkElement;

        if (element != null && item != null && item is Alcohol)
        {
            Task taskitem = item as Alcohol;

            if (taskitem.Type == 1)
                return
                    element.FindResource("importantTaskTemplate") as DataTemplate;
            else
                return
                    element.FindResource("myTaskTemplate") as DataTemplate;
        }

        return null;
    }
}
