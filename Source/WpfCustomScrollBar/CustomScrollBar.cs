using System.Windows;
using System.Windows.Controls.Primitives;

namespace WpfCustomScrollBar
{
    public class CustomScrollBar : ScrollBar
    {
        #region Constructors

        static CustomScrollBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomScrollBar),
                new FrameworkPropertyMetadata(typeof(CustomScrollBar)));
        }

        #endregion

        #region DependencyProperty : Size

        public double Size
        {
            get => (double)GetValue(SizeProperty);
            set => SetValue(SizeProperty, value);
        }

        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register(nameof(Size), 
                typeof(double), typeof(CustomScrollBar),
                new UIPropertyMetadata(default));

        #endregion

        #region DependencyProperty : ButtonsVisibility

        public Visibility ButtonsVisibility
        {
            get => (Visibility)GetValue(ButtonsVisibilityProperty);
            set => SetValue(ButtonsVisibilityProperty, value);
        }

        public static readonly DependencyProperty ButtonsVisibilityProperty =
            DependencyProperty.Register(nameof(ButtonsVisibility),
                typeof(Visibility), typeof(CustomScrollBar),
                new UIPropertyMetadata(default));

        #endregion

        #region DependencyProperty : CornerRadius

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius),
                typeof(CornerRadius), typeof(CustomScrollBar),
                new UIPropertyMetadata(default));

        #endregion

        #region DependencyProperty : ThumbCornerRadius

        public CornerRadius ThumbCornerRadius
        {
            get => (CornerRadius)GetValue(ThumbCornerRadiusProperty);
            set => SetValue(ThumbCornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ThumbCornerRadiusProperty =
            DependencyProperty.Register(nameof(ThumbCornerRadius),
                typeof(CornerRadius), typeof(CustomScrollBar),
                new UIPropertyMetadata(default));

        #endregion
    }
}
