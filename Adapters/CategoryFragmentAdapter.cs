﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Ketogo.Fragments;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;

namespace Ketogo.Adapters
{
    public class CategoryFragmentAdapter: FragmentPagerAdapter
    {
        private readonly List<string> _categories = new List<string>() {"Restaurant", "Cafe", "Store", "School", "Doctor"};

        public CategoryFragmentAdapter(FragmentManager fm) : base(fm)
        {
            
        }

        public override int Count => _categories.Count;

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            PlaceCategoryFragment placeCategoryFragment = new PlaceCategoryFragment(_categories[position]);
            return placeCategoryFragment;
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            if (_categories[position] == "Restaurant")
            {
                return new Java.Lang.String("Reštaurácie");
            }
            else if (_categories[position] == "Cafe")
            {
                return new Java.Lang.String("Kaviarne");
            }
            else if (_categories[position] == "Store")
            {
                return new Java.Lang.String("Obchody");
            }
            else if (_categories[position] == "School")
            {
                return new Java.Lang.String("Školy");
            }
            else
            {
                return new Java.Lang.String("Doktori");
            }
        }
    }
}