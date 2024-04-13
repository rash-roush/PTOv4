

CREATE TABLE PTORequest (
    EmpID INT,
    StartDate DATE,
    EndDate DATE,
    ReqDate DATE,
    Type BIT, -- Assuming Type is a boolean with True/False values
    Reason VARCHAR(255) -- Adjust the length as necessary
);

INSERT INTO PTORequest(EmpID, StartDate, EndDate, ReqDate, Type, Reason) VALUES
(10000, '2001-01-01', '2001-01-15', '2000-12-15', 1, 'End of fiscal year.'),
(11111, '2001-01-01', '2001-01-15', '2000-12-15', 1, 'Pregnancy'),
(00000, '2001-01-01', '2001-01-15', '2000-12-15', 1, 'Vacation');




