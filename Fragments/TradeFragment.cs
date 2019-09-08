using System;
using System.Collections.Generic;
using Android.OS;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;
using Gallog.Interface;
using Refit;
using EDMTDialog;
using Gallog.Models;

namespace Gallog.Fragments
{


    public class TradeFragment : Fragment
    {
        Button btn_get_data;
        public event EventHandler OptionButtonWasClicked;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.tradefragment, container, false);
            btn_get_data = View.FindViewById<Button>(Resource.Id.btn_get_data);
            btn_get_data.Click += BtnOption_Click;


            return view;



        }
        private void BtnOption_Click(object sender, EventArgs e)
        {
            // Fire the event to the MainActivity
            OptionButtonWasClicked(this, sender);
        }
    }

}