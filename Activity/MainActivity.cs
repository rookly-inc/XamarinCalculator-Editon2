using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using System;
using System.Text;
using UK.CO.Chrisjenx.Calligraphy;
using XamarinCalculator.Helper;
using static Android.Views.View;

namespace XamarinCalculator
{
    [Activity(Label = "XamarinCalculator", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity, IOnClickListener
    {
        private Button btnSin, btnCos, btnTan, btnFactorial, btnPow;
        private Button btnClear, btnBackSpace, btnOpen, btnClose, btnSqrt;
        private Button btn7, btn8, btn9, btnDiv, btnMod;
        private Button btn4, btn5, btn6, btnMulti, btnInverse;
        private Button btn1, btn2, btn3, btnMinus, btnAdd, btnResult;
        private Button btn0, btnDot, btnPi;

        public void OnClick(View v)
        {
            throw new NotImplementedException();
        }

        protected override void AttachBaseContext(Context @base)
        {
            base.AttachBaseContext(CalligraphyContextWrapper.Wrap(@base));
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

           
            SetContentView(Resource.Layout.Main);

            
       
            }
        }
    }
