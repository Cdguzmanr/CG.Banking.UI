namespace CG.Banking.BL
{
    public class Person // Superclass
    {
        // Fields


        // Properties
        public string SSN { get; set; } = "";
       
        public string FirstName { get; set; } = "";
        
        public string LastName { get; set; } = "";
        
        private string FullName { get { return FirstName + " " + LastName; } } // Read Only
        
        public DateTime DOB { get; set; } // Date of Birth
        
        public int Age { get { return DateTime.Now.Year - DOB.Year; } } // Read Only Age


        // Methods
        public override string ToString()
        {
            return FullName;
        }
    }
}