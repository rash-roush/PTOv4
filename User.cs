using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace PTOApp
{

    // Superclass User
    public class User
    {
        protected int SIN;
        protected string LName;
        protected string FName;
        protected DateTime DOB;
        protected string Address;
        protected string Email;
        protected string Phone;
        protected DateTime StartDate;
        protected DateTime EndDate;
        public List<string> ShowingWeeklySchedule { get; set; }
        public bool ConfirmationSelection { get; set; }
        public List<string> ScheduleView { get; set; }
        public bool ConfirmationReception { get; set; }

        // User constructor
        public User
            (
            int sin, 
            string lname, 
            string fname, 
            DateTime dob, 
            string address, 
            string email, 
            string phone, 
            DateTime startDate, 
            DateTime endDate
            )
        {
            SIN = sin;
            LName = lname;
            FName = fname;
            DOB = dob;
            Address = address;
            Email = email;
            Phone = phone;
            StartDate = startDate;
            EndDate = endDate;
            ShowingWeeklySchedule = new List<string>(); //empty
            ScheduleView = new List<string>(); // empty
        }

        // methods
        public void ViewPTOHistory(int EmpID)
        {
            // Define the path to the PTOHistory.vb file and open "PTOHistory.vb" window
  
            string filePath = @"C:\path\to\PTOHistory.vb";

            try
            {
                // Use Process.Start to open the file with the default application
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                // Handles exceptions
                Console.WriteLine("Unable to open the file. Error: " + ex.Message);
            }
        }

        //login purposes for DBHandler.cs
       
        
        }

}
