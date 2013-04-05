namespace UserShortcuts
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Gtk;

    public class MyAccelMap : Gtk.AccelMap
    {
        private static Dictionary<string, Gtk.AccelKey> pendingEntries = new Dictionary<string, Gtk.AccelKey>();
        private static Dictionary<string, Gtk.AccelKey> activeEntries = new Dictionary<string, Gtk.AccelKey>();
        private static string defaultAccelFile = "accelerator_defaults.conf";
        private static string userAccelFile = "accelerator_user.conf";

        public static List<string> AccelMapChanges { get; set; }

        public static void Initialize()
        {
            MyAccelMap.AccelMapChanges = new List<string>();

            var myAccelMap = MyAccelMap.Get();
            myAccelMap.MapChanged += MyAccelMap.OnMapChanged;

            MyAccelMap.Save(MyAccelMap.defaultAccelFile);
            MyAccelMap.Load(MyAccelMap.userAccelFile);

            System.IntPtr intPtr = (System.IntPtr)0;
            MyAccelMap.Foreach(intPtr, MyAccelMap.InitEntriesForeach);
        }

        public static bool LookupActiveEntry(string accelPath, out Gtk.AccelKey accel)
        {
            if (accelPath == null)
            {
                accel = new Gtk.AccelKey();
            } 
            else if (MyAccelMap.activeEntries.TryGetValue(accelPath, out accel))
            {
                return true;
            }

            return false;
        }

        public static bool LookupPendingEntry(string accelPath, out Gtk.AccelKey accel)
        {
            if (accelPath == null)
            {
                accel = new Gtk.AccelKey();
            } 
            else if (MyAccelMap.pendingEntries.TryGetValue(accelPath, out accel))
            {
                return true;
            }
            
            return false;
        }

        public static void OnMapChanged(object o, MapChangedArgs args)
        {
            string accelPath = args.AccelPath;
            Gdk.Key accelKey = (Gdk.Key)args.AccelKey;
            Gdk.ModifierType accelMods = args.AccelMods;
            Gtk.AccelKey accel = new Gtk.AccelKey(accelKey, accelMods, Gtk.AccelFlags.Visible);

            MyAccelMap.AccelMapChanges.Add(accelPath);

            if (MyAccelMap.pendingEntries.ContainsKey(accelPath))
            {
                MyAccelMap.pendingEntries[accelPath] = accel;
            }
        }

        public static void UndoChanges()
        {
            string[] accelPaths = MyAccelMap.AccelMapChanges.ToArray();
            foreach (string accelPath in accelPaths)
            {
                Gdk.Key accelKey = MyAccelMap.activeEntries[accelPath].Key;
                Gdk.ModifierType accelMods = MyAccelMap.activeEntries[accelPath].AccelMods;
                Gtk.AccelKey accel = new Gtk.AccelKey(accelKey, accelMods, Gtk.AccelFlags.Visible);

                MyAccelMap.pendingEntries[accelPath] = accel;
            
                if (!MyAccelMap.ChangeEntry(accelPath, (uint)accelKey, accelMods, true))
                {
                    throw new Exception("Canceling changes failed.");
                }
            }
        }

        public static void SaveChanges()
        {
            string[] accelPaths = MyAccelMap.AccelMapChanges.ToArray();
            foreach (string accelPath in accelPaths)
            {
                Gdk.Key accelKey = MyAccelMap.pendingEntries[accelPath].Key;
                Gdk.ModifierType accelMods = MyAccelMap.pendingEntries[accelPath].AccelMods;
                Gtk.AccelKey accel = new Gtk.AccelKey(accelKey, accelMods, Gtk.AccelFlags.Visible);
                
                MyAccelMap.activeEntries[accelPath] = accel;
            }

            MyAccelMap.Save(MyAccelMap.userAccelFile);
        }

        public static void LoadDefaultShortcuts()
        {
            MyAccelMap.UncommentDefaultAccelFile();
            MyAccelMap.Load(MyAccelMap.defaultAccelFile);
        }

        private static void InitEntriesForeach(IntPtr data, string accelPath, uint accelKey, Gdk.ModifierType accelMods, bool changed)
        {
            Gtk.AccelKey accel = new Gtk.AccelKey((Gdk.Key)accelKey, accelMods, Gtk.AccelFlags.Visible);
            MyAccelMap.pendingEntries.Add(accelPath, accel);
            MyAccelMap.activeEntries.Add(accelPath, accel);
        }

        private static void UncommentDefaultAccelFile()
        {
            string[] text = File.ReadAllLines(MyAccelMap.defaultAccelFile);

            for (int i = 3; i < text.Length; i++)
            {
                if (text[i][0] == ';')
                {
                    text[i] = text[i].Substring(1);
                }
            }

            File.WriteAllLines(MyAccelMap.defaultAccelFile, text);
        }
    }
}