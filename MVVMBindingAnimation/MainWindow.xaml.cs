using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVMBindingAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimation fadeInAnimation = new DoubleAnimation();
            // どの機関に合わって実行したいか指定する
            // TimeSpan.FromSecondsに指定する値は float型 ではなく double型 である必要がある
            // 1秒間アニメーションを実行する
            fadeInAnimation.Duration = TimeSpan.FromSeconds(3.0d);

            // 1秒間に透明度を0から1に変化させるアニメーションを実行する
            fadeInAnimation.From = 0.0d;
            fadeInAnimation.To = 1.0d;

            // BeginAnimationメソッドでアニメーションを実行させる
            // 第一引数にはXamlのプロパティを指定する必要がある（GridのOpacityPropertyを指定）
            // 第二引数に実行するアニメーションを指定する
            MainGrid.BeginAnimation(Grid.OpacityProperty, fadeInAnimation);

        }

        // DoubleAnimationクラスを選択中にF12キーでクラスの内容へ飛ぶと、コンストラクターで値を指定できるので試してみる
        // ちなみに指定できる引数は以下のようになっている

        /*
        //
        // 概要:
        //     Initializes a new instance of the System.Windows.Media.Animation.DoubleAnimation
        //     class.
        public DoubleAnimation()
        {
        }

        //
        // 概要:
        //     Initializes a new instance of the System.Windows.Media.Animation.DoubleAnimation
        //     class that animates from the specified starting value to the specified destination
        //     value over the specified duration.
        //
        // パラメーター:
        //   fromValue:
        //     The starting value of the animation.
        //
        //   toValue:
        //     The destination value of the animation.
        //
        //   duration:
        //     The length of time the animation takes to play from start to finish, once. See
        //     the System.Windows.Media.Animation.Timeline.Duration property for more information.
        public DoubleAnimation(double fromValue, double toValue, Duration duration)
        {
        }

        //
        // 概要:
        //     Initializes a new instance of the System.Windows.Media.Animation.DoubleAnimation
        //     class that animates from the specified starting value to the specified destination
        //     value over the specified duration and has the specified fill behavior.
        //
        // パラメーター:
        //   fromValue:
        //     The starting value of the animation.
        //
        //   toValue:
        //     The destination value of the animation.
        //
        //   duration:
        //     The length of time the animation takes to play from start to finish, once. See
        //     the System.Windows.Media.Animation.Timeline.Duration property for more information.
        //
        //   fillBehavior:
        //     Specifies how the animation behaves when it is not active.
        public DoubleAnimation(double fromValue, double toValue, Duration duration, FillBehavior fillBehavior)
        {
        }

        //
        // 概要:
        //     Initializes a new instance of the System.Windows.Media.Animation.DoubleAnimation
        //     class that animates to the specified value over the specified duration. The starting
        //     value for the animation is the base value of the property being animated or the
        //     output from another animation.
        //
        // パラメーター:
        //   toValue:
        //     The destination value of the animation.
        //
        //   duration:
        //     The length of time the animation takes to play from start to finish, once. See
        //     the System.Windows.Media.Animation.Timeline.Duration property for more information.
        public DoubleAnimation(double toValue, Duration duration)
        {
        }

        //
        // 概要:
        //     Initializes a new instance of the System.Windows.Media.Animation.DoubleAnimation
        //     class that animates to the specified value over the specified duration and has
        //     the specified fill behavior. The starting value for the animation is the base
        //     value of the property being animated or the output from another animation.
        //
        // パラメーター:
        //   toValue:
        //     The destination value of the animation.
        //
        //   duration:
        //     The length of time the animation takes to play from start to finish, once. See
        //     the System.Windows.Media.Animation.Timeline.Duration property for more information.
        //
        //   fillBehavior:
        //     Specifies how the animation behaves when it is not active.
        public DoubleAnimation(double toValue, Duration duration, FillBehavior fillBehavior)
        {
        }
        */

        /// <summary>
        /// マウスカーソルを要素に乗せるとフェードアウトするアニメーション
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            // 第一引数はFromの値を指定（型は double）
            // 第二引数はToの値を指定（型は double）
            // 第三引数に実行時間を指定
            DoubleAnimation fadeOutAnimation = new DoubleAnimation(1.0d, 0.0d, TimeSpan.FromSeconds(3d));
            MainGrid.BeginAnimation(Grid.OpacityProperty, fadeOutAnimation);
        }
    }
}
