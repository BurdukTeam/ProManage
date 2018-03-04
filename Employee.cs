using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ProManage
{
    #region Enumeration
    public enum UserOperation
    {
        Create,
        Edit,
        Delete,
        Search
    }
    #endregion

    public class Employee
    {
        #region Members
        private string name;
        private string password;
        private int userid;
        private bool[] premissions = { false, false, false, false };
        private UserOperation operation;
        #endregion

        #region Methods
        public Employee(string name, int userid, string password, bool[] premissions)
        {
            this.name = name;
            this.userid = userid;
            this.password = password;
            this.premissions = premissions;
        }

        public override string ToString()
        {
            return name;
        }
        #endregion

        #region Properties
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int UserId
        {
            get
            {
                return userid;
            }
        }

        public bool[] Premissions
        {
            get
            {
                return premissions;
            }
            set
            {
                premissions = value; 
            }
        }

        public UserOperation Operation
        {
            get
            {
                return operation;
            }
            set
            {
                operation = value;
            }
        }
        #endregion
    }
}
