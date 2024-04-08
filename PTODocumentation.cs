using System;
using System.Collections.Generic;

public class PTODocumentation
{
    public int DOCID { get; private set; }
    public DateTime StartDatePTO { get; private set; }
    public DateTime EndDatePTO { get; private set; }
    public int NumberDaysRequestPTO { get; private set; }
    public string TypeOfLeave { get; private set; }
    public DateTime SubmissionDate { get; private set; }
    public int EmpID { get; private set; }

    // Constructor
    public PTODocumentation(int docid, DateTime startDatePTO, DateTime endDatePTO, int numberDaysRequestPTO, string typeOfLeave, DateTime submissionDate, int empID)
    {
        DOCID = docid;
        StartDatePTO = startDatePTO;
        EndDatePTO = endDatePTO;
        NumberDaysRequestPTO = numberDaysRequestPTO;
        TypeOfLeave = typeOfLeave;
        SubmissionDate = submissionDate;
        EmpID = empID;
    }

    // Method to input documentation
    public string InputDocumentation(int DOCID)
    {
      
        return "Documentation has been input successfully.";
    }

    // Method to update a request
    public string UpdateRequest(int PTOID, int EmpID)
    {
        return "PTO request has been updated successfully.";
    }
}
