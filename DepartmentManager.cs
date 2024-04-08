using System;
using System.Collections.Generic;
using PTOApp;

namespace PTOApp
{
    // DepartmentManager subclass
    public class DepartmentManager : User
    {
        public int DepManID;
        public string DepName;
        public bool Eligibility;
        public string ApprovalStatus;
        public List<User> EmpOfDepMan;
    
        //constructor
        public DepartmentManager(
        int sin,
        string lname,
        string fname,
        DateTime dob,
        string address,
        string email,
        string phone,
        DateTime startDate,
        DateTime endDate,
        int depManID,
        string depName,
        bool eligibility,
        string approvalStatus)

            
            : base(sin, lname, fname, dob, address, email, phone, startDate, endDate)
        {
            DepManID = depManID;
            DepName = depName;
            Eligibility = eligibility;
            ApprovalStatus = approvalStatus;
            EmpOfDepMan = new List<User>();
        }

        public void ApproveModificationRequest() 
        {
        // need DB
        }
        public void ApproveCancelRequest() 
        { 
        // need DB
        }
        public int AccessPTO(int PTOID) 
        {
            return 0;
        }
        public int AccessData(int DBHandlerID) 
        {
            return 0;
        }
        public List<string> SendScheduleToEmployee(int ScheduleID) 
        {
            List<string> notificationDetails = new List<string>
                {
                 //$"Schedule {ScheduleID} sent to employee {EmpID}."
                };
            return notificationDetails;
        }
    }
}