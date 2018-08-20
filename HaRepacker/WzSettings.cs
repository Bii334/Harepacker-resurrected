﻿/* Copyright (C) 2015 haha01haha01

* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using MapleLib.WzLib;
using System.Drawing;
using MapleLib.WzLib.Serialization;

namespace HaRepacker
{
    public static class UserSettings
    {
        public static int Indentation = 0;
        public static LineBreak LineBreakType = LineBreak.None;
        public static string DefaultXmlFolder = "";
        public static bool UseApngIncompatibilityFrame = true;
        public static bool AutoAssociate = true;
        public static bool AutoUpdate = true;
        public static bool Sort = true;
        public static bool SuppressWarnings = false;
        public static bool ParseImagesInSearch = false;
        public static bool SearchStringValues = true;

        // Animate
        public static bool devImgSequences = false;
        public static bool cartesianPlane = true;
        public static int delayNextLoop = 60;

        public static bool Plane = true;
        public static int PlanePosition = 0;//center

        // Themes
        public static int ThemeColor = 1;//white = 1, black = 0
    }

    public static class ApplicationSettings
    {
        public static bool Maximized = false;
        public static Size WindowSize = new Size(1024, 800);//new Size(800, 600);
        public static bool FirstRun = true;
        public static string LastBrowserPath = "";
        public static WzMapleVersion MapleVersion = WzMapleVersion.BMS;
        public static string UpdateServer = "";
    }
    public static class Constants
    {
        public const int Version = 423;
        public const int TimeStartAnimateDefault = 60;
    }
}