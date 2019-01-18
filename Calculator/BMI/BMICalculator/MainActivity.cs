using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Graphics;
//Test Namespace
namespace BMICalculator
{
    [Activity(Label = "BMICalculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        EditText txtWeight;
        EditText txtHeight;
        Button btnCalculate;
        TextView txtvResult;
      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            txtWeight = FindViewById<EditText>(Resource.Id.WeightText);
            txtHeight = FindViewById<EditText>(Resource.Id.HeightText);
            btnCalculate = FindViewById<Button>(Resource.Id.Calculate);
            txtvResult = FindViewById<TextView>(Resource.Id.ResultText);
 
            btnCalculate.Click += OnCalculateClick;
        }

        void OnCalculateClick(object sender, EventArgs e)
        {
            string height = txtHeight.Text;
            string weight = txtWeight.Text;

            var inputHeight = double.Parse(height);
            var inputWeight = double.Parse(weight);
            var heightSqrd = Math.Pow(inputHeight,2.0);
            var bmi = inputWeight / heightSqrd;
            txtvResult.Text = (Math.Round(bmi,2)).ToString();
        }
    }
}

