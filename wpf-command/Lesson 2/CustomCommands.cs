using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Lesson_2 {
    public class CustomCommands
    {
        private static RoutedUICommand launchCommand;

        public static RoutedUICommand Launch
        {
            get { return launchCommand; }
        }

        static CustomCommands()
        {
            InputGestureCollection myInputGestures =new InputGestureCollection();
            myInputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            launchCommand=new RoutedUICommand("Launch", "Launch", typeof(CustomCommands), myInputGestures);

        }
    }
}
