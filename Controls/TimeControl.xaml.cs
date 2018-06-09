namespace Codefarts.WPFControls
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for TimeControl.xaml
    /// </summary>
    public partial class TimeControl : UserControl
    {
        public TimeControl()
        {
            this.InitializeComponent();
        }

        public TimeSpan Value
        {
            get
            {
                return (TimeSpan) this.GetValue(ValueProperty);
            }

            set
            {
                this.SetValue(ValueProperty, value);
            }
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(TimeSpan), typeof(TimeControl), new UIPropertyMetadata(DateTime.Now.TimeOfDay, OnValueChanged));

        private static void OnValueChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var control = obj as TimeControl;
            control.Hours = ((TimeSpan)e.NewValue).Hours;
            control.Minutes = ((TimeSpan)e.NewValue).Minutes;
            control.Seconds = ((TimeSpan)e.NewValue).Seconds;
        }

        public int Hours
        {
            get
            {
                return (int) this.GetValue(HoursProperty);
            }

            set
            {
                this.SetValue(HoursProperty, value);
            }
        }

        public static readonly DependencyProperty HoursProperty = DependencyProperty.Register("Hours", typeof(int), typeof(TimeControl), new UIPropertyMetadata(0, OnTimeChanged));

        public int Minutes
        {
            get
            {
                return (int) this.GetValue(MinutesProperty);
            }

            set
            {
                this.SetValue(MinutesProperty, value);
            }
        }

        public static readonly DependencyProperty MinutesProperty = DependencyProperty.Register("Minutes", typeof(int), typeof(TimeControl), new UIPropertyMetadata(0, OnTimeChanged));

        public int Seconds
        {
            get
            {
                return (int) this.GetValue(SecondsProperty);
            }

            set
            {
                this.SetValue(SecondsProperty, value);
            }
        }

        public static readonly DependencyProperty SecondsProperty = DependencyProperty.Register("Seconds", typeof(int), typeof(TimeControl), new UIPropertyMetadata(0, OnTimeChanged));

        private static void OnTimeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var control = obj as TimeControl;
            control.Value = new TimeSpan(control.Hours, control.Minutes, control.Seconds);
        }

        private void Down(object sender, KeyEventArgs args)
        {
            switch (((Grid)sender).Name)
            {
                case "sec":
                    switch (args.Key)
                    {
                        case Key.Up:
                            this.Seconds++;
                            break;
                        case Key.Down:
                            this.Seconds--;
                            break;
                    }

                    break;

                case "min":
                    switch (args.Key)
                    {
                        case Key.Up:
                            this.Minutes++;
                            break;
                        case Key.Down:
                            this.Minutes--;
                            break;
                    }

                    break;

                case "hour":
                    switch (args.Key)
                    {
                        case Key.Up:
                            this.Hours++;
                            break;
                        case Key.Down:
                            this.Hours--;
                            break;
                    }

                    break;
            }
        }
    }
}
