using System.Windows;
using System.Windows.Controls;
using WPF.Ko.Common.Models;

namespace WPF.Ko.Infrastructure.DataTemplateSelectors;

public class AlcoholTypeDTSelector : DataTemplateSelector
{
    public override DataTemplate SelectTemplate(object item, DependencyObject container)
    {
        FrameworkElement element = (FrameworkElement)container;

        if (element != null && item != null && item is Alcohol alcohol)
        {
            if (alcohol?.Type.Id == 2)
                return
                    element.FindResource("whiskyTypeTemplate") as DataTemplate;
            else
                return
                    element.FindResource("alcoholTypeTemplate") as DataTemplate;
        }

        return null;
    }
}