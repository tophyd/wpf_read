using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace crWordForms
{
    [DataContract]class dataConnector
    {
        [DataMember]
        private string _connector;
        [DataMember]
        private string _port;
        [DataMember]
        private string _senderid;
        [DataMember]
        private string _usingIf;
        [DataMember]
        private string _speedup;
        [DataMember]
        private string _remark;

        public dataConnector(string connector, string port, string senderid, string usingIf, string speedup, string remark) {
            this.connector = connector;
            this.port = port;
            this.senderid = senderid;
            this.usingIf = usingIf;
            this.speedup = speedup;
            this.remark = remark;
        }

        public dataConnector() {
            
            // this( " "," "," "," "," ");
        }

        public string connector {
            get { return _connector; }
            set { _connector = value; }
        }

        public string port {
            get { return _port; }
            set { _port = value; }
        }

        public string senderid {
            get { return _senderid; }
            set { _senderid = value; }
        }

        public string usingIf {
            get { return _usingIf; }
            set { _usingIf = value; }
        }

        public string speedup {
            get { return _speedup; }
            set { _speedup = value; }
        }

        public string remark {
            get { return _remark; }
            set { _remark = value; }
        }
    }


    class subjectConnectors : ISubjectArm
    {

        private dataConnector data;
        private readonly List<IView> obViews;

        public subjectConnectors(IView view)
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

        public void updateConnectors(dataConnector data)
        {
            this.data = data;
            notify();
        }

        public subjectConnectors(dataConnector data)
        {
            this.data = data;
            obViews = new List<IView>();
            //register(data);

        }
    }
}
