using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;

namespace crWordForms
{
    public interface IView {
        void update(Object mes);

    }

    public interface IDisplayView {
        void display();
    }


}
