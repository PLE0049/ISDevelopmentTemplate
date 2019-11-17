using System;
using System.Collections.Generic;
using System.Text;

namespace TeamScheduler.Core.DomainModels
{
    public class User
    {
        // Data
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        // Behavior
        public void PromoteUser()
        {
            //TODO
        }
    }
}
