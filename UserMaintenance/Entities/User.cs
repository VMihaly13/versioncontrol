using System;




namespace UserMaintenance.Entities
{
    public class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        
        public string FullName { get; set; }

        {
            get
            {
                return string.Format(
                    "{0} {1}",
                    LastName, FirstName);
            }
        }
    }
}


