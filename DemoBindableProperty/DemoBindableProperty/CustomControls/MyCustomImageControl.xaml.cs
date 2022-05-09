
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoBindableProperty.CustomControls {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCustomImageControl : ContentView {

        public static readonly BindableProperty DescriptionProperty 
            = BindableProperty.Create(
                propertyName: nameof(Description),
                returnType: typeof(string),
                declaringType: typeof(MyCustomImageControl),
                defaultValue: "",
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: DescriptionPropertyChanged);

        public string Description {
            get { return base.GetValue(DescriptionProperty).ToString(); }
            set { base.SetValue(DescriptionProperty, value); }
        }

        private static void DescriptionPropertyChanged(BindableObject bindable, object oldValue, object newValue) {
            var control = (MyCustomImageControl)bindable;
            control.description.Text = newValue.ToString();
        }

        public static readonly BindableProperty ImageProperty
            = BindableProperty.Create(
                propertyName: nameof(Image),
                returnType: typeof(string),
                declaringType: typeof(MyCustomImageControl),
                defaultValue: "",
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: ImageSourcePropertyChanged);

        public string Image {
            get { return base.GetValue(ImageProperty).ToString(); }
            set { base.SetValue(ImageProperty, value); }
        }

        private static void ImageSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue) {
            var control = (MyCustomImageControl)bindable;
            control.image.Source = ImageSource.FromFile(newValue.ToString());
        }

        public MyCustomImageControl() {
            InitializeComponent();
        }
    }
}