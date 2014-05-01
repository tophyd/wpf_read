using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace crWordForms
{
    [DataContract] class dataUPS
    {
        [DataMember] private string typeUPS;
        [DataMember] private string ipUPS;
        
        public dataUPS(string typeUps, string ipUps) {
            this.typeUps = typeUps;
            this.ipUps = ipUps;
        }

        public dataUPS() {
            //dataUPS(" "," ");
        }
        public string typeUps {
            get { return typeUPS; }
            set { typeUPS = value; }
        }

        public string ipUps {
            get { return ipUPS; }
            set { ipUPS = value; }
        }
    }


    class subjectUPS : ISubjectArm
    {

        private dataUPS data;
        private readonly List<IView> obViews;

        public subjectUPS(IView view)
        {
            obViews = new List<IView>();

        }

        public void register(IView view)
        {
            obViews.Add(view);
        }

        public void remove(IView view)
        {
            obViews.Remove(view);
        }

        public void notify()
        {
            foreach (var view in obViews)
            {
                view.update(data);
            }
        }

        public void updateUPSes(dataUPS data)
        {
            this.data = data;
            notify();
        }

        public subjectUPS(dataUPS data)
        {
            this.data = data;
            obViews = new List<IView>();
            //register(data);

        }
    }
}
