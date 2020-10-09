using System.Windows;

namespace WpfCustomScrollBar
{
    public static class ScrollBarAssist
    {
        #region AttachedProperty : Size

        public static double GetSize(DependencyObject obj)
            => (double)obj.GetValue(SizeProperty);

        public static void SetSize(DependencyObject obj, double value)
            => obj.SetValue(SizeProperty, value);

        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.RegisterAttached("Size",
                typeof(double), typeof(ScrollBarAssist),
                new UIPropertyMetadata(default));

        #endregion

        #region AttachedProperty : ButtonsVisibility

        public static Visibility GetButtonsVisibility(DependencyObject obj)
            => (Visibility)obj.GetValue(ButtonsVisibilityProperty);

        public static void SetButtonsVisibility(DependencyObject obj, Visibility value)
            => obj.SetValue(ButtonsVisibilityProperty, value);

        public static readonly DependencyProperty ButtonsVisibilityProperty =
            DependencyProperty.RegisterAttached("ButtonsVisibility",
                typeof(Visibility), typeof(ScrollBarAssist),
                new UIPropertyMetadata(default));

        #endregion

        #region AttachedProperty : CornerRadius

        public static CornerRadius GetCornerRadius(DependencyObject obj)
            => (CornerRadius)obj.GetValue(CornerRadiusProperty);

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
            => obj.SetValue(CornerRadiusProperty, value);

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius",
                typeof(CornerRadius), typeof(ScrollBarAssist),
                new UIPropertyMetadata(default));

        #endregion

        #region AttachedProperty : ThumbCornerRadius

        public static CornerRadius GetThumbCornerRadius(DependencyObject obj)
           => (CornerRadius)obj.GetValue(ThumbCornerRadiusProperty);

        public static void SetThumbCornerRadius(DependencyObject obj, CornerRadius value)
            => obj.SetValue(ThumbCornerRadiusProperty, value);

        public static readonly DependencyProperty ThumbCornerRadiusProperty =
            DependencyProperty.RegisterAttached("ThumbCornerRadius",
                typeof(CornerRadius), typeof(ScrollBarAssist),
                new UIPropertyMetadata(default));

        #endregion
    }
}
