using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Windows;

namespace crWordForms
{
    class CurCondDisplay : IView, IDisplayView {
        private dataARM data;
        private ISubjectArm arm;
        public void update(object mes) {
            this.data = (dataARM) mes;

        }

        public CurCondDisplay(ISubjectArm arm) {
            this.arm = arm;
            this.arm.register(this);
        }

        public void display() {
            MessageBox.Show(data.nameArm);

        }
    }
}
