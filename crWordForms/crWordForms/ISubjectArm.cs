using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace crWordForms
{
    interface ISubjectArm {
        void register(IView view);
        void remove(IView view);
        void notify();
    }
}
