using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Android.Net;
using ScheduleApp.Droid;
using Android.Media;
using Xamarin.Forms;
using Android.Content.PM;
using Android.Util;
using System.Diagnostics;

[assembly: Xamarin.Forms.Dependency(typeof(LocalRingTones))]

//This is the Android part of the GetRingtones
namespace ScheduleApp.Droid
{
    public class LocalRingTones : iRingTones
    {
        //need an empty parameterless constructor so dependency service can create new instances. 
        public LocalRingTones() { }

        public void GetRingTones1()
        {
            Intent intent = new Intent(RingtoneManager.ActionRingtonePicker);
            intent.PutExtra(RingtoneManager.ExtraRingtoneTitle, "Select ringtone for notifications:");
            intent.PutExtra(RingtoneManager.ExtraRingtoneShowSilent, false);
            intent.PutExtra(RingtoneManager.ExtraRingtoneShowDefault, true);
            intent.PutExtra(RingtoneManager.ExtraRingtoneType, "TYPE_ALL");

            ((Activity)Forms.Context).StartActivityForResult(intent, 0);
            
        }

       
    }


}

