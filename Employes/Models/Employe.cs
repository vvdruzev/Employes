using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employes.Models
{
    public class Employe
    {
        #region Local Variables  
        private string mNewFullName;
        private DateTime mNewBirthday;
        private string mNewSex;
        private string mNewSerialNumber;
        private string mNewTypeDoc;
        private DateTime mNewDataIssue;
        private string mNewAutorIssue;
        private string mNewPhoneNumber;
        private string mNewTypePhone;
        #endregion
        #region Class Properties  
        public string NewFullName
        {
            get
            {
                return mNewFullName;
            }
            set
            {
                mNewFullName = value;
            }
        }
        public DateTime NewBirthday
        {
            get
            {
                return mNewBirthday;
            }
            set
            {
                mNewBirthday = value;
            }
        }
        public string NewSex
        {
            get
            {
                return mNewSex;
            }
            set
            {
                mNewSex = value;
            }
        }
        public string NewSerialNumber
        {
            get
            {
                return mNewSerialNumber;
            }
            set
            {
                mNewSerialNumber = value;
            }
        }

        public string NewTypeDoc
        {
            get
            {
                return mNewTypeDoc;
            }
            set
            {
                mNewTypeDoc = value;
            }
        }
        public DateTime NewDataIssue
        {
            get
            {
                return mNewDataIssue;
            }
            set
            {
                mNewDataIssue = value;
            }
        }

        public string NewAutorIssue
        {
            get
            {
                return mNewAutorIssue;
            }
            set
            {
                mNewAutorIssue = value;
            }
        }

        public string NewPhoneNumber
        {
            get
            {
                return mNewPhoneNumber;
            }
            set
            {
                mNewPhoneNumber = value;
            }
        }

        public string NewTypePhone
        {
            get
            {
                return mNewTypePhone;
            }
            set
            {
                mNewTypePhone = value;
            }
        }



        #endregion

    }
}
