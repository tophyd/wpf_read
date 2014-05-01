using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace crWordForms
{
    [DataContract] public class dataEBIlock
    {
        [DataMember] private string nameEBILock;
        [DataMember] private string idEBILock;
        [DataMember] private Dictionary<string, string> eswIpEBILock;
        
        public dataEBIlock(string nameEbiLock, string idEbiLock, Dictionary<string, string> eswIpEbiLock) {
            this.nameEbiLock = nameEbiLock;
            this.idEbiLock = idEbiLock;
            this.eswIpEbiLock = eswIpEbiLock;
        }

        public dataEBIlock() {
            eswIpEBILock=new Dictionary<string, string>();
            
        }

        public Dictionary<string, string> eswIpEbiLock {
            get { return eswIpEBILock; }
            set { eswIpEBILock = value; }
        }

        public string idEbiLock {
            get { return idEBILock; }
            set { idEBILock = value; }
        }

        public string nameEbiLock {
            get { return nameEBILock; }
            set { nameEBILock = value; }
        }
    }

    class SubjectEBILock : ISubjectArm {
        private dataEBIlock data=new dataEBIlock();
        private readonly List<IView> obViews;


         public SubjectEBILock(IView view) {
            obViews=new List<IView>();
            
        }
        
        public void register(IView view) {
            //throw new NotImplementedException();
            obViews.Add(view);
        }

        public void remove(IView view) {
            //throw new NotImplementedException();
            obViews.Remove(view);
        }

        public void notify() {
           // throw new NotImplementedException();
            foreach (var view in obViews)
            {
                view.update(data);
            }
        }

        public void updateEbilock(dataEBIlock data) {
            this.data = data;
            notify();
        }

        public SubjectEBILock(dataEBIlock data) {
            this.data = data;
            obViews = new List<IView>();
        }
    }

    
}
