using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Markup;

namespace crWordForms
{
   [DataContract] public class dataARM {
       [DataMember] private string nameARM;
       [DataMember] private Dictionary<string, string> numberLAN;
       [DataMember] private string _ipAddress;
       [DataMember] private string _password;
       [DataMember] private string pwrON;
       [DataMember] private string senderID;
       [DataMember] private string _numberVideo;
       [DataMember] private Dictionary<string, bool> _servicesRun = new Dictionary<string, bool>();
       private string lan1;
       private string lan2;
       private string commaLAN;
        //private Dictionary<string, bool> _servicesRun;
       public string LAN {
           get { return lan1 + " "+ lan2; }
           set { commaLAN = value; }
       }
       
       public string Lan1 {
           get { return lan1; }
           set { lan1 = value; }
       }
       public string Lan2
       {
           get { return lan2; }
           set { lan2 = value; }
       }

        public string ipAddress {
            get { return _ipAddress; }
            set { _ipAddress = value; }
        }

        public string password {
            get { return _password; }
            set { _password = value; }
        }

        public string pwrOn {
            get { return pwrON; }
            set { pwrON = value; }
        }

        public string senderId {
            get { return senderID; }
            set { senderID = value; }
        }

        public string numberVideo {
            get { return _numberVideo; }
            set { _numberVideo = value; }
        }

        public Dictionary<string, bool> servicesRun {
            get { return _servicesRun; }
            set { _servicesRun = value; }
        }

        public string nameArm {
            get { return nameARM; }
            set { nameARM = value; }
        }

        public Dictionary<string, string> numberLan {
            get { return numberLAN; }
            set { numberLAN = value; }
        }

        public dataARM() {
            servicesRun.Add("RcosServer", false);
            servicesRun.Add("Apk dk", false);
            servicesRun.Add("Setun", false);
            servicesRun.Add("UpsMon", false);
            servicesRun.Add("ServiceMonitoring", false);
        }
        //  public setnameARM()
    }
    class subjectARM :ISubjectArm {

        private readonly dataARM data;
        private readonly List<IView> obViews;

        public subjectARM(IView view) {
            obViews=new List<IView>();
            
        }

        public void register(IView view) {
            obViews.Add(view);
        }

        public void remove(IView view) {
            obViews.Remove(view);
        }

        public void notify() {
            foreach (var view in obViews) {
                view.update(data);
            }
        }

        public subjectARM(dataARM data) {
            this.data = data;
            obViews = new List<IView>();
            //register(data);

        }
    }
}
